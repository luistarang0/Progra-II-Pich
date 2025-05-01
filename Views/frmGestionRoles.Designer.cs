
namespace InvSis.Views
{
    partial class frmGestionRoles
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
            lbAgregarRol = new Label();
            lbAgregarPermisosRol = new Label();
            lbNombreRol = new Label();
            label3 = new Label();
            txtNombreRol = new TextBox();
            cbxEstatus = new ComboBox();
            btnAgregarRol = new Button();
            lblEliminarRol = new Label();
            lblNombreEliminacionRol = new Label();
            cbxRolEliminar = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnEliminar = new Button();
            cbxRolAgregarPermisos = new ComboBox();
            label4 = new Label();
            lblSeleccionaPermisos = new Label();
            lblPermiso1 = new Label();
            lblEstatus = new Label();
            lblDescripcion = new Label();
            cbxPermiso = new ComboBox();
            lblContenidoDescripcion = new Label();
            btnAgregarPermiso = new Button();
            lblRemoverPermisos = new Label();
            lbEstatusRol = new Label();
            cbxRolRemoverPermisos = new ComboBox();
            lbRemoverPermisos = new Label();
            lbPermisoRemover = new Label();
            cbxPermisoAremover = new ComboBox();
            btnRemoverPermiso = new Button();
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
            lbTituloGestionRoles.Location = new Point(-7, 9);
            lbTituloGestionRoles.Name = "lbTituloGestionRoles";
            lbTituloGestionRoles.Size = new Size(1546, 50);
            lbTituloGestionRoles.TabIndex = 0;
            lbTituloGestionRoles.Text = "Gestion de roles";
            lbTituloGestionRoles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 59);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnEliminar);
            splitContainer1.Panel1.Controls.Add(cbxRolEliminar);
            splitContainer1.Panel1.Controls.Add(lblNombreEliminacionRol);
            splitContainer1.Panel1.Controls.Add(lblEliminarRol);
            splitContainer1.Panel1.Controls.Add(btnAgregarRol);
            splitContainer1.Panel1.Controls.Add(cbxEstatus);
            splitContainer1.Panel1.Controls.Add(txtNombreRol);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(lbNombreRol);
            splitContainer1.Panel1.Controls.Add(lbAgregarRol);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnRemoverPermiso);
            splitContainer1.Panel2.Controls.Add(cbxPermisoAremover);
            splitContainer1.Panel2.Controls.Add(lbPermisoRemover);
            splitContainer1.Panel2.Controls.Add(cbxRolRemoverPermisos);
            splitContainer1.Panel2.Controls.Add(lbRemoverPermisos);
            splitContainer1.Panel2.Controls.Add(lbEstatusRol);
            splitContainer1.Panel2.Controls.Add(lblRemoverPermisos);
            splitContainer1.Panel2.Controls.Add(btnAgregarPermiso);
            splitContainer1.Panel2.Controls.Add(lblContenidoDescripcion);
            splitContainer1.Panel2.Controls.Add(cbxPermiso);
            splitContainer1.Panel2.Controls.Add(lblDescripcion);
            splitContainer1.Panel2.Controls.Add(lblEstatus);
            splitContainer1.Panel2.Controls.Add(lblPermiso1);
            splitContainer1.Panel2.Controls.Add(lblSeleccionaPermisos);
            splitContainer1.Panel2.Controls.Add(cbxRolAgregarPermisos);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(lbAgregarPermisosRol);
            splitContainer1.Panel2.Paint += this.splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1537, 851);
            splitContainer1.SplitterDistance = 512;
            splitContainer1.TabIndex = 1;
            // 
            // lbAgregarRol
            // 
            lbAgregarRol.AutoSize = true;
            lbAgregarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarRol.Location = new Point(120, 23);
            lbAgregarRol.Name = "lbAgregarRol";
            lbAgregarRol.Size = new Size(260, 38);
            lbAgregarRol.TabIndex = 0;
            lbAgregarRol.Text = "Agregar o editar rol";
            // 
            // lbAgregarPermisosRol
            // 
            lbAgregarPermisosRol.AutoSize = true;
            lbAgregarPermisosRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarPermisosRol.Location = new Point(343, 23);
            lbAgregarPermisosRol.Name = "lbAgregarPermisosRol";
            lbAgregarPermisosRol.Size = new Size(299, 38);
            lbAgregarPermisosRol.TabIndex = 0;
            lbAgregarPermisosRol.Text = "Agregar permisos a rol";
            // 
            // lbNombreRol
            // 
            lbNombreRol.AutoSize = true;
            lbNombreRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreRol.Location = new Point(38, 100);
            lbNombreRol.Name = "lbNombreRol";
            lbNombreRol.Size = new Size(146, 28);
            lbNombreRol.TabIndex = 1;
            lbNombreRol.Text = "Nombre del rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 147);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Estatus";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(192, 98);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(291, 27);
            txtNombreRol.TabIndex = 3;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(192, 147);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(291, 28);
            cbxEstatus.TabIndex = 4;
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarRol.Location = new Point(366, 199);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(117, 36);
            btnAgregarRol.TabIndex = 5;
            btnAgregarRol.Text = "Agregar rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            // 
            // lblEliminarRol
            // 
            lblEliminarRol.AutoSize = true;
            lblEliminarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarRol.Location = new Point(169, 310);
            lblEliminarRol.Name = "lblEliminarRol";
            lblEliminarRol.Size = new Size(157, 38);
            lblEliminarRol.TabIndex = 6;
            lblEliminarRol.Text = "Eliminar rol";
            // 
            // lblNombreEliminacionRol
            // 
            lblNombreEliminacionRol.AutoSize = true;
            lblNombreEliminacionRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEliminacionRol.Location = new Point(38, 367);
            lblNombreEliminacionRol.Name = "lblNombreEliminacionRol";
            lblNombreEliminacionRol.Size = new Size(234, 28);
            lblNombreEliminacionRol.TabIndex = 7;
            lblNombreEliminacionRol.Text = "Seleciona el rol a eliminar";
            //lblNombreEliminacionRol.Click += this.lblNombreEliminacionRol_Click;
            // 
            // cbxRolEliminar
            // 
            cbxRolEliminar.FormattingEnabled = true;
            cbxRolEliminar.Location = new Point(38, 411);
            cbxRolEliminar.Name = "cbxRolEliminar";
            cbxRolEliminar.Size = new Size(445, 28);
            cbxRolEliminar.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(366, 467);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 36);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar rol";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cbxRolAgregarPermisos
            // 
            cbxRolAgregarPermisos.FormattingEnabled = true;
            cbxRolAgregarPermisos.Location = new Point(41, 147);
            cbxRolAgregarPermisos.Name = "cbxRolAgregarPermisos";
            cbxRolAgregarPermisos.Size = new Size(949, 28);
            cbxRolAgregarPermisos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 103);
            label4.Name = "label4";
            label4.Size = new Size(470, 28);
            label4.TabIndex = 9;
            label4.Text = "Seleciona el rol al cual se le desean agregar permisos";
            // 
            // lblSeleccionaPermisos
            // 
            lblSeleccionaPermisos.AutoSize = true;
            lblSeleccionaPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionaPermisos.Location = new Point(41, 219);
            lblSeleccionaPermisos.Name = "lblSeleccionaPermisos";
            lblSeleccionaPermisos.Size = new Size(288, 28);
            lblSeleccionaPermisos.TabIndex = 11;
            lblSeleccionaPermisos.Text = "Selecciona el permiso a agregar";
            // 
            // lblPermiso1
            // 
            lblPermiso1.AutoSize = true;
            lblPermiso1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermiso1.Location = new Point(54, 279);
            lblPermiso1.Name = "lblPermiso1";
            lblPermiso1.Size = new Size(86, 28);
            lblPermiso1.TabIndex = 12;
            lblPermiso1.Text = "Permiso ";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(54, 423);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(73, 28);
            lblEstatus.TabIndex = 13;
            lblEstatus.Text = "Estatus";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(54, 351);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(114, 28);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion";
            // 
            // cbxPermiso
            // 
            cbxPermiso.FormattingEnabled = true;
            cbxPermiso.Location = new Point(214, 279);
            cbxPermiso.Name = "cbxPermiso";
            cbxPermiso.Size = new Size(297, 28);
            cbxPermiso.TabIndex = 15;
            // 
            // lblContenidoDescripcion
            // 
            lblContenidoDescripcion.Location = new Point(214, 324);
            lblContenidoDescripcion.Name = "lblContenidoDescripcion";
            lblContenidoDescripcion.Size = new Size(777, 88);
            lblContenidoDescripcion.TabIndex = 16;
            // 
            // btnAgregarPermiso
            // 
            btnAgregarPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPermiso.Location = new Point(885, 423);
            btnAgregarPermiso.Name = "btnAgregarPermiso";
            btnAgregarPermiso.Size = new Size(105, 44);
            btnAgregarPermiso.TabIndex = 18;
            btnAgregarPermiso.Text = "Agregar";
            btnAgregarPermiso.UseVisualStyleBackColor = true;
            // 
            // lblRemoverPermisos
            // 
            lblRemoverPermisos.AutoSize = true;
            lblRemoverPermisos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemoverPermisos.Location = new Point(343, 482);
            lblRemoverPermisos.Name = "lblRemoverPermisos";
            lblRemoverPermisos.Size = new Size(285, 38);
            lblRemoverPermisos.TabIndex = 19;
            lblRemoverPermisos.Text = "Quitar permisos a rol ";
            // 
            // lbEstatusRol
            // 
            lbEstatusRol.AutoSize = true;
            lbEstatusRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatusRol.Location = new Point(214, 423);
            lbEstatusRol.Name = "lbEstatusRol";
            lbEstatusRol.Size = new Size(273, 28);
            lbEstatusRol.TabIndex = 20;
            lbEstatusRol.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // cbxRolRemoverPermisos
            // 
            cbxRolRemoverPermisos.FormattingEnabled = true;
            cbxRolRemoverPermisos.Location = new Point(41, 592);
            cbxRolRemoverPermisos.Name = "cbxRolRemoverPermisos";
            cbxRolRemoverPermisos.Size = new Size(949, 28);
            cbxRolRemoverPermisos.TabIndex = 22;
            // 
            // lbRemoverPermisos
            // 
            lbRemoverPermisos.AutoSize = true;
            lbRemoverPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRemoverPermisos.Location = new Point(41, 548);
            lbRemoverPermisos.Name = "lbRemoverPermisos";
            lbRemoverPermisos.Size = new Size(475, 28);
            lbRemoverPermisos.TabIndex = 21;
            lbRemoverPermisos.Text = "Seleciona el rol al cual se le desean remover permisos";
            // 
            // lbPermisoRemover
            // 
            lbPermisoRemover.AutoSize = true;
            lbPermisoRemover.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPermisoRemover.Location = new Point(41, 661);
            lbPermisoRemover.Name = "lbPermisoRemover";
            lbPermisoRemover.Size = new Size(293, 28);
            lbPermisoRemover.TabIndex = 23;
            lbPermisoRemover.Text = "Selecciona el permiso a remover";
            // 
            // cbxPermisoAremover
            // 
            cbxPermisoAremover.FormattingEnabled = true;
            cbxPermisoAremover.Location = new Point(343, 661);
            cbxPermisoAremover.Name = "cbxPermisoAremover";
            cbxPermisoAremover.Size = new Size(647, 28);
            cbxPermisoAremover.TabIndex = 24;
            // 
            // btnRemoverPermiso
            // 
            btnRemoverPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoverPermiso.Location = new Point(805, 734);
            btnRemoverPermiso.Name = "btnRemoverPermiso";
            btnRemoverPermiso.Size = new Size(185, 44);
            btnRemoverPermiso.TabIndex = 25;
            btnRemoverPermiso.Text = "Remover permiso";
            btnRemoverPermiso.UseVisualStyleBackColor = true;
            // 
            // frmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 922);
            Controls.Add(splitContainer1);
            Controls.Add(lbTituloGestionRoles);
            ForeColor = SystemColors.Desktop;
            Name = "frmGestionRoles";
            Text = "frmGestionRoles";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void lblNombreEliminacionRol_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbTituloGestionRoles;
        private SplitContainer splitContainer1;
        private Label lbAgregarRol;
        private Label lbAgregarPermisosRol;
        private Button btnAgregarRol;
        private ComboBox cbxEstatus;
        private TextBox txtNombreRol;
        private Label label3;
        private Label lbNombreRol;
        private Label lblNombreEliminacionRol;
        private Label lblEliminarRol;
        private Button btnEliminar;
        private ComboBox cbxRolEliminar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbxRolAgregarPermisos;
        private Label label4;
        private Label lblDescripcion;
        private Label lblEstatus;
        private Label lblPermiso1;
        private Label lblSeleccionaPermisos;
        private ComboBox cbxPermiso;
        private Button btnAgregarPermiso;
        private Label lblContenidoDescripcion;
        private Label lblRemoverPermisos;
        private ComboBox cbxPermisoAremover;
        private Label lbPermisoRemover;
        private ComboBox cbxRolRemoverPermisos;
        private Label lbRemoverPermisos;
        private Label lbEstatusRol;
        private Button btnRemoverPermiso;
    }
}