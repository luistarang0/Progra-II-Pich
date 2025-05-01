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
    public class UsuariosDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("InvSis.Data.UsuariosDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;
        private readonly PersonasDataAccess _personasData;
        private readonly RolesDataAccess _rolesData;

        public UsuariosDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
                _personasData = new PersonasDataAccess();
                _rolesData = new RolesDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al inicializar UsuariosDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Inserta un nuevo usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Objeto Usuario con la información a insertar</param>
        /// <returns>El ID generado si fue exitoso, -1 en caso de error</returns>
        public int InsertarUsuario(Usuario usuario)
        {
            try
            {
                // Verificar si la persona y el rol existen
                var persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                if (persona == null)
                {
                    _logger.Warn($"No se puede insertar usuario: La persona con ID {usuario.IdPersona} no existe");
                    return -1;
                }

                var rol = _rolesData.ObtenerRolPorId(usuario.IdRol);
                if (rol == null)
                {
                    _logger.Warn($"No se puede insertar usuario: El rol con ID {usuario.IdRol} no existe");
                    return -1;
                }

                // Verificar si el nickname ya existe
                if (ExisteNickname(usuario.Nickname))
                {
                    _logger.Warn($"No se puede insertar usuario: El nickname {usuario.Nickname} ya está en uso");
                    return -1;
                }

                string query = @"INSERT INTO Usuarios (id_rol, id_persona, nickname, contrasena, estatus) 
                                VALUES (@IdRol, @IdPersona, @Nickname, @Contrasena, @Estatus) 
                                RETURNING id_usuario";

                // Crea parámetros para la consulta
                NpgsqlParameter paramIdRol = _dbAccess.CreateParameter("@IdRol", usuario.IdRol);
                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@IdPersona", usuario.IdPersona);
                NpgsqlParameter paramNickname = _dbAccess.CreateParameter("@Nickname", usuario.Nickname);
                NpgsqlParameter paramContrasena = _dbAccess.CreateParameter("@Contrasena", usuario.Contraseña);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", usuario.Estatus);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la inserción y obtiene el ID generado
                object? resultado = _dbAccess.ExecuteScalar(query, paramIdRol, paramIdPersona, paramNickname, paramContrasena, paramEstatus);

                // Convierte el resultado a entero
                int idGenerado = Convert.ToInt32(resultado);
                _logger.Info($"Usuario insertado correctamente con ID: {idGenerado}");

                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al insertar el usuario {usuario.Nickname}");
                return -1;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Actualiza los datos de un usuario existente
        /// </summary>
        /// <param name="usuario">Objeto Usuario con la información actualizada</param>
        /// <returns>True si la actualización fue exitosa, False en caso contrario</returns>
        public bool ActualizarUsuario(Usuario usuario)
        {
            try
            {
                // Verificar si el usuario existe
                var usuarioExistente = ObtenerUsuarioPorId(usuario.IdUsuario);
                if (usuarioExistente == null)
                {
                    _logger.Warn($"No se puede actualizar: El usuario con ID {usuario.IdUsuario} no existe");
                    return false;
                }

                // Verificar si la persona y el rol existen
                var persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                if (persona == null)
                {
                    _logger.Warn($"No se puede actualizar usuario: La persona con ID {usuario.IdPersona} no existe");
                    return false;
                }

                var rol = _rolesData.ObtenerRolPorId(usuario.IdRol);
                if (rol == null)
                {
                    _logger.Warn($"No se puede actualizar usuario: El rol con ID {usuario.IdRol} no existe");
                    return false;
                }

                // Verificar si el nickname ya existe (y no es el mismo usuario)
                if (ExisteNickname(usuario.Nickname, usuario.IdUsuario))
                {
                    _logger.Warn($"No se puede actualizar usuario: El nickname {usuario.Nickname} ya está en uso");
                    return false;
                }

                string query = @"UPDATE Usuarios 
                                SET id_rol = @IdRol, 
                                    id_persona = @IdPersona, 
                                    nickname = @Nickname, 
                                    contrasena = @Contrasena, 
                                    estatus = @Estatus 
                                WHERE id_usuario = @IdUsuario";

                // Crea los parámetros
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdUsuario", usuario.IdUsuario);
                NpgsqlParameter paramIdRol = _dbAccess.CreateParameter("@IdRol", usuario.IdRol);
                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@IdPersona", usuario.IdPersona);
                NpgsqlParameter paramNickname = _dbAccess.CreateParameter("@Nickname", usuario.Nickname);
                NpgsqlParameter paramContrasena = _dbAccess.CreateParameter("@Contrasena", usuario.Contraseña);
                NpgsqlParameter paramEstatus = _dbAccess.CreateParameter("@Estatus", usuario.Estatus);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la actualización
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, paramId, paramIdRol, paramIdPersona, paramNickname, paramContrasena, paramEstatus);

                bool exito = filasAfectadas > 0;
                if (exito)
                {
                    _logger.Info($"Usuario con ID {usuario.IdUsuario} actualizado correctamente");
                }
                else
                {
                    _logger.Warn($"No se pudo actualizar el usuario con ID {usuario.IdUsuario}. No se encontró el registro");
                }

                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el usuario con ID {usuario.IdUsuario}");
                return false;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Elimina lógicamente un usuario cambiando su estatus a inactivo (2)
        /// </summary>
        /// <param name="idUsuario">ID del usuario a eliminar</param>
        /// <returns>True si la eliminación fue exitosa, False en caso contrario</returns>
        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                string query = "UPDATE Usuarios SET estatus = 2 WHERE id_usuario = @IdUsuario";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdUsuario", idUsuario);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la actualización
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, paramId);

                bool exito = filasAfectadas > 0;
                if (exito)
                {
                    _logger.Info($"Usuario con ID {idUsuario} desactivado correctamente");
                }
                else
                {
                    _logger.Warn($"No se pudo desactivar el usuario con ID {idUsuario}. No se encontró el registro");
                }

                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al desactivar el usuario con ID {idUsuario}");
                return false;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene un usuario por su ID
        /// </summary>
        /// <param name="idUsuario">ID del usuario a buscar</param>
        /// <returns>Objeto Usuario si se encuentra, null si no existe</returns>
        public Usuario? ObtenerUsuarioPorId(int idUsuario)
        {
            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE id_usuario = @IdUsuario";

                // Crea el parámetro
                NpgsqlParameter paramId = _dbAccess.CreateParameter("@IdUsuario", idUsuario);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramId);

                if (resultado.Rows.Count == 0)
                {
                    _logger.Warn($"No se encontró ningún usuario con ID {idUsuario}");
                    return null;
                }

                // Obtiene la primera fila (debería ser la única)
                DataRow row = resultado.Rows[0];

                // Crear y devolver el objeto Usuario
                Usuario usuario = new Usuario(
                    Convert.ToInt32(row["id_usuario"]),
                    Convert.ToInt32(row["id_rol"]),
                    Convert.ToInt32(row["id_persona"]),
                    row["nickname"].ToString() ?? "",
                    row["contrasena"].ToString() ?? "",
                    Convert.ToInt32(row["estatus"])
                );

                // Obtener datos relacionados
                usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                return usuario;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener el usuario con ID {idUsuario}");
                return null;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios de la base de datos
        /// </summary>
        /// <param name="soloActivos">Indica si solo se deben obtener los usuarios activos</param>
        /// <returns>Lista de objetos Usuario</returns>
        public List<Usuario> ObtenerTodosLosUsuarios(bool soloActivos = true)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE 1=1";

                // Si solo se quieren los activos, añade la condición
                if (soloActivos)
                {
                    query += " AND estatus = 1";
                }

                // Ordena por nickname
                query += " ORDER BY nickname";

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                // Procesa los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_rol"]),
                        Convert.ToInt32(row["id_persona"]),
                        row["nickname"].ToString() ?? "",
                        row["contrasena"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    );

                    // Obtener datos relacionados
                    usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                    usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                    usuarios.Add(usuario);
                }

                _logger.Info($"Se obtuvieron {usuarios.Count} usuarios de la base de datos");
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener todos los usuarios");
                return usuarios; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Busca usuarios por nickname (búsqueda parcial)
        /// </summary>
        /// <param name="nicknameBusqueda">Texto a buscar en el nickname</param>
        /// <returns>Lista de usuarios que coinciden con la búsqueda</returns>
        public List<Usuario> BuscarUsuariosPorNickname(string nicknameBusqueda)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE nickname ILIKE @NicknameBusqueda
                               ORDER BY nickname";

                // Crea el parámetro (con comodines para búsqueda parcial)
                NpgsqlParameter paramNickname = _dbAccess.CreateParameter("@NicknameBusqueda", $"%{nicknameBusqueda}%");

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramNickname);

                // Procesa los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_rol"]),
                        Convert.ToInt32(row["id_persona"]),
                        row["nickname"].ToString() ?? "",
                        row["contrasena"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    );

                    // Obtener datos relacionados
                    usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                    usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                    usuarios.Add(usuario);
                }

                _logger.Info($"Se encontraron {usuarios.Count} usuarios con el nickname '{nicknameBusqueda}'");
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al buscar usuarios con el nickname '{nicknameBusqueda}'");
                return usuarios; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Verifica si un nickname ya existe en la base de datos
        /// </summary>
        /// <param name="nickname">Nickname a verificar</param>
        /// <param name="idUsuarioExcluir">ID de usuario a excluir (para actualizaciones)</param>
        /// <returns>True si existe, False si no existe</returns>
        public bool ExisteNickname(string nickname, int idUsuarioExcluir = 0)
        {
            try
            {
                string query = @"SELECT COUNT(*) 
                                FROM Usuarios 
                                WHERE nickname = @Nickname";

                if (idUsuarioExcluir > 0)
                {
                    query += " AND id_usuario != @IdUsuario";
                }

                NpgsqlParameter paramNickname = _dbAccess.CreateParameter("@Nickname", nickname);
                NpgsqlParameter paramIdUsuario = _dbAccess.CreateParameter("@IdUsuario", idUsuarioExcluir);

                _dbAccess.Connect();

                object? resultado;
                if (idUsuarioExcluir > 0)
                {
                    resultado = _dbAccess.ExecuteScalar(query, paramNickname, paramIdUsuario);
                }
                else
                {
                    resultado = _dbAccess.ExecuteScalar(query, paramNickname);
                }

                int count = Convert.ToInt32(resultado);
                return count > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar la existencia del nickname: {nickname}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Autentica un usuario por su nickname y contraseña
        /// </summary>
        /// <param name="nickname">Nickname del usuario</param>
        /// <param name="contrasena">Contraseña del usuario</param>
        /// <returns>Objeto Usuario si la autenticación es exitosa, null si falla</returns>
        public Usuario? AutenticarUsuario(string nickname, string contrasena)
        {
            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE nickname = @Nickname 
                               AND contrasena = @Contrasena 
                               AND estatus = 1";

                // Crea los parámetros
                NpgsqlParameter paramNickname = _dbAccess.CreateParameter("@Nickname", nickname);
                NpgsqlParameter paramContrasena = _dbAccess.CreateParameter("@Contrasena", contrasena);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramNickname, paramContrasena);

                if (resultado.Rows.Count == 0)
                {
                    _logger.Warn($"Autenticación fallida para el usuario {nickname}");
                    return null;
                }

                // Obtiene la primera fila (debería ser la única)
                DataRow row = resultado.Rows[0];

                // Crear y devolver el objeto Usuario
                Usuario usuario = new Usuario(
                    Convert.ToInt32(row["id_usuario"]),
                    Convert.ToInt32(row["id_rol"]),
                    Convert.ToInt32(row["id_persona"]),
                    row["nickname"].ToString() ?? "",
                    row["contrasena"].ToString() ?? "",
                    Convert.ToInt32(row["estatus"])
                );

                // Obtener datos relacionados
                usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                _logger.Info($"Usuario {nickname} autenticado correctamente");
                return usuario;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al autenticar al usuario {nickname}");
                return null;
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios asociados a una persona específica
        /// </summary>
        /// <param name="idPersona">ID de la persona</param>
        /// <returns>Lista de usuarios asociados a la persona</returns>
        public List<Usuario> ObtenerUsuariosPorPersona(int idPersona)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE id_persona = @IdPersona
                               ORDER BY nickname";

                // Crea el parámetro
                NpgsqlParameter paramIdPersona = _dbAccess.CreateParameter("@IdPersona", idPersona);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramIdPersona);

                // Procesa los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_rol"]),
                        Convert.ToInt32(row["id_persona"]),
                        row["nickname"].ToString() ?? "",
                        row["contrasena"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    );

                    // Obtener datos relacionados
                    usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                    usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                    usuarios.Add(usuario);
                }

                _logger.Info($"Se obtuvieron {usuarios.Count} usuarios para la persona con ID {idPersona}");
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener usuarios para la persona con ID {idPersona}");
                return usuarios; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene todos los usuarios asociados a un rol específico
        /// </summary>
        /// <param name="idRol">ID del rol</param>
        /// <returns>Lista de usuarios asociados al rol</returns>
        public List<Usuario> ObtenerUsuariosPorRol(int idRol)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                string query = @"SELECT id_usuario, id_rol, id_persona, nickname, contrasena, estatus 
                               FROM Usuarios 
                               WHERE id_rol = @IdRol
                               ORDER BY nickname";

                // Crea el parámetro
                NpgsqlParameter paramIdRol = _dbAccess.CreateParameter("@IdRol", idRol);

                // Establece la conexión a la BD
                _dbAccess.Connect();

                // Ejecuta la consulta
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, paramIdRol);

                // Procesa los resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Usuario usuario = new Usuario(
                        Convert.ToInt32(row["id_usuario"]),
                        Convert.ToInt32(row["id_rol"]),
                        Convert.ToInt32(row["id_persona"]),
                        row["nickname"].ToString() ?? "",
                        row["contrasena"].ToString() ?? "",
                        Convert.ToInt32(row["estatus"])
                    );

                    // Obtener datos relacionados
                    usuario.Persona = _personasData.ObtenerPersonaPorId(usuario.IdPersona);
                    usuario.Rol = _rolesData.ObtenerRolPorId(usuario.IdRol);

                    usuarios.Add(usuario);
                }

                _logger.Info($"Se obtuvieron {usuarios.Count} usuarios para el rol con ID {idRol}");
                return usuarios;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener usuarios para el rol con ID {idRol}");
                return usuarios; // Retorna lista vacía en caso de error
            }
            finally
            {
                // Asegura que se cierre la conexión
                _dbAccess.Disconnect();
            }
        }
    }
}