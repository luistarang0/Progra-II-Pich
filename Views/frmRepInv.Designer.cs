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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            dgvProductos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colImpuesto = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            lblFecIni = new Label();
            lblFecFin = new Label();
            cmbCat = new ComboBox();
            cmbMov = new ComboBox();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            lblCat = new Label();
            lblMov = new Label();
            btnApF = new Button();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(159, 122, 234);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1399, 60);
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
            lblTitulo.Size = new Size(1399, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REPORTE DE INVENTARIO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCosto, colCategoria, colStock, colUbicacion, colImpuesto, colEstatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.MediumPurple;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.GridColor = Color.FromArgb(224, 224, 224);
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(206, 208);
            dgvProductos.Margin = new Padding(4, 5, 4, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(1040, 506);
            dgvProductos.TabIndex = 10;
            // 
            // colClave
            // 
            colClave.HeaderText = "Clave";
            colClave.MinimumWidth = 8;
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 150;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 150;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo";
            colCosto.MinimumWidth = 8;
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            colCosto.Width = 150;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 8;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 150;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 150;
            // 
            // colUbicacion
            // 
            colUbicacion.HeaderText = "Ubicación";
            colUbicacion.MinimumWidth = 8;
            colUbicacion.Name = "colUbicacion";
            colUbicacion.ReadOnly = true;
            colUbicacion.Width = 150;
            // 
            // colImpuesto
            // 
            colImpuesto.HeaderText = "Impuestos";
            colImpuesto.MinimumWidth = 8;
            colImpuesto.Name = "colImpuesto";
            colImpuesto.ReadOnly = true;
            colImpuesto.Width = 150;
            // 
            // colEstatus
            // 
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 8;
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            colEstatus.Width = 150;
            // 
            // lblFecIni
            // 
            lblFecIni.AutoSize = true;
            lblFecIni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFecIni.ForeColor = Color.FromArgb(64, 64, 64);
            lblFecIni.Location = new Point(247, 25);
            lblFecIni.Margin = new Padding(4, 0, 4, 0);
            lblFecIni.Name = "lblFecIni";
            lblFecIni.Size = new Size(122, 28);
            lblFecIni.TabIndex = 5;
            lblFecIni.Text = "Fecha Inicial";
            // 
            // lblFecFin
            // 
            lblFecFin.AutoSize = true;
            lblFecFin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFecFin.ForeColor = Color.FromArgb(64, 64, 64);
            lblFecFin.Location = new Point(1026, 25);
            lblFecFin.Margin = new Padding(4, 0, 4, 0);
            lblFecFin.Name = "lblFecFin";
            lblFecFin.Size = new Size(112, 28);
            lblFecFin.TabIndex = 6;
            lblFecFin.Text = "Fecha Final";
            // 
            // cmbCat
            // 
            cmbCat.BackColor = Color.WhiteSmoke;
            cmbCat.FlatStyle = FlatStyle.Flat;
            cmbCat.Font = new Font("Segoe UI", 10F);
            cmbCat.ForeColor = Color.DimGray;
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Location = new Point(226, 135);
            cmbCat.Margin = new Padding(4, 5, 4, 5);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(284, 36);
            cmbCat.TabIndex = 2;
            // 
            // cmbMov
            // 
            cmbMov.BackColor = Color.WhiteSmoke;
            cmbMov.FlatStyle = FlatStyle.Flat;
            cmbMov.Font = new Font("Segoe UI", 10F);
            cmbMov.ForeColor = Color.DimGray;
            cmbMov.FormattingEnabled = true;
            cmbMov.Items.AddRange(new object[] { "Todo", "Mov A", "Mov B", "Mov C" });
            cmbMov.Location = new Point(943, 160);
            cmbMov.Margin = new Padding(4, 5, 4, 5);
            cmbMov.Name = "cmbMov";
            cmbMov.Size = new Size(284, 36);
            cmbMov.TabIndex = 3;
            // 
            // dtpInicio
            // 
            dtpInicio.BackColor = Color.WhiteSmoke;
            dtpInicio.Font = new Font("Segoe UI", 9F);
            dtpInicio.ForeColor = Color.DimGray;
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(226, 68);
            dtpInicio.Margin = new Padding(4, 5, 4, 5);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(284, 31);
            dtpInicio.TabIndex = 0;
            // 
            // dtpFin
            // 
            dtpFin.BackColor = Color.WhiteSmoke;
            dtpFin.Font = new Font("Segoe UI", 9F);
            dtpFin.ForeColor = Color.DimGray;
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(962, 68);
            dtpFin.Margin = new Padding(4, 5, 4, 5);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(284, 31);
            dtpFin.TabIndex = 1;
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.ForeColor = Color.FromArgb(159, 122, 234);
            lblCat.Location = new Point(302, 105);
            lblCat.Margin = new Padding(4, 0, 4, 0);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(88, 25);
            lblCat.TabIndex = 7;
            lblCat.Text = "Categoría";
            // 
            // lblMov
            // 
            lblMov.AutoSize = true;
            lblMov.ForeColor = Color.FromArgb(159, 122, 234);
            lblMov.Location = new Point(1030, 118);
            lblMov.Margin = new Padding(4, 0, 4, 0);
            lblMov.Name = "lblMov";
            lblMov.Size = new Size(108, 25);
            lblMov.TabIndex = 8;
            lblMov.Text = "Movimiento";
            // 
            // btnApF
            // 
            btnApF.BackColor = Color.FromArgb(159, 122, 234);
            btnApF.ForeColor = Color.White;
            btnApF.Location = new Point(599, 160);
            btnApF.Margin = new Padding(4, 5, 4, 5);
            btnApF.Name = "btnApF";
            btnApF.Size = new Size(180, 38);
            btnApF.TabIndex = 9;
            btnApF.Text = "Aplicar Filtro";
            btnApF.UseVisualStyleBackColor = false;
            btnApF.Click += btnApF_Click;
            // 
            // frmRepInv
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 687);
            BackColor = ColorTranslator.FromHtml("#E6F2F8");
            Controls.Add(pnlTitulo);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmRepInv";
            Text = "frmRepInv";
            pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
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