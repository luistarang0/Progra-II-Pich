namespace InvSis.Views
{
    partial class frmRepInv
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
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            cmbCat = new ComboBox();
            cmbMov = new ComboBox();
            lblFecIni = new Label();
            lblFecFin = new Label();
            lblCat = new Label();
            lblMov = new Label();
            btnApF = new Button();
            dgvProductos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colImpuesto = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(109, 27);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 0;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(481, 27);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 1;
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            // 
            // cmbCat
            // 
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Location = new Point(109, 83);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(200, 23);
            cmbCat.TabIndex = 2;
            // 
            // cmbMov
            // 
            cmbMov.FormattingEnabled = true;
            cmbMov.Items.AddRange(new object[] { "Todo", "Mov A", "Mov B", "Mov C" });
            cmbMov.Location = new Point(481, 83);
            cmbMov.Name = "cmbMov";
            cmbMov.Size = new Size(200, 23);
            cmbMov.TabIndex = 3;
            // 
            // lblFecIni
            // 
            lblFecIni.AutoSize = true;
            lblFecIni.Location = new Point(181, 9);
            lblFecIni.Name = "lblFecIni";
            lblFecIni.Size = new Size(72, 15);
            lblFecIni.TabIndex = 5;
            lblFecIni.Text = "Fecha Inicial";
            // 
            // lblFecFin
            // 
            lblFecFin.AutoSize = true;
            lblFecFin.Location = new Point(561, 9);
            lblFecFin.Name = "lblFecFin";
            lblFecFin.Size = new Size(66, 15);
            lblFecFin.TabIndex = 6;
            lblFecFin.Text = "Fecha Final";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(181, 65);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(58, 15);
            lblCat.TabIndex = 7;
            lblCat.Text = "Categoría";
            // 
            // lblMov
            // 
            lblMov.AutoSize = true;
            lblMov.Location = new Point(555, 65);
            lblMov.Name = "lblMov";
            lblMov.Size = new Size(72, 15);
            lblMov.TabIndex = 8;
            lblMov.Text = "Movimiento";
            // 
            // btnApF
            // 
            btnApF.Location = new Point(335, 127);
            btnApF.Name = "btnApF";
            btnApF.Size = new Size(126, 23);
            btnApF.TabIndex = 9;
            btnApF.Text = "Aplicar Filtros";
            btnApF.UseVisualStyleBackColor = true;
            btnApF.Click += btnApF_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = SystemColors.ButtonFace;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCosto, colCategoria, colStock, colUbicacion, colImpuesto, colEstatus });
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(12, 156);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(797, 300);
            dgvProductos.TabIndex = 10;
            // 
            // colClave
            // 
            colClave.HeaderText = "Clave";
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo";
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colUbicacion
            // 
            colUbicacion.HeaderText = "Ubicación";
            colUbicacion.Name = "colUbicacion";
            colUbicacion.ReadOnly = true;
            // 
            // colImpuesto
            // 
            colImpuesto.HeaderText = "Impuestos";
            colImpuesto.Name = "colImpuesto";
            colImpuesto.ReadOnly = true;
            // 
            // colEstatus
            // 
            colEstatus.HeaderText = "Estatus";
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            // 
            // frmRepInv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 468);
            Controls.Add(dgvProductos);
            Controls.Add(btnApF);
            Controls.Add(lblMov);
            Controls.Add(lblCat);
            Controls.Add(lblFecFin);
            Controls.Add(lblFecIni);
            Controls.Add(cmbMov);
            Controls.Add(cmbCat);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Name = "frmRepInv";
            Text = "frmRepInv";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private ComboBox cmbCat;
        private ComboBox cmbMov;
        private Label lblFecIni;
        private Label lblFecFin;
        private Label lblCat;
        private Label lblMov;
        private Button btnApF;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colUbicacion;
        private DataGridViewTextBoxColumn colImpuesto;
        private DataGridViewTextBoxColumn colEstatus;
    }
}