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
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
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
            dgvProductos.Location = new Point(132, 136);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.Size = new Size(1003, 262);
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
            btnEdittemp.Location = new Point(836, 78);
            btnEdittemp.Name = "btnEdittemp";
            btnEdittemp.Size = new Size(75, 23);
            btnEdittemp.TabIndex = 1;
            btnEdittemp.Text = "Editar";
            btnEdittemp.UseVisualStyleBackColor = true;
            btnEdittemp.Click += btnEdittemp_Click;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(215, 440);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(75, 23);
            btnCarga.TabIndex = 2;
            btnCarga.Text = "Carga Excel";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCrg_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(564, 440);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // frmAdminProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 508);
            Controls.Add(btnAgregar);
            Controls.Add(btnCarga);
            Controls.Add(btnEdittemp);
            Controls.Add(dgvProductos);
            Name = "frmAdminProd";
            Text = "Administración de Inventarios";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
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
        private Button btnAgregar;
    }
}
