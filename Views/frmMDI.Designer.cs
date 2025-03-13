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
            groupMDI1 = new GroupBox();
            groupMDIAdm = new GroupBox();
            btnAdmProd = new Button();
            btnAdmUsr = new Button();
            btnGesRoles = new Button();
            btnRepAud = new Button();
            btnRepInv = new Button();
            btnAPI = new Button();
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
            splitMDI.Size = new Size(1904, 1041);
            splitMDI.SplitterDistance = 361;
            splitMDI.TabIndex = 0;
            // 
            // groupMDI1
            // 
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
            // groupMDIAdm
            // 
            groupMDIAdm.Location = new Point(3, 580);
            groupMDIAdm.Name = "groupMDIAdm";
            groupMDIAdm.Size = new Size(355, 461);
            groupMDIAdm.TabIndex = 1;
            groupMDIAdm.TabStop = false;
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
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(splitMDI);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}