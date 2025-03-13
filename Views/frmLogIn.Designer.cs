namespace InvSis.Views
{
    partial class frmLogIn
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
            lbUsuario = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            pictureBoxAvatar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI", 12F);
            lbUsuario.Location = new Point(223, 86);
            lbUsuario.Margin = new Padding(2, 0, 2, 0);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(64, 21);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(223, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(333, 88);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.MaxLength = 25;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(333, 118);
            txtContraseña.Margin = new Padding(2);
            txtContraseña.MaxLength = 20;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(155, 23);
            txtContraseña.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(400, 148);
            btnIniciarSesion.Margin = new Padding(2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(88, 20);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.BackColor = SystemColors.Control;
            pictureBoxAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAvatar.Image = Properties.Resources._6372974_account_avatar_log_in_login_register_icon1;
            pictureBoxAvatar.Location = new Point(60, 61);
            pictureBoxAvatar.Margin = new Padding(2);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(130, 128);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 5;
            pictureBoxAvatar.TabStop = false;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 266);
            Controls.Add(pictureBoxAvatar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(lbUsuario);
            Margin = new Padding(2);
            Name = "frmLogIn";
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsuario;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIniciarSesion;
        private PictureBox pictureBoxAvatar;
    }
}