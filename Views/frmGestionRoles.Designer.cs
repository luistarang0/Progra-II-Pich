
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
            lblTitulo = new Label();
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
            splitContainer1.Location = new Point(2, 74);
            splitContainer1.Margin = new Padding(4, 4, 4, 4);
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
            splitContainer1.Size = new Size(1921, 1064);
            splitContainer1.SplitterDistance = 639;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            splitContainer1.ForeColor = ColorTranslator.FromHtml("#9F7AEA");
            splitContainer1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(458, 584);
            btnEliminar.Margin = new Padding(4, 4, 4, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 45);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar rol";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cbxRolEliminar
            // 
            cbxRolEliminar.FormattingEnabled = true;
            cbxRolEliminar.Location = new Point(48, 514);
            cbxRolEliminar.Margin = new Padding(4, 4, 4, 4);
            cbxRolEliminar.Name = "cbxRolEliminar";
            cbxRolEliminar.Size = new Size(555, 33);
            cbxRolEliminar.TabIndex = 8;
            // 
            // lblNombreEliminacionRol
            // 
            lblNombreEliminacionRol.AutoSize = true;
            lblNombreEliminacionRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreEliminacionRol.Location = new Point(48, 459);
            lblNombreEliminacionRol.Margin = new Padding(4, 0, 4, 0);
            lblNombreEliminacionRol.Name = "lblNombreEliminacionRol";
            lblNombreEliminacionRol.Size = new Size(289, 32);
            lblNombreEliminacionRol.TabIndex = 7;
            lblNombreEliminacionRol.Text = "Seleciona el rol a eliminar";
            // 
            // lblEliminarRol
            // 
            lblEliminarRol.AutoSize = true;
            lblEliminarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEliminarRol.Location = new Point(211, 388);
            lblEliminarRol.Margin = new Padding(4, 0, 4, 0);
            lblEliminarRol.Name = "lblEliminarRol";
            lblEliminarRol.Size = new Size(183, 45);
            lblEliminarRol.TabIndex = 6;
            lblEliminarRol.Text = "Eliminar rol";
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarRol.Location = new Point(458, 249);
            btnAgregarRol.Margin = new Padding(4, 4, 4, 4);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(146, 45);
            btnAgregarRol.TabIndex = 5;
            btnAgregarRol.Text = "Agregar rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(240, 184);
            cbxEstatus.Margin = new Padding(4, 4, 4, 4);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(363, 33);
            cbxEstatus.TabIndex = 4;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(240, 122);
            txtNombreRol.Margin = new Padding(4, 4, 4, 4);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(363, 31);
            txtNombreRol.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 2;
            label3.Text = "Estatus";
            // 
            // lbNombreRol
            // 
            lbNombreRol.AutoSize = true;
            lbNombreRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombreRol.Location = new Point(48, 125);
            lbNombreRol.Margin = new Padding(4, 0, 4, 0);
            lbNombreRol.Name = "lbNombreRol";
            lbNombreRol.Size = new Size(177, 32);
            lbNombreRol.TabIndex = 1;
            lbNombreRol.Text = "Nombre del rol";
            // 
            // lbAgregarRol
            // 
            lbAgregarRol.AutoSize = true;
            lbAgregarRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarRol.Location = new Point(150, 29);
            lbAgregarRol.Margin = new Padding(4, 0, 4, 0);
            lbAgregarRol.Name = "lbAgregarRol";
            lbAgregarRol.Size = new Size(302, 45);
            lbAgregarRol.TabIndex = 0;
            lbAgregarRol.Text = "Agregar o editar rol";
            // 
            // btnRemoverPermiso
            // 
            btnRemoverPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoverPermiso.Location = new Point(1006, 918);
            btnRemoverPermiso.Margin = new Padding(4, 4, 4, 4);
            btnRemoverPermiso.Name = "btnRemoverPermiso";
            btnRemoverPermiso.Size = new Size(231, 55);
            btnRemoverPermiso.TabIndex = 25;
            btnRemoverPermiso.Text = "Remover permiso";
            btnRemoverPermiso.UseVisualStyleBackColor = true;
            // 
            // cbxPermisoAremover
            // 
            cbxPermisoAremover.FormattingEnabled = true;
            cbxPermisoAremover.Location = new Point(429, 826);
            cbxPermisoAremover.Margin = new Padding(4, 4, 4, 4);
            cbxPermisoAremover.Name = "cbxPermisoAremover";
            cbxPermisoAremover.Size = new Size(808, 33);
            cbxPermisoAremover.TabIndex = 24;
            // 
            // lbPermisoRemover
            // 
            lbPermisoRemover.AutoSize = true;
            lbPermisoRemover.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPermisoRemover.Location = new Point(51, 826);
            lbPermisoRemover.Margin = new Padding(4, 0, 4, 0);
            lbPermisoRemover.Name = "lbPermisoRemover";
            lbPermisoRemover.Size = new Size(361, 32);
            lbPermisoRemover.TabIndex = 23;
            lbPermisoRemover.Text = "Selecciona el permiso a remover";
            // 
            // cbxRolRemoverPermisos
            // 
            cbxRolRemoverPermisos.FormattingEnabled = true;
            cbxRolRemoverPermisos.Location = new Point(51, 740);
            cbxRolRemoverPermisos.Margin = new Padding(4, 4, 4, 4);
            cbxRolRemoverPermisos.Name = "cbxRolRemoverPermisos";
            cbxRolRemoverPermisos.Size = new Size(1185, 33);
            cbxRolRemoverPermisos.TabIndex = 22;
            // 
            // lbRemoverPermisos
            // 
            lbRemoverPermisos.AutoSize = true;
            lbRemoverPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRemoverPermisos.Location = new Point(51, 685);
            lbRemoverPermisos.Margin = new Padding(4, 0, 4, 0);
            lbRemoverPermisos.Name = "lbRemoverPermisos";
            lbRemoverPermisos.Size = new Size(590, 32);
            lbRemoverPermisos.TabIndex = 21;
            lbRemoverPermisos.Text = "Seleciona el rol al cual se le desean remover permisos";
            // 
            // lbEstatusRol
            // 
            lbEstatusRol.AutoSize = true;
            lbEstatusRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatusRol.Location = new Point(268, 529);
            lbEstatusRol.Margin = new Padding(4, 0, 4, 0);
            lbEstatusRol.Name = "lbEstatusRol";
            lbEstatusRol.Size = new Size(330, 32);
            lbEstatusRol.TabIndex = 20;
            lbEstatusRol.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // lblRemoverPermisos
            // 
            lblRemoverPermisos.AutoSize = true;
            lblRemoverPermisos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemoverPermisos.Location = new Point(429, 602);
            lblRemoverPermisos.Margin = new Padding(4, 0, 4, 0);
            lblRemoverPermisos.Name = "lblRemoverPermisos";
            lblRemoverPermisos.Size = new Size(332, 45);
            lblRemoverPermisos.TabIndex = 19;
            lblRemoverPermisos.Text = "Quitar permisos a rol ";
            // 
            // btnAgregarPermiso
            // 
            btnAgregarPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPermiso.Location = new Point(1106, 529);
            btnAgregarPermiso.Margin = new Padding(4, 4, 4, 4);
            btnAgregarPermiso.Name = "btnAgregarPermiso";
            btnAgregarPermiso.Size = new Size(131, 55);
            btnAgregarPermiso.TabIndex = 18;
            btnAgregarPermiso.Text = "Agregar";
            btnAgregarPermiso.UseVisualStyleBackColor = true;
            // 
            // lblContenidoDescripcion
            // 
            lblContenidoDescripcion.Location = new Point(268, 405);
            lblContenidoDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblContenidoDescripcion.Name = "lblContenidoDescripcion";
            lblContenidoDescripcion.Size = new Size(971, 110);
            lblContenidoDescripcion.TabIndex = 16;
            // 
            // cbxPermiso
            // 
            cbxPermiso.FormattingEnabled = true;
            cbxPermiso.Location = new Point(268, 349);
            cbxPermiso.Margin = new Padding(4, 4, 4, 4);
            cbxPermiso.Name = "cbxPermiso";
            cbxPermiso.Size = new Size(370, 33);
            cbxPermiso.TabIndex = 15;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(68, 439);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(138, 32);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(68, 529);
            lblEstatus.Margin = new Padding(4, 0, 4, 0);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(88, 32);
            lblEstatus.TabIndex = 13;
            lblEstatus.Text = "Estatus";
            // 
            // lblPermiso1
            // 
            lblPermiso1.AutoSize = true;
            lblPermiso1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermiso1.Location = new Point(68, 349);
            lblPermiso1.Margin = new Padding(4, 0, 4, 0);
            lblPermiso1.Name = "lblPermiso1";
            lblPermiso1.Size = new Size(105, 32);
            lblPermiso1.TabIndex = 12;
            lblPermiso1.Text = "Permiso ";
            // 
            // lblSeleccionaPermisos
            // 
            lblSeleccionaPermisos.AutoSize = true;
            lblSeleccionaPermisos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeleccionaPermisos.Location = new Point(51, 274);
            lblSeleccionaPermisos.Margin = new Padding(4, 0, 4, 0);
            lblSeleccionaPermisos.Name = "lblSeleccionaPermisos";
            lblSeleccionaPermisos.Size = new Size(353, 32);
            lblSeleccionaPermisos.TabIndex = 11;
            lblSeleccionaPermisos.Text = "Selecciona el permiso a agregar";
            // 
            // cbxRolAgregarPermisos
            // 
            cbxRolAgregarPermisos.FormattingEnabled = true;
            cbxRolAgregarPermisos.Location = new Point(51, 184);
            cbxRolAgregarPermisos.Margin = new Padding(4, 4, 4, 4);
            cbxRolAgregarPermisos.Name = "cbxRolAgregarPermisos";
            cbxRolAgregarPermisos.Size = new Size(1185, 33);
            cbxRolAgregarPermisos.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 129);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(582, 32);
            label4.TabIndex = 9;
            label4.Text = "Seleciona el rol al cual se le desean agregar permisos";
            // 
            // lbAgregarPermisosRol
            // 
            lbAgregarPermisosRol.AutoSize = true;
            lbAgregarPermisosRol.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarPermisosRol.Location = new Point(429, 29);
            lbAgregarPermisosRol.Margin = new Padding(4, 0, 4, 0);
            lbAgregarPermisosRol.Name = "lbAgregarPermisosRol";
            lbAgregarPermisosRol.Size = new Size(347, 45);
            lbAgregarPermisosRol.TabIndex = 0;
            lbAgregarPermisosRol.Text = "Agregar permisos a rol";
            // 
            // frmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(splitContainer1);
            Controls.Add(lblTitulo);
            BackColor = ColorTranslator.FromHtml("#E6F2F8");

            ForeColor = SystemColors.Desktop;
            Margin = new Padding(4, 4, 4, 4);
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

        private Label lblTitulo;
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