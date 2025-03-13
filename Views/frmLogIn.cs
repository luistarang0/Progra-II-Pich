using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InvSis.Business;
using InvSis.Views;

namespace InvSis.Views
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validaciones 

            // Validar que el campo usuario no este vacio
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo de usuario no puede de estar vacio. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el campo contraseña no este vacio
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("El campo de contraseña no puede de estar vacio. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el campo usuario tenga un formato correcto
            if (!UsuarioNegocio.EsFormatoValido(txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario no tiene un formato correcto. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Ha iniciado sesion. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cierra el forms actual
            this.Hide();

            //abre el forms MDI
            frmMDI mdi = new frmMDI();
            mdi.Show();

            #region Solucion a los comentarios
            this.DialogResult = DialogResult.OK;
            this.Close();
            #endregion
        }
    }
}
