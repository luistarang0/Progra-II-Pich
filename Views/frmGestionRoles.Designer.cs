
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
            btnEliminar = new Button();
            cbxRolEliminar = new ComboBox();
            lblNombreEliminacionRol = new Label();
            lblEliminarRol = new Label();
            btnAgregarRol = new Button();
            cbxEstatus = new ComboBox();
            txtNombreRol = new TextBox();
            label3 = new Label();
            lbNombreRol = new Label();
            lbAgregarRol = new Label();
            btnRemoverPermiso = new Button();
            cbxPermisoAremover = new ComboBox();
            lbPermisoRemover = new Label();
            cbxRolRemoverPermisos = new ComboBox();
            lbRemoverPermisos = new Label();
            lbEstatusRol = new Label();
            lblRemoverPermisos = new Label();
            btnAgregarPermiso = new Button();
            lblContenidoDescripcion = new Label();
            cbxPermiso = new ComboBox();
            lblDescripcion = new Label();
            lblEstatus = new Label();
            lblPermiso1 = new Label();
            lblSeleccionaPermisos = new Label();
            cbxRolAgregarPermisos = new ComboBox();
            label4 = new Label();
            lbAgregarPermisosRol = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            lbTituloGestionRoles.Location = new Point(-6, 8);
            lbTituloGestionRoles.Name = "lbTituloGestionRoles";
            lbTituloGestionRoles.Size = new Size(1353, 42);
            lbTituloGestionRoles.TabIndex = 0;
            lbTituloGestionRoles.Text = "Gestion de roles";
            lbTituloGestionRoles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 50);
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
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1345, 723);
            splitContainer1.SplitterDistance = 448;
            splitContainer1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(320, 397);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 31);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar rol";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cbxRolEliminar
            // 
            cbxRolEliminar.FormattingEnabled = true;
            cbxRolEliminar.Location = new Point(33, 349);
            cbxRolEliminar.Name = "cbxRolEliminar";
            cbxRolEliminar.Size = new Size(390, 25);
            cbxRolEliminar.TabIndex = 8;
            // 
            // lblNombreEliminacionRol
            // 
            lblNombreEliminacionRol.AutoSize = true;
            lblNombreEliminacionRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEliminacionRol.Location = new Point(33, 312);
            lblNombreEliminacionRol.Name = "lblNombreEliminacionRol";
            lblNombreEliminacionRol.Size = new Size(188, 21);
            lblNombreEliminacionRol.TabIndex = 7;
            lblNombreEliminacionRol.Text = "Seleciona el rol a eliminar";
            // 
            // lblEliminarRol
            // 
            lblEliminarRol.AutoSize = true;
            lblEliminarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarRol.Location = new Point(148, 264);
            lblEliminarRol.Name = "lblEliminarRol";
            lblEliminarRol.Size = new Size(121, 30);
            lblEliminarRol.TabIndex = 6;
            lblEliminarRol.Text = "Eliminar rol";
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarRol.Location = new Point(320, 169);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(102, 31);
            btnAgregarRol.TabIndex = 5;
            btnAgregarRol.Text = "Agregar rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            btnAgregarRol.Click += btnAgregarRol_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(168, 125);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(255, 25);
            cbxEstatus.TabIndex = 4;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(168, 83);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(255, 25);
            txtNombreRol.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 2;
            label3.Text = "Estatus";
            // 
            // lbNombreRol
            // 
            lbNombreRol.AutoSize = true;
            lbNombreRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreRol.Location = new Point(33, 85);
            lbNombreRol.Name = "lbNombreRol";
            lbNombreRol.Size = new Size(116, 21);
            lbNombreRol.TabIndex = 1;
            lbNombreRol.Text = "Nombre del rol";
            // 
            // lbAgregarRol
            // 
            lbAgregarRol.AutoSize = true;
            lbAgregarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarRol.Location = new Point(105, 20);
            lbAgregarRol.Name = "lbAgregarRol";
            lbAgregarRol.Size = new Size(205, 30);
            lbAgregarRol.TabIndex = 0;
            lbAgregarRol.Text = "Agregar o editar rol";
            // 
            // btnRemoverPermiso
            // 
            btnRemoverPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoverPermiso.Location = new Point(704, 624);
            btnRemoverPermiso.Name = "btnRemoverPermiso";
            btnRemoverPermiso.Size = new Size(162, 37);
            btnRemoverPermiso.TabIndex = 25;
            btnRemoverPermiso.Text = "Remover permiso";
            btnRemoverPermiso.UseVisualStyleBackColor = true;
            btnRemoverPermiso.Click += btnRemoverPermiso_Click;
            // 
            // cbxPermisoAremover
            // 
            cbxPermisoAremover.FormattingEnabled = true;
            cbxPermisoAremover.Location = new Point(300, 562);
            cbxPermisoAremover.Name = "cbxPermisoAremover";
            cbxPermisoAremover.Size = new Size(567, 25);
            cbxPermisoAremover.TabIndex = 24;
            // 
            // lbPermisoRemover
            // 
            lbPermisoRemover.AutoSize = true;
            lbPermisoRemover.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPermisoRemover.Location = new Point(36, 562);
            lbPermisoRemover.Name = "lbPermisoRemover";
            lbPermisoRemover.Size = new Size(235, 21);
            lbPermisoRemover.TabIndex = 23;
            lbPermisoRemover.Text = "Selecciona el permiso a remover";
            // 
            // cbxRolRemoverPermisos
            // 
            cbxRolRemoverPermisos.FormattingEnabled = true;
            cbxRolRemoverPermisos.Location = new Point(36, 503);
            cbxRolRemoverPermisos.Name = "cbxRolRemoverPermisos";
            cbxRolRemoverPermisos.Size = new Size(831, 25);
            cbxRolRemoverPermisos.TabIndex = 22;
            cbxRolRemoverPermisos.SelectedIndexChanged += cbxRolRemoverPermisos_SelectedIndexChanged;
            // 
            // lbRemoverPermisos
            // 
            lbRemoverPermisos.AutoSize = true;
            lbRemoverPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRemoverPermisos.Location = new Point(36, 466);
            lbRemoverPermisos.Name = "lbRemoverPermisos";
            lbRemoverPermisos.Size = new Size(382, 21);
            lbRemoverPermisos.TabIndex = 21;
            lbRemoverPermisos.Text = "Seleciona el rol al cual se le desean remover permisos";
            // 
            // lbEstatusRol
            // 
            lbEstatusRol.AutoSize = true;
            lbEstatusRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatusRol.Location = new Point(187, 360);
            lbEstatusRol.Name = "lbEstatusRol";
            lbEstatusRol.Size = new Size(220, 21);
            lbEstatusRol.TabIndex = 20;
            lbEstatusRol.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // lblRemoverPermisos
            // 
            lblRemoverPermisos.AutoSize = true;
            lblRemoverPermisos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemoverPermisos.Location = new Point(300, 410);
            lblRemoverPermisos.Name = "lblRemoverPermisos";
            lblRemoverPermisos.Size = new Size(222, 30);
            lblRemoverPermisos.TabIndex = 19;
            lblRemoverPermisos.Text = "Quitar permisos a rol ";
            // 
            // btnAgregarPermiso
            // 
            btnAgregarPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPermiso.Location = new Point(774, 360);
            btnAgregarPermiso.Name = "btnAgregarPermiso";
            btnAgregarPermiso.Size = new Size(92, 37);
            btnAgregarPermiso.TabIndex = 18;
            btnAgregarPermiso.Text = "Agregar";
            btnAgregarPermiso.UseVisualStyleBackColor = true;
            btnAgregarPermiso.Click += btnAgregarPermiso_Click;
            // 
            // lblContenidoDescripcion
            // 
            lblContenidoDescripcion.Location = new Point(187, 275);
            lblContenidoDescripcion.Name = "lblContenidoDescripcion";
            lblContenidoDescripcion.Size = new Size(680, 75);
            lblContenidoDescripcion.TabIndex = 16;
            // 
            // cbxPermiso
            // 
            cbxPermiso.FormattingEnabled = true;
            cbxPermiso.Location = new Point(187, 237);
            cbxPermiso.Name = "cbxPermiso";
            cbxPermiso.Size = new Size(260, 25);
            cbxPermiso.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(47, 298);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(47, 360);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(59, 21);
            lblEstatus.TabIndex = 13;
            lblEstatus.Text = "Estatus";
            // 
            // lblPermiso1
            // 
            lblPermiso1.AutoSize = true;
            lblPermiso1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermiso1.Location = new Point(47, 237);
            lblPermiso1.Name = "lblPermiso1";
            lblPermiso1.Size = new Size(70, 21);
            lblPermiso1.TabIndex = 12;
            lblPermiso1.Text = "Permiso ";
            // 
            // lblSeleccionaPermisos
            // 
            lblSeleccionaPermisos.AutoSize = true;
            lblSeleccionaPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionaPermisos.Location = new Point(36, 186);
            lblSeleccionaPermisos.Name = "lblSeleccionaPermisos";
            lblSeleccionaPermisos.Size = new Size(230, 21);
            lblSeleccionaPermisos.TabIndex = 11;
            lblSeleccionaPermisos.Text = "Selecciona el permiso a agregar";
            // 
            // cbxRolAgregarPermisos
            // 
            cbxRolAgregarPermisos.FormattingEnabled = true;
            cbxRolAgregarPermisos.Location = new Point(36, 125);
            cbxRolAgregarPermisos.Name = "cbxRolAgregarPermisos";
            cbxRolAgregarPermisos.Size = new Size(831, 25);
            cbxRolAgregarPermisos.TabIndex = 10;
            cbxRolAgregarPermisos.SelectedIndexChanged += cbxRolAgregarPermisos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 88);
            label4.Name = "label4";
            label4.Size = new Size(377, 21);
            label4.TabIndex = 9;
            label4.Text = "Seleciona el rol al cual se le desean agregar permisos";
            // 
            // lbAgregarPermisosRol
            // 
            lbAgregarPermisosRol.AutoSize = true;
            lbAgregarPermisosRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarPermisosRol.Location = new Point(300, 20);
            lbAgregarPermisosRol.Name = "lbAgregarPermisosRol";
            lbAgregarPermisosRol.Size = new Size(235, 30);
            lbAgregarPermisosRol.TabIndex = 0;
            lbAgregarPermisosRol.Text = "Agregar permisos a rol";
            // 
            // frmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 784);
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