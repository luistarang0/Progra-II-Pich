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
            ((System.ComponentModel.ISupportInitialize)splitMDI).BeginInit();
            splitMDI.Panel1.SuspendLayout();
            splitMDI.SuspendLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMDI;
        private GroupBox groupMDIAdm;
        private GroupBox groupMDI1;
    }
}