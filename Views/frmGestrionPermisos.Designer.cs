
namespace InvSis.Views
{
    partial class frmGestrionPermisos
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
            
            splitContainer1 = new SplitContainer();
            lbAgregarEditarPermiso = new Label();
            lbEliminarPermiso = new Label();
            lblNombrePermiso = new Label();
            txtNombrePermiso = new TextBox();
            lbDescripciopn = new Label();
            txtDescripcionPermiso = new TextBox();
            lbEstatuS = new Label();
            cbxEstatus = new ComboBox();
            btnAgregar = new Button();
            lblTitulo = new Label();

            LBpERMISOeLIMINAR = new Label();
            cbxPermisoElimicar = new ComboBox();
            LBdESCpERMISO = new Label();
            lbDescripcionPermiso = new Label();
            lblEstatusEliminar = new Label();
            lblEstatus = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // lblTitulo 
            lblTitulo.BackColor = ColorTranslator.FromHtml("#9F7AEA");
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(833, 55);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE ROLES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 53);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(cbxEstatus);
            splitContainer1.Panel1.Controls.Add(lbEstatuS);
            splitContainer1.Panel1.Controls.Add(txtDescripcionPermiso);
            splitContainer1.Panel1.Controls.Add(lbDescripciopn);
            splitContainer1.Panel1.Controls.Add(txtNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lblNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lbAgregarEditarPermiso);
            splitContainer1.ForeColor = ColorTranslator.FromHtml("#9F7AEA");
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(lblEstatus);
            splitContainer1.Panel2.Controls.Add(lblEstatusEliminar);
            splitContainer1.Panel2.Controls.Add(lbDescripcionPermiso);
            splitContainer1.Panel2.Controls.Add(LBdESCpERMISO);
            splitContainer1.Panel2.Controls.Add(cbxPermisoElimicar);
            splitContainer1.Panel2.Controls.Add(LBpERMISOeLIMINAR);
            splitContainer1.Panel2.Controls.Add(lbEliminarPermiso);
            splitContainer1.Panel2.Paint += this.splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1532, 383);
            splitContainer1.SplitterDistance = 763;
            splitContainer1.TabIndex = 2;
            // 
            // lbAgregarEditarPermiso
            // 
            lbAgregarEditarPermiso.AutoSize = true;
            lbAgregarEditarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarEditarPermiso.Location = new Point(180, 14);
            lbAgregarEditarPermiso.Name = "lbAgregarEditarPermiso";
            lbAgregarEditarPermiso.Size = new Size(327, 38);
            lbAgregarEditarPermiso.TabIndex = 0;
            lbAgregarEditarPermiso.Text = "Agregar o editar permiso";
            // 
            // lbEliminarPermiso
            // 
            lbEliminarPermiso.AutoSize = true;
            lbEliminarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEliminarPermiso.Location = new Point(275, 14);
            lbEliminarPermiso.Name = "lbEliminarPermiso";
            lbEliminarPermiso.Size = new Size(224, 38);
            lbEliminarPermiso.TabIndex = 1;
            lbEliminarPermiso.Text = "Eliminar permiso";
            // 
            // lblNombrePermiso
            // 
            lblNombrePermiso.AutoSize = true;
            lblNombrePermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePermiso.Location = new Point(22, 74);
            lblNombrePermiso.Name = "lblNombrePermiso";
            lblNombrePermiso.Size = new Size(193, 28);
            lblNombrePermiso.TabIndex = 1;
            lblNombrePermiso.Text = "Nombre del permiso";
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(250, 75);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(465, 27);
            txtNombrePermiso.TabIndex = 2;
            // 
            // lbDescripciopn
            // 
            lbDescripciopn.AutoSize = true;
            lbDescripciopn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripciopn.Location = new Point(22, 126);
            lbDescripciopn.Name = "lbDescripciopn";
            lbDescripciopn.Size = new Size(222, 28);
            lbDescripciopn.TabIndex = 3;
            lbDescripciopn.Text = "Descripcion del permiso";
            // 
            // txtDescripcionPermiso
            // 
            txtDescripcionPermiso.Location = new Point(250, 130);
            txtDescripcionPermiso.Name = "txtDescripcionPermiso";
            txtDescripcionPermiso.Size = new Size(465, 27);
            txtDescripcionPermiso.TabIndex = 4;
            // 
            // lbEstatuS
            // 
            lbEstatuS.AutoSize = true;
            lbEstatuS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatuS.Location = new Point(22, 183);
            lbEstatuS.Name = "lbEstatuS";
            lbEstatuS.Size = new Size(73, 28);
            lbEstatuS.TabIndex = 5;
            lbEstatuS.Text = "Estatus";
            //lbEstatuS.Click += this.label3_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(250, 187);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(151, 28);
            cbxEstatus.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(608, 232);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 44);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // LBpERMISOeLIMINAR
            // 
            LBpERMISOeLIMINAR.AutoSize = true;
            LBpERMISOeLIMINAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBpERMISOeLIMINAR.Location = new Point(37, 74);
            LBpERMISOeLIMINAR.Name = "LBpERMISOeLIMINAR";
            LBpERMISOeLIMINAR.Size = new Size(171, 28);
            LBpERMISOeLIMINAR.TabIndex = 2;
            LBpERMISOeLIMINAR.Text = "Permiso a eliminar";
            // 
            // cbxPermisoElimicar
            // 
            cbxPermisoElimicar.FormattingEnabled = true;
            cbxPermisoElimicar.Location = new Point(275, 74);
            cbxPermisoElimicar.Name = "cbxPermisoElimicar";
            cbxPermisoElimicar.Size = new Size(463, 28);
            cbxPermisoElimicar.TabIndex = 3;
            // 
            // LBdESCpERMISO
            // 
            LBdESCpERMISO.AutoSize = true;
            LBdESCpERMISO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBdESCpERMISO.Location = new Point(37, 163);
            LBdESCpERMISO.Name = "LBdESCpERMISO";
            LBdESCpERMISO.Size = new Size(222, 28);
            LBdESCpERMISO.TabIndex = 4;
            LBdESCpERMISO.Text = "Descripcion del permiso";
            // 
            // lbDescripcionPermiso
            // 
            lbDescripcionPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripcionPermiso.Location = new Point(275, 126);
            lbDescripcionPermiso.Name = "lbDescripcionPermiso";
            lbDescripcionPermiso.Size = new Size(463, 111);
            lbDescripcionPermiso.TabIndex = 5;
            // 
            // lblEstatusEliminar
            // 
            lblEstatusEliminar.AutoSize = true;
            lblEstatusEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatusEliminar.Location = new Point(37, 259);
            lblEstatusEliminar.Name = "lblEstatusEliminar";
            lblEstatusEliminar.Size = new Size(73, 28);
            lblEstatusEliminar.TabIndex = 6;
            lblEstatusEliminar.Text = "Estatus";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(275, 259);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(273, 28);
            lblEstatus.TabIndex = 7;
            lblEstatus.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(631, 311);
            button1.Name = "button1";
            button1.Size = new Size(107, 44);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmGestrionPermisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 449);
            Controls.Add(splitContainer1);
            Controls.Add(lblTitulo);
            BackColor = ColorTranslator.FromHtml("#E6F2F8");
            Name = "frmGestrionPermisos";
            Text = "frmGestionPermisos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lblTitulo;
        private SplitContainer splitContainer1;
        private Label lbAgregarEditarPermiso;
        private Label lbEliminarPermiso;
        private Label lbEstatuS;
        private TextBox txtDescripcionPermiso;
        private Label lbDescripciopn;
        private TextBox txtNombrePermiso;
        private Label lblNombrePermiso;
        private ComboBox cbxEstatus;
        private Button btnAgregar;
        private Label lblEstatus;
        private Label lblEstatusEliminar;
        private Label lbDescripcionPermiso;
        private Label LBdESCpERMISO;
        private ComboBox cbxPermisoElimicar;
        private Label LBpERMISOeLIMINAR;
        private Button button1;
    }
}