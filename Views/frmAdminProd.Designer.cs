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
            components = new System.ComponentModel.Container();
            dgvProductos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colUbicacion = new DataGridViewTextBoxColumn();
            colImpuesto = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnEdittemp = new Button();
            timerDeslizar = new System.Windows.Forms.Timer(components);
            btnCarga = new Button();
            spcProductos = new SplitContainer();
            groupBox1 = new GroupBox();
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
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCosto, colCategoria, colStock, colUbicacion, colImpuesto, colEstatus, colEdit, colDelete });
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(32, 111);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(801, 262);
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
            btnEdittemp.Location = new Point(698, 36);
            btnEdittemp.Name = "btnEdittemp";
            btnEdittemp.Size = new Size(75, 23);
            btnEdittemp.TabIndex = 1;
            btnEdittemp.Text = "Editar";
            btnEdittemp.UseVisualStyleBackColor = true;
            btnEdittemp.Click += btnEdittemp_Click;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(62, 438);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(75, 23);
            btnCarga.TabIndex = 2;
            btnCarga.Text = "Carga Excel";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCrg_Click;
            // 
            // spcProductos
            // 
            spcProductos.Location = new Point(0, -1);
            spcProductos.Name = "spcProductos";
            // 
            // spcProductos.Panel1
            // 
            spcProductos.Panel1.Controls.Add(groupBox1);
            // 
            // spcProductos.Panel2
            // 
            spcProductos.Panel2.Controls.Add(groupBox2);
            spcProductos.Size = new Size(1221, 510);
            spcProductos.SplitterDistance = 877;
            spcProductos.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnEdittemp);
            groupBox1.Controls.Add(btnCarga);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 507);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(512, 462);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 23);
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
            groupBox2.Size = new Size(337, 507);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(36, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(36, 435);
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
            cmbxImpuesto.Location = new Point(36, 405);
            cmbxImpuesto.Name = "cmbxImpuesto";
            cmbxImpuesto.Size = new Size(253, 23);
            cmbxImpuesto.TabIndex = 33;
            // 
            // cmbxStatus
            // 
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbxStatus.Location = new Point(36, 353);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(253, 23);
            cmbxStatus.TabIndex = 32;
            // 
            // nmupdnStock
            // 
            nmupdnStock.Location = new Point(36, 197);
            nmupdnStock.Name = "nmupdnStock";
            nmupdnStock.Size = new Size(120, 23);
            nmupdnStock.TabIndex = 31;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(36, 145);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(253, 23);
            txtCosto.TabIndex = 30;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(36, 301);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(253, 23);
            txtClave.TabIndex = 29;
            // 
            // cmbxUbi
            // 
            cmbxUbi.FormattingEnabled = true;
            cmbxUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbxUbi.Location = new Point(36, 249);
            cmbxUbi.Name = "cmbxUbi";
            cmbxUbi.Size = new Size(253, 23);
            cmbxUbi.TabIndex = 28;
            // 
            // cmbxCat
            // 
            cmbxCat.FormattingEnabled = true;
            cmbxCat.Items.AddRange(new object[] { "", "Cat X", "Cat Y", "Cat Z" });
            cmbxCat.Location = new Point(36, 93);
            cmbxCat.Name = "cmbxCat";
            cmbxCat.Size = new Size(253, 23);
            cmbxCat.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 26;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(36, 383);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(60, 15);
            lblImpuesto.TabIndex = 25;
            lblImpuesto.Text = "Impuesto:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(36, 331);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(47, 15);
            lblEstatus.TabIndex = 24;
            lblEstatus.Text = "Estatus:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(36, 279);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(39, 15);
            lblClave.TabIndex = 23;
            lblClave.Text = "Clave:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(36, 227);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 22;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(36, 175);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 21;
            lblStock.Text = "Stock:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(36, 123);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(41, 15);
            lblCosto.TabIndex = 20;
            lblCosto.Text = "Costo:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(36, 71);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(64, 15);
            lblCat.TabIndex = 19;
            lblCat.Text = "Categoria: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // frmAdminProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 508);
            Controls.Add(spcProductos);
            Name = "frmAdminProd";
            Text = "Administración de Inventarios";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            spcProductos.Panel1.ResumeLayout(false);
            spcProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcProductos).EndInit();
            spcProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colUbicacion;
        private DataGridViewTextBoxColumn colImpuesto;
        private DataGridViewTextBoxColumn colEstatus;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private Button btnEdittemp;
        private System.Windows.Forms.Timer timerDeslizar;
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
    }
}
