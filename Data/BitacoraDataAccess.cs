using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NLog;
using InvSis.Utilities;
using InvSis.Model;
using System.Data;
using NpgsqlTypes;

namespace InvSis.Data
{
    public class BitacoraDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("InvSis.Data.BitacoraDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;
        private readonly MovimientoProductoDataAccess _movimientoProductoData;
        private readonly UsuariosDataAccess _usuarioData;

        public BitacoraDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
                _movimientoProductoData = new MovimientoProductoDataAccess();
                _usuarioData = new UsuariosDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al inicializar BitacoraDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Inserta un nuevo registro en la bitácora
        /// </summary>
        /// <param name="bitacora">Objeto Bitacora con los datos a insertar</param>
        /// <returns>ID generado para la auditoría o -1 si ocurre un error</returns>
        public int InsertarRegistroBitacora(Bitacora bitacora)
        {
            try
            {
                string query = "INSERT INTO Bitacora (id_movimiento_producto, id_usuario, id_equipo, nombre_equipo, fecha, tipo_movimiento) " +
                              "VALUES (@IdMovimientoProducto, @IdUsuario, @IdEquipo, @NombreEquipo, @Fecha, @TipoMovimiento) " +
                              "RETURNING id_auditoria";

                // Crea parámetros para la consulta
                NpgsqlParameter paramMovimientoProducto = _dbAccess.CreateParameter("@IdMovimientoProducto",
                    bitacora.IdMovimientoProducto.HasValue ? (object)bitacora.IdMovimientoProducto.Value : DBNull.Value);
                NpgsqlParameter paramUsuario = _dbAccess.CreateParameter("@IdUsuario",
                    bitacora.IdUsuario.HasValue ? (object)bitacora.IdUsuario.Value : DBNull.Value);
                NpgsqlParameter paramIdEquipo = _dbAccess.CreateParameter("@IdEquipo", bitacora.IdEquipo);
                NpgsqlParameter paramNombreEquipo = _dbAccess.CreateParameter("@NombreEquipo", bitacora.NombreEquipo);
                NpgsqlParameter paramFecha = _dbAccess.CreateParameter("@Fecha", bitacora.Fecha);
                NpgsqlParameter paramTipoMovimiento = _dbAccess.CreateParameter("@TipoMovimiento", bitacora.TipoMovimiento);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la inserción y obtiene el ID generado
                object? resultado = _dbAccess.ExecuteScalar(query, paramMovimientoProducto, paramUsuario,
                                                         paramIdEquipo, paramNombreEquipo, paramFecha, paramTipoMovimiento);

                // Convierte el resultado a entero
                int idGenerado = Convert.ToInt32(resultado);
                _logger.Info($"Registro de bitácora insertado correctamente con ID: {idGenerado}");

                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar el registro en la bitácora. Tipo de movimiento: {bitacora.TipoMovimiento}");
                return -1;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene un registro de la bitácora por su ID
        /// </summary>
        /// <param name="idAuditoria">ID del registro de auditoría a buscar</param>
        /// <returns>Objeto Bitacora si existe, null si no se encuentra</returns>
        public Bitacora? ObtenerRegistroBitacoraPorId(int idAuditoria)
        {
            try
            {
                string query = @"
                    SELECT id_auditoria, id_movimiento_producto, id_usuario, id_equipo, 
                           nombre_equipo, fecha, tipo_movimiento
                    FROM Bitacora
                    WHERE id_auditoria = @IdAuditoria";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdAuditoria", idAuditoria);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta con el parámetro
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramId);

                if (resultado.Rows.Count == 0)
                {
                    _logger.Warn($"No se encontró ningún registro de bitácora con ID {idAuditoria}");
                    return null;
                }

                // Obtiene la primera fila (debería ser la única)
                DataRow row = resultado.Rows[0];

                // Crear el objeto Bitacora
                Bitacora bitacora = new Bitacora(
                    Convert.ToInt32(row["id_auditoria"]),
                    row["id_movimiento_producto"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_movimiento_producto"]) : null,
                    row["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_usuario"]) : null,
                    row["id_equipo"].ToString() ?? "",
                    row["nombre_equipo"].ToString() ?? "",
                    Convert.ToDateTime(row["fecha"]),
                    row["tipo_movimiento"].ToString() ?? ""
                );

                // Obtener el MovimientoProducto asociado si existe
                if (bitacora.IdMovimientoProducto.HasValue)
                {
                    MovimientoProducto? movimientoProducto = _movimientoProductoData.ObtenerMovimientoProductoPorId(bitacora.IdMovimientoProducto.Value);
                    if (movimientoProducto != null)
                    {
                        bitacora.MovimientoProducto = movimientoProducto;
                    }
                }

                // Obtener el Usuario asociado si existe
                if (bitacora.IdUsuario.HasValue)
                {
                    Usuario? usuario = _usuarioData.ObtenerUsuarioPorId(bitacora.IdUsuario.Value);
                    if (usuario != null)
                    {
                        bitacora.Usuario = usuario;
                    }
                }

                return bitacora;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener el registro de bitácora con ID {idAuditoria}");
                return null;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene todos los registros de la bitácora con filtros opcionales
        /// </summary>
        /// <param name="fechaInicio">Fecha inicial para filtrar (opcional)</param>
        /// <param name="fechaFin">Fecha final para filtrar (opcional)</param>
        /// <param name="tipoMovimiento">Tipo de movimiento para filtrar (opcional)</param>
        /// <param name="idUsuario">ID del usuario para filtrar (opcional)</param>
        /// <returns>Lista de registros de bitácora que cumplen con los filtros</returns>
        public List<Bitacora> ObtenerRegistrosBitacora(DateTime? fechaInicio = null, DateTime? fechaFin = null,
                                                       string? tipoMovimiento = null, int? idUsuario = null)
        {
            List<Bitacora> registros = new List<Bitacora>();

            try
            {
                string query = @"
                    SELECT id_auditoria, id_movimiento_producto, id_usuario, id_equipo, 
                           nombre_equipo, fecha, tipo_movimiento
                    FROM Bitacora
                    WHERE 1=1"; // 1=1 es para que siempre se cumpla la condición

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                // Filtro por rango de fechas
                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query += " AND fecha BETWEEN @FechaInicio AND @FechaFin";
                    parametros.Add(_dbAccess.CreateParameter("@FechaInicio", fechaInicio.Value));
                    parametros.Add(_dbAccess.CreateParameter("@FechaFin", fechaFin.Value));
                }

                // Filtro por tipo de movimiento
                if (!string.IsNullOrEmpty(tipoMovimiento))
                {
                    query += " AND tipo_movimiento = @TipoMovimiento";
                    parametros.Add(_dbAccess.CreateParameter("@TipoMovimiento", tipoMovimiento));
                }

                // Filtro por usuario
                if (idUsuario.HasValue)
                {
                    query += " AND id_usuario = @IdUsuario";
                    parametros.Add(_dbAccess.CreateParameter("@IdUsuario", idUsuario.Value));
                }

                // Ordenar por fecha descendente (más reciente primero)
                query += " ORDER BY fecha DESC";

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta con los parámetros
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                // Procesar los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Bitacora bitacora = new Bitacora(
                        Convert.ToInt32(row["id_auditoria"]),
                        row["id_movimiento_producto"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_movimiento_producto"]) : null,
                        row["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_usuario"]) : null,
                        row["id_equipo"].ToString() ?? "",
                        row["nombre_equipo"].ToString() ?? "",
                        Convert.ToDateTime(row["fecha"]),
                        row["tipo_movimiento"].ToString() ?? ""
                    );

                    registros.Add(bitacora);
                }

                _logger.Info($"Se obtuvieron {registros.Count} registros de bitácora con los filtros aplicados");
                return registros;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener los registros de bitácora de la base de datos");
                return registros; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene los registros de bitácora asociados a un movimiento de producto
        /// </summary>
        /// <param name="idMovimientoProducto">ID del movimiento de producto</param>
        /// <returns>Lista de registros de bitácora asociados al movimiento</returns>
        public List<Bitacora> ObtenerRegistrosPorMovimientoProducto(int idMovimientoProducto)
        {
            List<Bitacora> registros = new List<Bitacora>();

            try
            {
                string query = @"
                    SELECT id_auditoria, id_movimiento_producto, id_usuario, id_equipo, 
                           nombre_equipo, fecha, tipo_movimiento
                    FROM Bitacora
                    WHERE id_movimiento_producto = @IdMovimientoProducto
                    ORDER BY fecha DESC";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdMovimientoProducto", idMovimientoProducto);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta con el parámetro
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramId);

                // Procesar los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Bitacora bitacora = new Bitacora(
                        Convert.ToInt32(row["id_auditoria"]),
                        row["id_movimiento_producto"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_movimiento_producto"]) : null,
                        row["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_usuario"]) : null,
                        row["id_equipo"].ToString() ?? "",
                        row["nombre_equipo"].ToString() ?? "",
                        Convert.ToDateTime(row["fecha"]),
                        row["tipo_movimiento"].ToString() ?? ""
                    );

                    registros.Add(bitacora);
                }

                _logger.Info($"Se obtuvieron {registros.Count} registros de bitácora para el movimiento de producto ID {idMovimientoProducto}");
                return registros;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener los registros de bitácora para el movimiento de producto ID {idMovimientoProducto}");
                return registros; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene los registros de bitácora realizados por un usuario específico
        /// </summary>
        /// <param name="idUsuario">ID del usuario</param>
        /// <returns>Lista de registros de bitácora del usuario</returns>
        public List<Bitacora> ObtenerRegistrosPorUsuario(int idUsuario)
        {
            List<Bitacora> registros = new List<Bitacora>();

            try
            {
                string query = @"
                    SELECT id_auditoria, id_movimiento_producto, id_usuario, id_equipo, 
                           nombre_equipo, fecha, tipo_movimiento
                    FROM Bitacora
                    WHERE id_usuario = @IdUsuario
                    ORDER BY fecha DESC";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdUsuario", idUsuario);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta con el parámetro
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramId);

                // Procesar los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Bitacora bitacora = new Bitacora(
                        Convert.ToInt32(row["id_auditoria"]),
                        row["id_movimiento_producto"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_movimiento_producto"]) : null,
                        row["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(row["id_usuario"]) : null,
                        row["id_equipo"].ToString() ?? "",
                        row["nombre_equipo"].ToString() ?? "",
                        Convert.ToDateTime(row["fecha"]),
                        row["tipo_movimiento"].ToString() ?? ""
                    );

                    registros.Add(bitacora);
                }

                _logger.Info($"Se obtuvieron {registros.Count} registros de bitácora para el usuario ID {idUsuario}");
                return registros;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener los registros de bitácora para el usuario ID {idUsuario}");
                return registros; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Elimina un registro de la bitácora (operación administrativa)
        /// </summary>
        /// <param name="idAuditoria">ID del registro a eliminar</param>
        /// <returns>True si se eliminó correctamente, False si hubo un error</returns>
        public bool EliminarRegistroBitacora(int idAuditoria)
        {
            try
            {
                string query = "DELETE FROM Bitacora WHERE id_auditoria = @IdAuditoria";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdAuditoria", idAuditoria);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la eliminación
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, paramId);

                bool exito = filasAfectadas > 0;
                if (exito)
                {
                    _logger.Info($"Registro de bitácora con ID {idAuditoria} eliminado correctamente");
                }
                else
                {
                    _logger.Warn($"No se pudo eliminar el registro de bitácora con ID {idAuditoria}. No se encontró el registro");
                }

                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar el registro de bitácora con ID {idAuditoria}");
                return false;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }
    }
}