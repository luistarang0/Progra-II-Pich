

using System.Reflection.Metadata.Ecma335;

namespace InvSis
{
    public partial class frmAdminProd : Form
    {


        public frmAdminProd()
        {
            InitializeComponent();

        }

        private void btnEdittemp_Click(object sender, EventArgs e)
        {
            frmEditarAgregarProducto editarProducto = new frmEditarAgregarProducto();
            editarProducto.ShowDialog();

        }

        private void btnCrg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos Excel (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditarAgregarProducto editarProducto = new frmEditarAgregarProducto();
            //editarProducto.txtClave.ReadOnly(false);
            editarProducto.ShowDialog();
        }
    }
}
