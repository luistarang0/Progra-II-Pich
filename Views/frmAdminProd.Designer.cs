namespace InvSis
{
    partial class frmAdminProd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnEdittemp = new Button();
            btnCarga = new Button();
            spcProductos = new SplitContainer();
            groupBox1 = new GroupBox();
            lblFilCat = new Label();
            lblFilStatus = new Label();
            cmbCat = new ComboBox();
            btnDetalle = new Button();
            btnApF = new Button();
            cmbEstatus = new ComboBox();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbxImpuesto = new ComboBox();
            cmbxStatus = new ComboBox();
            nmupdnStock = new NumericUpDown();
            txtCosto = new TextBox();
            txtClave = new TextBox();
            cmbxUbi = new ComboBox();
            cmbxCat = new ComboBox();
            txtNombre = new TextBox();
            lblImpuesto = new Label();
            lblEstatus = new Label();
            lblClave = new Label();
            lblUbicacion = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            lblCat = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcProductos).BeginInit();
            spcProductos.Panel1.SuspendLayout();
            spcProductos.Panel2.SuspendLayout();
            spcProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).BeginInit();
            SuspendLayout();
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCategoria, colStock, colEstatus, detalle, colEdit, colDelete });
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(80, 228);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(803, 262);
            dgvProductos.TabIndex = 0;
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
            // colEstatus
            // 
            colEstatus.HeaderText = "Estatus";
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            // 
            // detalle
            // 
            detalle.HeaderText = "Detalle";
            detalle.Name = "detalle";
            detalle.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Editar";
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Editar";
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Eliminar";
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Eliminar";
            // 
            // btnEdittemp
            // 
            btnEdittemp.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnEdittemp.Location = new Point(805, 522);
            btnEdittemp.Name = "btnEdittemp";
            btnEdittemp.Size = new Size(78, 36);
            btnEdittemp.TabIndex = 1;
            btnEdittemp.Text = "Editar";
            btnEdittemp.UseVisualStyleBackColor = true;
            btnEdittemp.Click += btnEdittemp_Click;
            // 
            // btnCarga
            // 
            btnCarga.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnCarga.Location = new Point(80, 528);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(153, 36);
            btnCarga.TabIndex = 2;
            btnCarga.Text = "Carga Excel";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCrg_Click;
            // 
            // spcProductos
            // 
            spcProductos.Location = new Point(0, 40);
            spcProductos.Name = "spcProductos";
            // 
            // spcProductos.Panel1
            // 
            spcProductos.Panel1.Controls.Add(groupBox1);
            // 
            // spcProductos.Panel2
            // 
            spcProductos.Panel2.Controls.Add(groupBox2);
            spcProductos.Size = new Size(1355, 744);
            spcProductos.SplitterDistance = 973;
            spcProductos.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblFilCat);
            groupBox1.Controls.Add(lblFilStatus);
            groupBox1.Controls.Add(cmbCat);
            groupBox1.Controls.Add(btnDetalle);
            groupBox1.Controls.Add(btnApF);
            groupBox1.Controls.Add(cmbEstatus);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnEdittemp);
            groupBox1.Controls.Add(btnCarga);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(968, 741);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblFilCat
            // 
            lblFilCat.AutoSize = true;
            lblFilCat.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblFilCat.Location = new Point(397, 80);
            lblFilCat.Name = "lblFilCat";
            lblFilCat.Size = new Size(199, 19);
            lblFilCat.TabIndex = 14;
            lblFilCat.Text = "Filtrar Por Categoría";
            // 
            // lblFilStatus
            // 
            lblFilStatus.AutoSize = true;
            lblFilStatus.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblFilStatus.Location = new Point(207, 80);
            lblFilStatus.Name = "lblFilStatus";
            lblFilStatus.Size = new Size(179, 19);
            lblFilStatus.TabIndex = 13;
            lblFilStatus.Text = "Filtrar Por Estatus";
            // 
            // cmbCat
            // 
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Location = new Point(397, 115);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(200, 23);
            cmbCat.TabIndex = 12;
            // 
            // btnDetalle
            // 
            btnDetalle.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnDetalle.Location = new Point(738, 567);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(145, 56);
            btnDetalle.TabIndex = 11;
            btnDetalle.Text = "Detalle del Producto";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // btnApF
            // 
            btnApF.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnApF.Location = new Point(676, 115);
            btnApF.Name = "btnApF";
            btnApF.Size = new Size(144, 27);
            btnApF.TabIndex = 10;
            btnApF.Text = "Aplicar Filtro";
            btnApF.UseVisualStyleBackColor = true;
            btnApF.Click += btnApF_Click;
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstatus.Location = new Point(207, 115);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(121, 23);
            cmbEstatus.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnAgregar.Location = new Point(412, 522);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 48);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Productos";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(cmbxImpuesto);
            groupBox2.Controls.Add(cmbxStatus);
            groupBox2.Controls.Add(nmupdnStock);
            groupBox2.Controls.Add(txtCosto);
            groupBox2.Controls.Add(txtClave);
            groupBox2.Controls.Add(cmbxUbi);
            groupBox2.Controls.Add(cmbxCat);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblImpuesto);
            groupBox2.Controls.Add(lblEstatus);
            groupBox2.Controls.Add(lblClave);
            groupBox2.Controls.Add(lblUbicacion);
            groupBox2.Controls.Add(lblStock);
            groupBox2.Controls.Add(lblCosto);
            groupBox2.Controls.Add(lblCat);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 741);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 667);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(36, 627);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbxImpuesto
            // 
            cmbxImpuesto.FormattingEnabled = true;
            cmbxImpuesto.Items.AddRange(new object[] { "No Aplica", "Impuesto A", "Impuesto B", "Impuesto C" });
            cmbxImpuesto.Location = new Point(36, 587);
            cmbxImpuesto.Name = "cmbxImpuesto";
            cmbxImpuesto.Size = new Size(253, 23);
            cmbxImpuesto.TabIndex = 33;
            // 
            // cmbxStatus
            // 
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbxStatus.Location = new Point(36, 511);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(253, 23);
            cmbxStatus.TabIndex = 32;
            // 
            // nmupdnStock
            // 
            nmupdnStock.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmupdnStock.Location = new Point(36, 283);
            nmupdnStock.Name = "nmupdnStock";
            nmupdnStock.Size = new Size(120, 22);
            nmupdnStock.TabIndex = 31;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(36, 207);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(253, 23);
            txtCosto.TabIndex = 30;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(36, 435);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(253, 23);
            txtClave.TabIndex = 29;
            txtClave.KeyPress += txtClave_KeyPress;
            // 
            // cmbxUbi
            // 
            cmbxUbi.FormattingEnabled = true;
            cmbxUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbxUbi.Location = new Point(36, 359);
            cmbxUbi.Name = "cmbxUbi";
            cmbxUbi.Size = new Size(253, 23);
            cmbxUbi.TabIndex = 28;
            // 
            // cmbxCat
            // 
            cmbxCat.FormattingEnabled = true;
            cmbxCat.Items.AddRange(new object[] { "Cat X", "Cat Y", "Cat Z" });
            cmbxCat.Location = new Point(36, 131);
            cmbxCat.Name = "cmbxCat";
            cmbxCat.Size = new Size(253, 23);
            cmbxCat.Sorted = true;
            cmbxCat.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 26;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblImpuesto.Location = new Point(36, 551);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(96, 19);
            lblImpuesto.TabIndex = 25;
            lblImpuesto.Text = "Impuesto:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblEstatus.Location = new Point(36, 475);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(83, 19);
            lblEstatus.TabIndex = 24;
            lblEstatus.Text = "Estatus:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblClave.Location = new Point(36, 399);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(64, 19);
            lblClave.TabIndex = 23;
            lblClave.Text = "Clave:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblUbicacion.Location = new Point(36, 323);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(101, 19);
            lblUbicacion.TabIndex = 22;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblStock.Location = new Point(36, 247);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(66, 19);
            lblStock.TabIndex = 21;
            lblStock.Text = "Stock:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCosto.Location = new Point(36, 171);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(68, 19);
            lblCosto.TabIndex = 20;
            lblCosto.Text = "Costo:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCat.Location = new Point(36, 95);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(108, 19);
            lblCat.TabIndex = 19;
            lblCat.Text = "Categoria: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblNombre.Location = new Point(36, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 19);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.InactiveCaption;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1347, 37);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Administración de productos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 781);
            Controls.Add(lblTitulo);
            Controls.Add(spcProductos);
            Name = "frmAdminProd";
            Text = "Administración de Inventarios";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            spcProductos.Panel1.ResumeLayout(false);
            spcProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcProductos).EndInit();
            spcProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnEdittemp;
        private Button btnCarga;
        private SplitContainer spcProductos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbxImpuesto;
        private ComboBox cmbxStatus;
        private NumericUpDown nmupdnStock;
        private TextBox txtCosto;
        private TextBox txtClave;
        private ComboBox cmbxUbi;
        private ComboBox cmbxCat;
        private TextBox txtNombre;
        private Label lblImpuesto;
        private Label lblEstatus;
        private Label lblClave;
        private Label lblUbicacion;
        private Label lblStock;
        private Label lblCosto;
        private Label lblCat;
        private Label lblNombre;
        private Button btnAgregar;
        private Label lblTitulo;
        private ComboBox cmbEstatus;
        private Button btnApF;
        private Button btnDetalle;
        private ComboBox cmbCat;
        private Label lblFilCat;
        private Label lblFilStatus;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colEstatus;
        private DataGridViewButtonColumn detalle;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
