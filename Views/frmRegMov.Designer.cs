﻿namespace InvSis.Views
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
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSeleccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoMov
            // 
            cmbTipoMov.FormattingEnabled = true;
            cmbTipoMov.Items.AddRange(new object[] { "Alta de Productos", "Baja de Productos" });
            cmbTipoMov.Location = new Point(104, 189);
            cmbTipoMov.Margin = new Padding(3, 4, 3, 4);
            cmbTipoMov.Name = "cmbTipoMov";
            cmbTipoMov.Size = new Size(138, 28);
            cmbTipoMov.TabIndex = 0;
            // 
            // lblMovi
            // 
            lblMovi.AutoSize = true;
            lblMovi.Location = new Point(104, 147);
            lblMovi.Name = "lblMovi";
            lblMovi.Size = new Size(144, 20);
            lblMovi.TabIndex = 1;
            lblMovi.Text = "Tipo de Movimiento";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(362, 189);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(228, 27);
            dtpFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(362, 147);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(156, 20);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "Fecha del Movimiento";
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Location = new Point(698, 147);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(73, 20);
            lblOp.TabIndex = 4;
            lblOp.Text = "Operador";
            // 
            // cmbOpe
            // 
            cmbOpe.FormattingEnabled = true;
            cmbOpe.Location = new Point(698, 189);
            cmbOpe.Margin = new Padding(3, 4, 3, 4);
            cmbOpe.Name = "cmbOpe";
            cmbOpe.Size = new Size(138, 28);
            cmbOpe.TabIndex = 5;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(1127, 147);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(55, 20);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus";
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Pendiente", "Aprobado", "Revisado", "Rechazado" });
            cmbEstatus.Location = new Point(1039, 189);
            cmbEstatus.Margin = new Padding(3, 4, 3, 4);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(138, 28);
            cmbEstatus.TabIndex = 7;
            // 
            // dgvSeleccion
            // 
            dgvSeleccion.AllowUserToAddRows = false;
            dgvSeleccion.AllowUserToDeleteRows = false;
            dgvSeleccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeleccion.Columns.AddRange(new DataGridViewColumn[] { producto, cantidad, eliminar });
            dgvSeleccion.Location = new Point(506, 516);
            dgvSeleccion.Margin = new Padding(3, 4, 3, 4);
            dgvSeleccion.Name = "dgvSeleccion";
            dgvSeleccion.ReadOnly = true;
            dgvSeleccion.RowHeadersWidth = 51;
            dgvSeleccion.Size = new Size(393, 200);
            dgvSeleccion.TabIndex = 8;
            dgvSeleccion.CellContentClick += dgvSeleccion_CellContentClick;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 6;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 125;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "Eliminar";
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            eliminar.ReadOnly = true;
            eliminar.Width = 125;
            // 
            // cmbProd
            // 
            cmbProd.FormattingEnabled = true;
            cmbProd.Location = new Point(698, 416);
            cmbProd.Margin = new Padding(3, 4, 3, 4);
            cmbProd.Name = "cmbProd";
            cmbProd.Size = new Size(187, 28);
            cmbProd.TabIndex = 9;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(1121, 416);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(56, 27);
            nudCantidad.TabIndex = 10;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Location = new Point(698, 331);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(152, 20);
            lblProd.TabIndex = 11;
            lblProd.Text = "Seleccionar Producto:";
            // 
            // btnAgregarP
            // 
            btnAgregarP.Location = new Point(1017, 516);
            btnAgregarP.Margin = new Padding(3, 4, 3, 4);
            btnAgregarP.Name = "btnAgregarP";
            btnAgregarP.Size = new Size(160, 31);
            btnAgregarP.TabIndex = 12;
            btnAgregarP.Text = "Agregar Producto";
            btnAgregarP.UseVisualStyleBackColor = true;
            btnAgregarP.Click += btnAgregarP_Click;
            // 
            // lblCan
            // 
            lblCan.AutoSize = true;
            lblCan.Location = new Point(1114, 349);
            lblCan.Name = "lblCan";
            lblCan.Size = new Size(69, 20);
            lblCan.TabIndex = 13;
            lblCan.Text = "Cantidad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(481, 780);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Movimiento";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(834, 780);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.InactiveCaption;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1426, 49);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Registrar Movimientos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegMov
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 873);
            Controls.Add(lblTitulo);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblTitulo;
    }
}