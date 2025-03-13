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
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ID_Producto, nombre, Stock, estatus, Impuesto });
            dgvProductos.Location = new Point(131, 170);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(544, 150);
            dgvProductos.TabIndex = 0;
            // 
            // ID_Producto
            // 
            ID_Producto.HeaderText = "ID Producto";
            ID_Producto.Name = "ID_Producto";
            ID_Producto.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // estatus
            // 
            estatus.HeaderText = "Estatus";
            estatus.Name = "estatus";
            estatus.ReadOnly = true;
            // 
            // Impuesto
            // 
            Impuesto.HeaderText = "Impuesto";
            Impuesto.Name = "Impuesto";
            Impuesto.ReadOnly = true;
            // 
            // txtBusNom
            // 
            txtBusNom.Location = new Point(416, 120);
            txtBusNom.Name = "txtBusNom";
            txtBusNom.Size = new Size(141, 23);
            txtBusNom.TabIndex = 1;
            // 
            // lblBus
            // 
            lblBus.AutoSize = true;
            lblBus.Location = new Point(182, 67);
            lblBus.Name = "lblBus";
            lblBus.Size = new Size(97, 15);
            lblBus.TabIndex = 2;
            lblBus.Text = "Buscar Producto:";
            // 
            // txtBusID
            // 
            txtBusID.Location = new Point(416, 59);
            txtBusID.Name = "txtBusID";
            txtBusID.Size = new Size(141, 23);
            txtBusID.TabIndex = 3;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(429, 30);
            lblID.Name = "lblID";
            lblID.Size = new Size(39, 15);
            lblID.TabIndex = 4;
            lblID.Text = "Por ID";
            lblID.Click += label1_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(429, 102);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(72, 15);
            lblNom.TabIndex = 5;
            lblNom.Text = "Por Nombre";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(296, 377);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(208, 23);
            btnEnviar.TabIndex = 6;
            btnEnviar.Text = "Enviar Reporte Manualmente";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(592, 120);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmRepAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(btnEnviar);
            Controls.Add(lblNom);
            Controls.Add(lblID);
            Controls.Add(txtBusID);
            Controls.Add(lblBus);
            Controls.Add(txtBusNom);
            Controls.Add(dgvProductos);
            Name = "frmRepAPI";
            Text = "frmRepAPI";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
    }
}