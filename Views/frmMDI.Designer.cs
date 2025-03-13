namespace InvSis.Views
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            splitMDI = new SplitContainer();
            groupMDIAdm = new GroupBox();
            groupMDI1 = new GroupBox();
            btnClose = new Button();
            btnAPI = new Button();
            btnRepInv = new Button();
            btnRepAud = new Button();
            btnGesRoles = new Button();
            btnAdmUsr = new Button();
            btnAdmProd = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMDI).BeginInit();
            splitMDI.Panel1.SuspendLayout();
            splitMDI.SuspendLayout();
            groupMDI1.SuspendLayout();
            SuspendLayout();
            // 
            // splitMDI
            // 
            splitMDI.Dock = DockStyle.Fill;
            splitMDI.Location = new Point(0, 0);
            splitMDI.Name = "splitMDI";
            // 
            // splitMDI.Panel1
            // 
            splitMDI.Panel1.Controls.Add(groupMDIAdm);
            splitMDI.Panel1.Controls.Add(groupMDI1);
            // 
            // splitMDI.Panel2
            // 
            splitMDI.Panel2.AutoScroll = true;
            splitMDI.Panel2.BackColor = Color.Transparent;
            splitMDI.Panel2.BackgroundImage = Properties.Resources.inventario_e1548898364548_Photoroom;
            splitMDI.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            splitMDI.Size = new Size(1666, 781);
            splitMDI.SplitterDistance = 315;
            splitMDI.TabIndex = 0;
            // 
            // groupMDIAdm
            // 
            groupMDIAdm.Location = new Point(3, 580);
            groupMDIAdm.Name = "groupMDIAdm";
            groupMDIAdm.Size = new Size(355, 461);
            groupMDIAdm.TabIndex = 1;
            groupMDIAdm.TabStop = false;
            // 
            // groupMDI1
            // 
            groupMDI1.Controls.Add(btnClose);
            groupMDI1.Controls.Add(btnAPI);
            groupMDI1.Controls.Add(btnRepInv);
            groupMDI1.Controls.Add(btnRepAud);
            groupMDI1.Controls.Add(btnGesRoles);
            groupMDI1.Controls.Add(btnAdmUsr);
            groupMDI1.Controls.Add(btnAdmProd);
            groupMDI1.Location = new Point(3, 12);
            groupMDI1.Name = "groupMDI1";
            groupMDI1.Size = new Size(355, 562);
            groupMDI1.TabIndex = 0;
            groupMDI1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources._392517_close_delete_remove_icon;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(104, 359);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Cerrar Ventanas";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAPI
            // 
            btnAPI.Image = Properties.Resources._103289_api_icon;
            btnAPI.ImageAlign = ContentAlignment.MiddleLeft;
            btnAPI.Location = new Point(84, 302);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new Size(158, 39);
            btnAPI.TabIndex = 5;
            btnAPI.Text = "API";
            btnAPI.TextAlign = ContentAlignment.MiddleRight;
            btnAPI.UseVisualStyleBackColor = true;
            // 
            // btnRepInv
            // 
            btnRepInv.Image = Properties.Resources._4295569_bulleted_close_list_catalogue_checklist_icon;
            btnRepInv.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepInv.Location = new Point(84, 257);
            btnRepInv.Name = "btnRepInv";
            btnRepInv.Size = new Size(158, 39);
            btnRepInv.TabIndex = 4;
            btnRepInv.Text = "Reporte de Inventario";
            btnRepInv.TextAlign = ContentAlignment.MiddleRight;
            btnRepInv.UseVisualStyleBackColor = true;
            // 
            // btnRepAud
            // 
            btnRepAud.Image = Properties.Resources._9044242_cloud_auditing_icon;
            btnRepAud.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepAud.Location = new Point(84, 203);
            btnRepAud.Name = "btnRepAud";
            btnRepAud.Size = new Size(158, 39);
            btnRepAud.TabIndex = 3;
            btnRepAud.Text = "Reportes de Auditoría";
            btnRepAud.TextAlign = ContentAlignment.MiddleRight;
            btnRepAud.UseVisualStyleBackColor = true;
            btnRepAud.Click += btnRepAud_Click;
            // 
            // btnGesRoles
            // 
            btnGesRoles.Image = Properties.Resources._7352780_theater_masks_roles_artists_icon;
            btnGesRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnGesRoles.Location = new Point(84, 144);
            btnGesRoles.Name = "btnGesRoles";
            btnGesRoles.Size = new Size(158, 39);
            btnGesRoles.TabIndex = 2;
            btnGesRoles.Text = "Gestionar Roles";
            btnGesRoles.TextAlign = ContentAlignment.MiddleRight;
            btnGesRoles.UseVisualStyleBackColor = true;
            btnGesRoles.Click += btnGesRoles_Click;
            // 
            // btnAdmUsr
            // 
            btnAdmUsr.Image = Properties.Resources._4213440_community_group_leader_people_team_icon;
            btnAdmUsr.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmUsr.Location = new Point(84, 86);
            btnAdmUsr.Name = "btnAdmUsr";
            btnAdmUsr.Size = new Size(158, 39);
            btnAdmUsr.TabIndex = 1;
            btnAdmUsr.Text = "Administrar Usuarios";
            btnAdmUsr.TextAlign = ContentAlignment.MiddleRight;
            btnAdmUsr.UseVisualStyleBackColor = true;
            btnAdmUsr.Click += btnAdmUsr_Click;
            // 
            // btnAdmProd
            // 
            btnAdmProd.Image = Properties.Resources._4945342_document_documents_files_folder_format_icon__1_;
            btnAdmProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmProd.Location = new Point(84, 22);
            btnAdmProd.Name = "btnAdmProd";
            btnAdmProd.Size = new Size(158, 39);
            btnAdmProd.TabIndex = 0;
            btnAdmProd.Text = "Administrar Productos";
            btnAdmProd.TextAlign = ContentAlignment.MiddleRight;
            btnAdmProd.UseVisualStyleBackColor = true;
            btnAdmProd.Click += btnAdmProd_Click;
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 781);
            Controls.Add(splitMDI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMDI";
            Text = "Sistema de Inventarios";
            splitMDI.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMDI).EndInit();
            splitMDI.ResumeLayout(false);
            groupMDI1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMDI;
        private GroupBox groupMDIAdm;
        private GroupBox groupMDI1;
        private Button btnAdmProd;
        private Button btnAdmUsr;
        private Button btnRepAud;
        private Button btnGesRoles;
        private Button btnRepInv;
        private Button btnAPI;
        private Button btnClose;
    }
}