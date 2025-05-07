namespace InvSis.Views
{
    partial class frmRepAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            ID_Producto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            estatus = new DataGridViewTextBoxColumn();
            Impuesto = new DataGridViewTextBoxColumn();
            txtBusNom = new TextBox();
            lblBus = new Label();
            txtBusID = new TextBox();
            lblID = new Label();
            lblNom = new Label();
            btnEnviar = new Button();
            btnBuscar = new Button();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            ForeColor = ColorTranslator.FromHtml("#9F7AEA");
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ID_Producto, nombre, Stock, estatus, Impuesto });
            dgvProductos.Location = new Point(151, 157);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(777, 751);
            dgvProductos.TabIndex = 0;
            // 
            // ID_Producto
            // 
            ID_Producto.HeaderText = "ID Producto";
            ID_Producto.MinimumWidth = 8;
            ID_Producto.Name = "ID_Producto";
            ID_Producto.ReadOnly = true;
            ID_Producto.Width = 150;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 8;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 150;
            // 
            // estatus
            // 
            estatus.HeaderText = "Estatus";
            estatus.MinimumWidth = 8;
            estatus.Name = "estatus";
            estatus.ReadOnly = true;
            estatus.Width = 150;
            // 
            // Impuesto
            // 
            Impuesto.HeaderText = "Impuesto";
            Impuesto.MinimumWidth = 8;
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            Impuesto.Width = 150;
            // 
            // txtBusNom
            // 
            txtBusNom.Location = new Point(963, 221);
            txtBusNom.Margin = new Padding(4, 5, 4, 5);
            txtBusNom.Name = "txtBusNom";
            txtBusNom.Size = new Size(200, 31);
            txtBusNom.TabIndex = 1;
            // 
            // lblBus
            // 
            lblBus.AutoSize = true;
            lblBus.Location = new Point(260, 112);
            lblBus.Margin = new Padding(4, 0, 4, 0);
            lblBus.Name = "lblBus";
            lblBus.Size = new Size(145, 25);
            lblBus.TabIndex = 2;
            lblBus.Text = "Buscar Producto:";
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(963, 119);
            txtBusID.Margin = new Padding(4, 5, 4, 5);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(200, 31);
            txtBusID.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(1039, 89);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(61, 25);
            lblID.TabIndex = 4;
            lblID.Text = "Por ID";
            lblID.Click += label1_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(1022, 174);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(109, 25);
            lblNom.TabIndex = 5;
            lblNom.Text = "Por Nombre";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(1022, 488);
            btnEnviar.Margin = new Padding(4, 5, 4, 5);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(297, 38);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar Reporte Manualmente";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1194, 174);
            btnBuscar.Margin = new Padding(4, 5, 4, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 38);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
           
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(159, 122, 234);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1529, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 10, 0, 0);
            lblTitulo.Size = new Size(1529, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "API";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRepAPI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1529, 915);
            Controls.Add(pnlTitulo);
            Controls.Add(btnBuscar);
            Controls.Add(btnEnviar);
            Controls.Add(lblNom);
            Controls.Add(lblID);
            Controls.Add(txtBusID);
            Controls.Add(lblBus);
            Controls.Add(txtBusNom);
            Controls.Add(dgvProductos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRepAPI";
            Text = "frmRepAPI";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn ID_Producto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn estatus;
        private DataGridViewTextBoxColumn Impuesto;
        private TextBox txtBusNom;
        private Label lblBus;
        private TextBox txtBusID;
        private Label lblID;
        private Label lblNom;
        private Button btnEnviar;
        private Button btnBuscar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}