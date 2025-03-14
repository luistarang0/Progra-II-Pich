namespace InvSis.Views
{
    partial class frmPersona
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
            scPersonas = new SplitContainer();
            gbAlta = new GroupBox();
            nudEdad = new NumericUpDown();
            btAlta = new Button();
            lblDatosObligatorios = new Label();
            lblEdad = new Label();
            txtNacionalidad = new TextBox();
            lblNacionalidad = new Label();
            cbSexo = new ComboBox();
            lblSexo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbEdicionOEliminacion = new GroupBox();
            nudCambioEdad = new NumericUpDown();
            btEliminar = new Button();
            btGuardarCambios = new Button();
            lblCambioEdad = new Label();
            txtCambioNacionalidad = new TextBox();
            lblCambioNacionalidad = new Label();
            cbCambioSexo = new ComboBox();
            lblCambioSexo = new Label();
            txtCambioNombre = new TextBox();
            lblCambioNombre = new Label();
            lblSelección = new Label();
            cbSelección = new ComboBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)scPersonas).BeginInit();
            scPersonas.Panel1.SuspendLayout();
            scPersonas.Panel2.SuspendLayout();
            scPersonas.SuspendLayout();
            gbAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            gbEdicionOEliminacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCambioEdad).BeginInit();
            SuspendLayout();
            // 
            // scPersonas
            // 
            scPersonas.Dock = DockStyle.Fill;
            scPersonas.Location = new Point(0, 49);
            scPersonas.Name = "scPersonas";
            // 
            // scPersonas.Panel1
            // 
            scPersonas.Panel1.Controls.Add(gbAlta);
            // 
            // scPersonas.Panel2
            // 
            scPersonas.Panel2.Controls.Add(gbEdicionOEliminacion);
            scPersonas.Size = new Size(842, 555);
            scPersonas.SplitterDistance = 357;
            scPersonas.TabIndex = 3;
            // 
            // gbAlta
            // 
            gbAlta.Controls.Add(nudEdad);
            gbAlta.Controls.Add(btAlta);
            gbAlta.Controls.Add(lblDatosObligatorios);
            gbAlta.Controls.Add(lblEdad);
            gbAlta.Controls.Add(txtNacionalidad);
            gbAlta.Controls.Add(lblNacionalidad);
            gbAlta.Controls.Add(cbSexo);
            gbAlta.Controls.Add(lblSexo);
            gbAlta.Controls.Add(txtNombre);
            gbAlta.Controls.Add(lblNombre);
            gbAlta.Dock = DockStyle.Top;
            gbAlta.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbAlta.Location = new Point(0, 0);
            gbAlta.Name = "gbAlta";
            gbAlta.Size = new Size(357, 554);
            gbAlta.TabIndex = 0;
            gbAlta.TabStop = false;
            gbAlta.Text = "Alta de persona";
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(12, 342);
            nudEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 31);
            nudEdad.TabIndex = 14;
            nudEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // btAlta
            // 
            btAlta.AutoSize = true;
            btAlta.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btAlta.Location = new Point(228, 408);
            btAlta.Name = "btAlta";
            btAlta.Size = new Size(82, 33);
            btAlta.TabIndex = 13;
            btAlta.Text = "Guardar";
            btAlta.TextAlign = ContentAlignment.MiddleRight;
            btAlta.UseVisualStyleBackColor = true;
            btAlta.Click += btAlta_Click;
            // 
            // lblDatosObligatorios
            // 
            lblDatosObligatorios.AutoSize = true;
            lblDatosObligatorios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatosObligatorios.Location = new Point(12, 418);
            lblDatosObligatorios.Name = "lblDatosObligatorios";
            lblDatosObligatorios.Size = new Size(161, 23);
            lblDatosObligatorios.TabIndex = 8;
            lblDatosObligatorios.Text = "* Datos obligatorios";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(12, 316);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(60, 23);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad *";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(12, 249);
            txtNacionalidad.MaxLength = 20;
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(298, 31);
            txtNacionalidad.TabIndex = 5;
            // 
            // lblNacionalidad
            // 
            lblNacionalidad.AutoSize = true;
            lblNacionalidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNacionalidad.Location = new Point(12, 223);
            lblNacionalidad.Name = "lblNacionalidad";
            lblNacionalidad.Size = new Size(122, 23);
            lblNacionalidad.TabIndex = 4;
            lblNacionalidad.Text = "Nacionalidad *";
            // 
            // cbSexo
            // 
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(12, 158);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(298, 33);
            cbSexo.TabIndex = 3;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(12, 132);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(58, 23);
            lblSexo.TabIndex = 2;
            lblSexo.Text = "Sexo *";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 75);
            txtNombre.MaxLength = 20;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 31);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(162, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo *";
            // 
            // gbEdicionOEliminacion
            // 
            gbEdicionOEliminacion.AutoSize = true;
            gbEdicionOEliminacion.Controls.Add(nudCambioEdad);
            gbEdicionOEliminacion.Controls.Add(btEliminar);
            gbEdicionOEliminacion.Controls.Add(btGuardarCambios);
            gbEdicionOEliminacion.Controls.Add(lblCambioEdad);
            gbEdicionOEliminacion.Controls.Add(txtCambioNacionalidad);
            gbEdicionOEliminacion.Controls.Add(lblCambioNacionalidad);
            gbEdicionOEliminacion.Controls.Add(cbCambioSexo);
            gbEdicionOEliminacion.Controls.Add(lblCambioSexo);
            gbEdicionOEliminacion.Controls.Add(txtCambioNombre);
            gbEdicionOEliminacion.Controls.Add(lblCambioNombre);
            gbEdicionOEliminacion.Controls.Add(lblSelección);
            gbEdicionOEliminacion.Controls.Add(cbSelección);
            gbEdicionOEliminacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEdicionOEliminacion.Location = new Point(3, 0);
            gbEdicionOEliminacion.Name = "gbEdicionOEliminacion";
            gbEdicionOEliminacion.Size = new Size(472, 554);
            gbEdicionOEliminacion.TabIndex = 0;
            gbEdicionOEliminacion.TabStop = false;
            gbEdicionOEliminacion.Text = "Edición o eliminación de persona";
            // 
            // nudCambioEdad
            // 
            nudCambioEdad.Location = new Point(21, 421);
            nudCambioEdad.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            nudCambioEdad.Name = "nudCambioEdad";
            nudCambioEdad.Size = new Size(150, 31);
            nudCambioEdad.TabIndex = 25;
            nudCambioEdad.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // btEliminar
            // 
            btEliminar.AutoSize = true;
            btEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(287, 491);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(147, 33);
            btEliminar.TabIndex = 24;
            btEliminar.Text = "Eliminar persona";
            btEliminar.TextAlign = ContentAlignment.MiddleRight;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btGuardarCambios
            // 
            btGuardarCambios.AutoSize = true;
            btGuardarCambios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btGuardarCambios.Location = new Point(21, 491);
            btGuardarCambios.Name = "btGuardarCambios";
            btGuardarCambios.Size = new Size(150, 33);
            btGuardarCambios.TabIndex = 23;
            btGuardarCambios.Text = "Guardar cambios";
            btGuardarCambios.TextAlign = ContentAlignment.MiddleRight;
            btGuardarCambios.UseVisualStyleBackColor = true;
            btGuardarCambios.Click += btGuardarCambios_Click;
            // 
            // lblCambioEdad
            // 
            lblCambioEdad.AutoSize = true;
            lblCambioEdad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioEdad.Location = new Point(21, 395);
            lblCambioEdad.Name = "lblCambioEdad";
            lblCambioEdad.Size = new Size(136, 23);
            lblCambioEdad.TabIndex = 21;
            lblCambioEdad.Text = "Cambio de edad";
            // 
            // txtCambioNacionalidad
            // 
            txtCambioNacionalidad.Location = new Point(21, 328);
            txtCambioNacionalidad.MaxLength = 20;
            txtCambioNacionalidad.Name = "txtCambioNacionalidad";
            txtCambioNacionalidad.Size = new Size(298, 31);
            txtCambioNacionalidad.TabIndex = 20;
            // 
            // lblCambioNacionalidad
            // 
            lblCambioNacionalidad.AutoSize = true;
            lblCambioNacionalidad.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioNacionalidad.Location = new Point(21, 302);
            lblCambioNacionalidad.Name = "lblCambioNacionalidad";
            lblCambioNacionalidad.Size = new Size(195, 23);
            lblCambioNacionalidad.TabIndex = 19;
            lblCambioNacionalidad.Text = "Cambio de nacionalidad";
            // 
            // cbCambioSexo
            // 
            cbCambioSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCambioSexo.FormattingEnabled = true;
            cbCambioSexo.Location = new Point(21, 237);
            cbCambioSexo.Name = "cbCambioSexo";
            cbCambioSexo.Size = new Size(298, 33);
            cbCambioSexo.TabIndex = 18;
            // 
            // lblCambioSexo
            // 
            lblCambioSexo.AutoSize = true;
            lblCambioSexo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioSexo.Location = new Point(21, 211);
            lblCambioSexo.Name = "lblCambioSexo";
            lblCambioSexo.Size = new Size(132, 23);
            lblCambioSexo.TabIndex = 17;
            lblCambioSexo.Text = "Cambio de sexo";
            // 
            // txtCambioNombre
            // 
            txtCambioNombre.Location = new Point(21, 154);
            txtCambioNombre.MaxLength = 20;
            txtCambioNombre.Name = "txtCambioNombre";
            txtCambioNombre.Size = new Size(298, 31);
            txtCambioNombre.TabIndex = 16;
            // 
            // lblCambioNombre
            // 
            lblCambioNombre.AutoSize = true;
            lblCambioNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambioNombre.Location = new Point(21, 128);
            lblCambioNombre.Name = "lblCambioNombre";
            lblCambioNombre.Size = new Size(158, 23);
            lblCambioNombre.TabIndex = 15;
            lblCambioNombre.Text = "Cambio de nombre";
            // 
            // lblSelección
            // 
            lblSelección.AutoSize = true;
            lblSelección.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelección.Location = new Point(21, 49);
            lblSelección.Name = "lblSelección";
            lblSelección.Size = new Size(183, 23);
            lblSelección.TabIndex = 14;
            lblSelección.Text = "Selección de persona *";
            // 
            // cbSelección
            // 
            cbSelección.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelección.FormattingEnabled = true;
            cbSelección.Location = new Point(21, 75);
            cbSelección.Name = "cbSelección";
            cbSelección.Size = new Size(413, 33);
            cbSelección.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = SystemColors.InactiveCaption;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(842, 49);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Administración de personas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 604);
            Controls.Add(scPersonas);
            Controls.Add(lblTitulo);
            Name = "frmPersona";
            Text = "frmPersona";
            scPersonas.Panel1.ResumeLayout(false);
            scPersonas.Panel2.ResumeLayout(false);
            scPersonas.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scPersonas).EndInit();
            scPersonas.ResumeLayout(false);
            gbAlta.ResumeLayout(false);
            gbAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            gbEdicionOEliminacion.ResumeLayout(false);
            gbEdicionOEliminacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCambioEdad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer scPersonas;
        private GroupBox gbAlta;
        private Button btAlta;
        private PictureBox pbPersona;
        private Button btRegistroPersona;
        private ComboBox cbPersonas;
        private Label lblPersona;
        private Label lblDatosObligatorios;
        private ComboBox cbEstatus;
        private Label lblEdad;
        private TextBox txtNacionalidad;
        private Label lblNacionalidad;
        private ComboBox cbSexo;
        private Label lblSexo;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox gbEdicionOEliminacion;
        private Button btEliminar;
        private Button btGuardarCambios;
        private Label lblCambioPersona;
        private ComboBox cbCambioEstatus;
        private Label lblCambioEdad;
        private TextBox txtCambioNacionalidad;
        private Label lblCambioNacionalidad;
        private ComboBox cbCambioSexo;
        private Label lblCambioSexo;
        private TextBox txtCambioNombre;
        private Label lblCambioNombre;
        private Label lblSelección;
        private ComboBox cbSelección;
        private Label lblTitulo;
        private NumericUpDown nudEdad;
        private NumericUpDown nudCambioEdad;
    }
}