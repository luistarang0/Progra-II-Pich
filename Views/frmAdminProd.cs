namespace InvSis
{
    public partial class frmAdminProd : Form
    {


        public frmAdminProd()
        {
            InitializeComponent();
            spcProductos.Panel2Collapsed = true;

        }

        private void btnEdittemp_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = false;
            txtClave.ReadOnly = true;
            spcProductos.Panel1.Enabled = false;
            //frmEditarAgregarProducto editarProducto = new frmEditarAgregarProducto();
            //editarProducto.ShowDialog();

        }

        private void btnCrg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Tag = "Selecciona el archivo";
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos Excel (*.xls)|*.xls|Archivos Excel (*.xlsx)|*.xlsx";
            openFileDialog.ReadOnlyChecked = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".xls" || extension == ".xlsx" || extension == ".csv")
                {
                    //Cargar el archivo
                    MessageBox.Show("Archivo valido " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Archivo INVALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = true;

            spcProductos.Panel1.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = false;
            txtClave.ReadOnly = false;
            spcProductos.Panel1.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = true;

            spcProductos.Panel1.Enabled = true;
        }
    }
}
