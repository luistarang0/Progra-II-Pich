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
    public partial class frmMDI: Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void btnRepAud_Click(object sender, EventArgs e)
        {
            frmVReportesAuditoria frm = new frmVReportesAuditoria();
            frm.Show();
        }
        private void btnAdmProd_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmAdminProd");
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
                //case "FormProductos":
                //    return new FormProductos();
                //case "FormVentas":
                //    return new FormVentas();
                //case "FormReportes":
                //    return new FormReportes();
                // Agregar casos para todos tus formularios
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
