namespace InvSis
{
    partial class frmEditarAgregarProducto
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
            lblNombre = new Label();
            lblCat = new Label();
            lblCosto = new Label();
            lblStock = new Label();
            lblUbicacion = new Label();
            lblClave = new Label();
            lblEstatus = new Label();
            lblImpuesto = new Label();
            txtNombre = new TextBox();
            cmbxCat = new ComboBox();
            cmbxUbi = new ComboBox();
            txtClave = new TextBox();
            txtCosto = new TextBox();
            nmupdnStock = new NumericUpDown();
            cmbxStatus = new ComboBox();
            cmbxImpuesto = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(26, 80);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(64, 15);
            lblCat.TabIndex = 1;
            lblCat.Text = "Categoria: ";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(26, 136);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(41, 15);
            lblCosto.TabIndex = 2;
            lblCosto.Text = "Costo:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(26, 192);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(39, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(26, 248);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 4;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(26, 304);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(39, 15);
            lblClave.TabIndex = 5;
            lblClave.Text = "Clave:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Location = new Point(26, 360);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(47, 15);
            lblEstatus.TabIndex = 6;
            lblEstatus.Text = "Estatus:";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(26, 416);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(60, 15);
            lblImpuesto.TabIndex = 7;
            lblImpuesto.Text = "Impuesto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(26, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 8;
            // 
            // cmbxCat
            // 
            cmbxCat.FormattingEnabled = true;
            cmbxCat.Items.AddRange(new object[] { "", "Cat X", "Cat Y", "Cat Z" });
            cmbxCat.Location = new Point(26, 104);
            cmbxCat.Name = "cmbxCat";
            cmbxCat.Size = new Size(253, 23);
            cmbxCat.TabIndex = 9;
            // 
            // cmbxUbi
            // 
            cmbxUbi.FormattingEnabled = true;
            cmbxUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbxUbi.Location = new Point(26, 272);
            cmbxUbi.Name = "cmbxUbi";
            cmbxUbi.Size = new Size(253, 23);
            cmbxUbi.TabIndex = 10;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(26, 328);
            txtClave.Name = "txtClave";
            txtClave.ReadOnly = true;
            txtClave.Size = new Size(253, 23);
            txtClave.TabIndex = 11;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(26, 160);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(253, 23);
            txtCosto.TabIndex = 12;
            // 
            // nmupdnStock
            // 
            nmupdnStock.Location = new Point(26, 216);
            nmupdnStock.Name = "nmupdnStock";
            nmupdnStock.Size = new Size(120, 23);
            nmupdnStock.TabIndex = 13;
            // 
            // cmbxStatus
            // 
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbxStatus.Location = new Point(26, 384);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(253, 23);
            cmbxStatus.TabIndex = 14;
            // 
            // cmbxImpuesto
            // 
            cmbxImpuesto.FormattingEnabled = true;
            cmbxImpuesto.Items.AddRange(new object[] { "No Aplica", "Impuesto A", "Impuesto B", "Impuesto C" });
            cmbxImpuesto.Location = new Point(26, 440);
            cmbxImpuesto.Name = "cmbxImpuesto";
            cmbxImpuesto.Size = new Size(253, 23);
            cmbxImpuesto.TabIndex = 15;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(14, 499);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(204, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmEditarAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 547);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbxImpuesto);
            Controls.Add(cmbxStatus);
            Controls.Add(nmupdnStock);
            Controls.Add(txtCosto);
            Controls.Add(txtClave);
            Controls.Add(cmbxUbi);
            Controls.Add(cmbxCat);
            Controls.Add(txtNombre);
            Controls.Add(lblImpuesto);
            Controls.Add(lblEstatus);
            Controls.Add(lblClave);
            Controls.Add(lblUbicacion);
            Controls.Add(lblStock);
            Controls.Add(lblCosto);
            Controls.Add(lblCat);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarAgregarProducto";
            Text = "Editar Producto";
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCat;
        private Label lblCosto;
        private Label lblStock;
        private Label lblUbicacion;
        private Label lblClave;
        private Label lblEstatus;
        private Label lblImpuesto;
        private TextBox txtNombre;
        private ComboBox cmbxCat;
        private ComboBox cmbxUbi;
        private TextBox txtClave;
        private TextBox txtCosto;
        private NumericUpDown nmupdnStock;
        private ComboBox cmbxStatus;
        private ComboBox cmbxImpuesto;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}