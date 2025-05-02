
namespace InvSis.Views
{
    partial class frmGestionPermisos
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
            lbTituloGestionRoles = new Label();
            splitContainer1 = new SplitContainer();
            btnAgregar = new Button();
            cbxEstatus = new ComboBox();
            lbEstatuS = new Label();
            txtDescripcionPermiso = new TextBox();
            lbDescripciopn = new Label();
            txtNombrePermiso = new TextBox();
            lblNombrePermiso = new Label();
            lbAgregarEditarPermiso = new Label();
            btnEliminar = new Button();
            lblEstatus = new Label();
            lblEstatusEliminar = new Label();
            lbDescripcionPermiso = new Label();
            LBdESCpERMISO = new Label();
            cbxPermisoEliminar = new ComboBox();
            LBpERMISOeLIMINAR = new Label();
            lbEliminarPermiso = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTituloGestionRoles
            // 
            lbTituloGestionRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTituloGestionRoles.BackColor = SystemColors.ActiveCaption;
            lbTituloGestionRoles.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloGestionRoles.ForeColor = SystemColors.ControlText;
            lbTituloGestionRoles.Location = new Point(2, 0);
            lbTituloGestionRoles.Name = "lbTituloGestionRoles";
            lbTituloGestionRoles.Size = new Size(1340, 0);
            lbTituloGestionRoles.TabIndex = 1;
            lbTituloGestionRoles.Text = "Gestion de permisos";
            lbTituloGestionRoles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 45);
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Panel2.Controls.Add(lblEstatus);
            splitContainer1.Panel2.Controls.Add(lblEstatusEliminar);
            splitContainer1.Panel2.Controls.Add(lbDescripcionPermiso);
            splitContainer1.Panel2.Controls.Add(LBdESCpERMISO);
            splitContainer1.Panel2.Controls.Add(cbxPermisoEliminar);
            splitContainer1.Panel2.Controls.Add(LBpERMISOeLIMINAR);
            splitContainer1.Panel2.Controls.Add(lbEliminarPermiso);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1340, 326);
            splitContainer1.SplitterDistance = 667;
            splitContainer1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(532, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 37);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(219, 159);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(133, 25);
            cbxEstatus.TabIndex = 6;
            cbxEstatus.SelectedIndexChanged += cbxEstatus_SelectedIndexChanged;
            // 
            // lbEstatuS
            // 
            lbEstatuS.AutoSize = true;
            lbEstatuS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatuS.Location = new Point(19, 156);
            lbEstatuS.Name = "lbEstatuS";
            lbEstatuS.Size = new Size(59, 21);
            lbEstatuS.TabIndex = 5;
            lbEstatuS.Text = "Estatus";
            // 
            // txtDescripcionPermiso
            // 
            txtDescripcionPermiso.Location = new Point(219, 110);
            txtDescripcionPermiso.Name = "txtDescripcionPermiso";
            txtDescripcionPermiso.Size = new Size(407, 25);
            txtDescripcionPermiso.TabIndex = 4;
            // 
            // lbDescripciopn
            // 
            lbDescripciopn.AutoSize = true;
            lbDescripciopn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripciopn.Location = new Point(19, 107);
            lbDescripciopn.Name = "lbDescripciopn";
            lbDescripciopn.Size = new Size(177, 21);
            lbDescripciopn.TabIndex = 3;
            lbDescripciopn.Text = "Descripcion del permiso";
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(219, 64);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(407, 25);
            txtNombrePermiso.TabIndex = 2;
            txtNombrePermiso.TextChanged += txtNombrePermiso_TextChanged;
            // 
            // lblNombrePermiso
            // 
            lblNombrePermiso.AutoSize = true;
            lblNombrePermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePermiso.Location = new Point(19, 63);
            lblNombrePermiso.Name = "lblNombrePermiso";
            lblNombrePermiso.Size = new Size(154, 21);
            lblNombrePermiso.TabIndex = 1;
            lblNombrePermiso.Text = "Nombre del permiso";
            // 
            // lbAgregarEditarPermiso
            // 
            lbAgregarEditarPermiso.AutoSize = true;
            lbAgregarEditarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarEditarPermiso.Location = new Point(158, 12);
            lbAgregarEditarPermiso.Name = "lbAgregarEditarPermiso";
            lbAgregarEditarPermiso.Size = new Size(258, 30);
            lbAgregarEditarPermiso.TabIndex = 0;
            lbAgregarEditarPermiso.Text = "Agregar o editar permiso";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(552, 264);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 37);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(241, 220);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(220, 21);
            lblEstatus.TabIndex = 7;
            lblEstatus.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // lblEstatusEliminar
            // 
            lblEstatusEliminar.AutoSize = true;
            lblEstatusEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatusEliminar.Location = new Point(32, 220);
            lblEstatusEliminar.Name = "lblEstatusEliminar";
            lblEstatusEliminar.Size = new Size(59, 21);
            lblEstatusEliminar.TabIndex = 6;
            lblEstatusEliminar.Text = "Estatus";
            // 
            // lbDescripcionPermiso
            // 
            lbDescripcionPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripcionPermiso.Location = new Point(241, 107);
            lbDescripcionPermiso.Name = "lbDescripcionPermiso";
            lbDescripcionPermiso.Size = new Size(405, 94);
            lbDescripcionPermiso.TabIndex = 5;
            // 
            // LBdESCpERMISO
            // 
            LBdESCpERMISO.AutoSize = true;
            LBdESCpERMISO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBdESCpERMISO.Location = new Point(32, 139);
            LBdESCpERMISO.Name = "LBdESCpERMISO";
            LBdESCpERMISO.Size = new Size(177, 21);
            LBdESCpERMISO.TabIndex = 4;
            LBdESCpERMISO.Text = "Descripcion del permiso";
            // 
            // cbxPermisoEliminar
            // 
            cbxPermisoEliminar.FormattingEnabled = true;
            cbxPermisoEliminar.Location = new Point(241, 63);
            cbxPermisoEliminar.Name = "cbxPermisoEliminar";
            cbxPermisoEliminar.Size = new Size(406, 25);
            cbxPermisoEliminar.TabIndex = 3;
            cbxPermisoEliminar.SelectedIndexChanged += cbxPermisoEliminar_SelectedIndexChanged;
            // 
            // LBpERMISOeLIMINAR
            // 
            LBpERMISOeLIMINAR.AutoSize = true;
            LBpERMISOeLIMINAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBpERMISOeLIMINAR.Location = new Point(32, 63);
            LBpERMISOeLIMINAR.Name = "LBpERMISOeLIMINAR";
            LBpERMISOeLIMINAR.Size = new Size(139, 21);
            LBpERMISOeLIMINAR.TabIndex = 2;
            LBpERMISOeLIMINAR.Text = "Permiso a eliminar";
            // 
            // lbEliminarPermiso
            // 
            lbEliminarPermiso.AutoSize = true;
            lbEliminarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEliminarPermiso.Location = new Point(241, 12);
            lbEliminarPermiso.Name = "lbEliminarPermiso";
            lbEliminarPermiso.Size = new Size(174, 30);
            lbEliminarPermiso.TabIndex = 1;
            lbEliminarPermiso.Text = "Eliminar permiso";
            // 
            // frmGestionPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 382);
            Controls.Add(splitContainer1);
            Controls.Add(lbTituloGestionRoles);
            Name = "frmGestionPermisos";
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
            //algo
        }

        #endregion

        private Label lbTituloGestionRoles;
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
        private ComboBox cbxPermisoEliminar;
        private Label LBpERMISOeLIMINAR;
        private Button btnEliminar;
    }
}