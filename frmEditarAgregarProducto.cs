using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvSis
{
    public partial class frmEditarAgregarProducto : Form
    {

        public frmEditarAgregarProducto()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                MessageBox.Show("El costo debe ser un número válido.");
                txtCosto.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus(); // Enfocar el campo inválido.
                return; // Detener la ejecución.
            }

            if (string.IsNullOrEmpty(cmbxCat.Text))
            {
                MessageBox.Show("El campo 'Categoría' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbxCat.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCosto.Text))
            {
                MessageBox.Show("El campo 'Costo' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCosto.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cmbxUbi.Text))
            {
                MessageBox.Show("El campo 'Ubicación' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbxUbi.Focus();
                return;
            }


            // Si todos los campos están llenos y son válidos, proceder a guardar los datos.

        }
    }
}
