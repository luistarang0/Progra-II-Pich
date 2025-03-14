using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvSis.Views
{
    public partial class frmMDI : Form
    {
        private Dictionary<string, Form> openForms = new Dictionary<string, Form>();
        public frmMDI()
        {
            InitializeComponent();
        }

        private void btnRepAud_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmVReportesAuditoria");
        }
        private void btnAdmProd_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmAdminProd");
        }

        private void btnGesRoles_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmGestionRolesPermisos");
        }

        private void btnAdmUsr_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmUsuarios");
        }

        private void btnAPI_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRepAPI");
        }

        private void btnRegMov_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRegMov");
        }

        private void btnRepInv_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRepInv");
        }

        private void OpenFormInPanel(string formName)
        {
            Form formToShow;

            // Verificar si la ventana ya existe
            if (openForms.ContainsKey(formName))
            {
                // Obtener la referencia al formulario existente
                formToShow = openForms[formName];

                // Traer la ventana al frente
                formToShow.BringToFront();
            }
            else
            {
                // Crear una nueva instancia de la ventana según el nombre
                formToShow = CrearForma(formName);

                if (formToShow == null)
                {
                    return;
                }

                // Configurar propiedades de la ventana
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agregar la ventana al panel 2
                splitMDI.Panel2.Controls.Add(formToShow);

                // Agregar la ventana al diccionario
                openForms.Add(formName, formToShow);

                // Mostrar la ventana
                formToShow.Show();
                formToShow.BringToFront();
            }
        }

        private Form CrearForma(string formName)
        {
            switch (formName)
            {
                case "frmAdminProd":
                    return new frmAdminProd();
                case "frmGestionRolesPermisos":
                    return new frmGestionRolesPermisos();
                case "frmVReportesAuditoria":
                    return new frmVReportesAuditoria();
                case "frmUsuarios":
                    return new frmUsuarios();
                case "frmRepAPI":
                    return new frmRepAPI();
                case "frmRegMov":
                    return new frmRegMov();
                case "frmRepInv":
                    return new frmRepInv();
                default:
                    MessageBox.Show($"No se reconoce el formulario: {formName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Form form in openForms.Values)
            {
                form.Close();
                form.Dispose();
            }
            openForms.Clear();
        }

        
    }
}
