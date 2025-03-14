namespace InvSis.Views
{
    partial class frmRegMov
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
            cmbTipoMov = new ComboBox();
            lblMovi = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            lblOp = new Label();
            cmbOpe = new ComboBox();
            lblEstatus = new Label();
            cmbEstatus = new ComboBox();
            dgvSeleccion = new DataGridView();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewButtonColumn();
            cmbProd = new ComboBox();
            nudCantidad = new NumericUpDown();
            lblProd = new Label();
            btnAgregarP = new Button();
            lblCan = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoMov
            // 
            cmbTipoMov.FormattingEnabled = true;
            cmbTipoMov.Items.AddRange(new object[] { "Alta de Productos", "Baja de Productos" });
            cmbTipoMov.Location = new Point(85, 72);
            cmbTipoMov.Name = "cmbTipoMov";
            cmbTipoMov.Size = new Size(121, 23);
            cmbTipoMov.TabIndex = 0;
            // 
            // lblMovi
            // 
            lblMovi.AutoSize = true;
            lblMovi.Location = new Point(91, 30);
            lblMovi.Name = "lblMovi";
            lblMovi.Size = new Size(115, 15);
            lblMovi.TabIndex = 1;
            lblMovi.Text = "Tipo de Movimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(306, 72);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(345, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(125, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha del Movimiento";
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Location = new Point(649, 30);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(57, 15);
            lblOp.TabIndex = 4;
            lblOp.Text = "Operador";
            // 
            // cmbOpe
            // 
            cmbOpe.FormattingEnabled = true;
            cmbOpe.Location = new Point(611, 72);
            cmbOpe.Name = "cmbOpe";
            cmbOpe.Size = new Size(121, 23);
            cmbOpe.TabIndex = 5;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(123, 142);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(44, 15);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus";
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Pendiente", "Aprovado", "Revisado", "Rechazado" });
            cmbEstatus.Location = new Point(85, 178);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(121, 23);
            cmbEstatus.TabIndex = 7;
            // 
            // dgvSeleccion
            // 
            dgvSeleccion.AllowUserToAddRows = false;
            dgvSeleccion.AllowUserToDeleteRows = false;
            dgvSeleccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeleccion.Columns.AddRange(new DataGridViewColumn[] { producto, cantidad, eliminar });
            dgvSeleccion.Location = new Point(185, 261);
            dgvSeleccion.Name = "dgvSeleccion";
            dgvSeleccion.ReadOnly = true;
            dgvSeleccion.Size = new Size(332, 150);
            dgvSeleccion.TabIndex = 8;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            producto.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.Name = "eliminar";
            eliminar.ReadOnly = true;
            // 
            // cmbProd
            // 
            cmbProd.FormattingEnabled = true;
            cmbProd.Location = new Point(306, 178);
            cmbProd.Name = "cmbProd";
            cmbProd.Size = new Size(164, 23);
            cmbProd.TabIndex = 9;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(611, 178);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(49, 23);
            nudCantidad.TabIndex = 10;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Location = new Point(325, 142);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(116, 15);
            lblProd.TabIndex = 11;
            lblProd.Text = "Sleccionar Producto:";
            // 
            // btnAgregarP
            // 
            btnAgregarP.Location = new Point(481, 207);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(140, 23);
            btnAgregarP.TabIndex = 12;
            btnAgregarP.Text = "Agregar Producto";
            btnAgregarP.UseVisualStyleBackColor = true;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(611, 142);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(55, 15);
            lblCan.TabIndex = 13;
            lblCan.Text = "Cantidad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(463, 417);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Movimiento";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(682, 417);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmRegMov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblCan);
            Controls.Add(btnAgregarP);
            Controls.Add(lblProd);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProd);
            Controls.Add(dgvSeleccion);
            Controls.Add(cmbEstatus);
            Controls.Add(lblEstatus);
            Controls.Add(cmbOpe);
            Controls.Add(lblOp);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblMovi);
            Controls.Add(cmbTipoMov);
            Name = "frmRegMov";
            Text = "frmRegMov";
            ((System.ComponentModel.ISupportInitialize)dgvSeleccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoMov;
        private Label lblMovi;
        private DateTimePicker dtpFecha;
        private Label lblFecha;
        private Label lblOp;
        private ComboBox cmbOpe;
        private Label lblEstatus;
        private ComboBox cmbEstatus;
        private DataGridView dgvSeleccion;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private ComboBox cmbProd;
        private NumericUpDown nudCantidad;
        private Label lblProd;
        private Button btnAgregarP;
        private Label lblCan;
        private DataGridViewButtonColumn eliminar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}