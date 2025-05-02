using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvSis.Controller;
using InvSis.Model;

namespace InvSis.Views
{
    public partial class frmGestrionPermisos : Form
    {
        private Permiso? permisoActual = null;
        private PermisosController _permisosController;

        public frmGestrionPermisos()
        {
            InitializeComponent();
            _permisosController = new PermisosController(); // o PermisosController si tienes uno separado
            CargarComboEstatus();
            EstablecerCamposActivos(false);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePermiso.Text.Trim();
            string descripcion = txtDescripcionPermiso.Text.Trim();
            int estatus = (int)cbxEstatus.SelectedValue;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (permisoActual == null)
            {
                // Agregar nuevo permiso
                Permiso nuevo = new Permiso
                {
                    Descripcion = nombre,
                    Estatus = estatus
                };

                bool exito = _permisosController.GuardarPermiso(nuevo);

                if (exito)
                {
                    MessageBox.Show("Permiso agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposPermiso();
                }
                else
                {
                    MessageBox.Show("Error al agregar el permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Editar permiso existente
                permisoActual.Descripcion = descripcion;
                permisoActual.Estatus = estatus;

                bool exito = _permisosController.GuardarPermiso(permisoActual);

                if (exito)
                {
                    MessageBox.Show("Permiso actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposPermiso();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarComboEstatus()
        {
            var estatus = new Dictionary<int, string>
            {
                { 1, "Activo" },
                { 2, "Inactivo" }
            };

            cbxEstatus.DataSource = new BindingSource(estatus, null);
            cbxEstatus.DisplayMember = "Value";
            cbxEstatus.ValueMember = "Key";
        }

        private void EstablecerCamposActivos(bool activos)
        {
            txtDescripcionPermiso.Enabled = activos;
            cbxEstatus.Enabled = activos;
            btnAgregar.Enabled = activos;
        }

        private void txtNombrePermiso_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombrePermiso.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                EstablecerCamposActivos(false);
                txtDescripcionPermiso.Clear();
                cbxEstatus.SelectedIndex = 0;
                btnAgregar.Text = "Agregar";
                permisoActual = null;
                return;
            }

            // Verificamos si ya existe
            if (_permisosController.ExistePermiso(nombre))
            {
                permisoActual = _permisosController.ObtenerPermisoPorDescripcion(nombre); // Este método deberías tenerlo
                if (permisoActual != null)
                {
                    txtDescripcionPermiso.Text = permisoActual.Descripcion;
                    cbxEstatus.SelectedValue = permisoActual.Estatus;
                    EstablecerCamposActivos(true);
                    btnAgregar.Text = "Editar";
                }
            }
            else
            {
                permisoActual = null;
                txtDescripcionPermiso.Clear();
                cbxEstatus.SelectedIndex = 0;
                EstablecerCamposActivos(true);
                btnAgregar.Text = "Agregar";
            }
        }

        private void LimpiarCamposPermiso()
        {
            txtNombrePermiso.Clear();
            txtDescripcionPermiso.Clear();
            cbxEstatus.SelectedIndex = 0;
            EstablecerCamposActivos(false);
            btnAgregar.Text = "Agregar";
            permisoActual = null;
        }


    }
}
