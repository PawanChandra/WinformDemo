namespace WinformDemos.Ouath
{
    partial class OauthLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OauthLogin));
            chkRemember = new CheckBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            linkLblSignup = new LinkLabel();
            label2 = new Label();
            linkLblGoogle = new LinkLabel();
            linkLblGithub = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.BackColor = Color.Transparent;
            chkRemember.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.Black;
            chkRemember.Location = new Point(215, 256);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(129, 38);
            chkRemember.TabIndex = 7;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(336, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Javanese Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(215, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(371, 49);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Javanese Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(215, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(371, 49);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Javanese Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Window;
            btnLogin.Location = new Point(315, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(179, 53);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(286, 388);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 13;
            label1.Text = "Don't have an account ?";
            // 
            // linkLblSignup
            // 
            linkLblSignup.AutoSize = true;
            linkLblSignup.Cursor = Cursors.Hand;
            linkLblSignup.Font = new Font("Javanese Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLblSignup.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblSignup.Location = new Point(459, 383);
            linkLblSignup.Name = "linkLblSignup";
            linkLblSignup.Size = new Size(67, 38);
            linkLblSignup.TabIndex = 14;
            linkLblSignup.TabStop = true;
            linkLblSignup.Text = "Signup";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 417);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 15;
            label2.Text = "OR";
            // 
            // linkLblGoogle
            // 
            linkLblGoogle.AutoSize = true;
            linkLblGoogle.BackColor = SystemColors.Window;
            linkLblGoogle.Cursor = Cursors.Hand;
            linkLblGoogle.Font = new Font("Javanese Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblGoogle.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblGoogle.Location = new Point(286, 446);
            linkLblGoogle.Name = "linkLblGoogle";
            linkLblGoogle.Size = new Size(74, 38);
            linkLblGoogle.TabIndex = 16;
            linkLblGoogle.TabStop = true;
            linkLblGoogle.Text = "Google";
            linkLblGoogle.LinkClicked += linkLblGoogle_LinkClicked;
            // 
            // linkLblGithub
            // 
            linkLblGithub.AutoSize = true;
            linkLblGithub.BackColor = Color.Black;
            linkLblGithub.Cursor = Cursors.Hand;
            linkLblGithub.Font = new Font("Javanese Text", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblGithub.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblGithub.LinkColor = Color.White;
            linkLblGithub.Location = new Point(443, 446);
            linkLblGithub.Name = "linkLblGithub";
            linkLblGithub.Size = new Size(83, 38);
            linkLblGithub.TabIndex = 17;
            linkLblGithub.TabStop = true;
            linkLblGithub.Text = "Guithub";
            linkLblGithub.LinkClicked += linkLblGithub_LinkClicked;
            // 
            // OauthLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(linkLblGithub);
            Controls.Add(linkLblGoogle);
            Controls.Add(label2);
            Controls.Add(linkLblSignup);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(chkRemember);
            Name = "OauthLogin";
            Text = "OauthLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkRemember;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private LinkLabel linkLblSignup;
        private Label label2;
        private LinkLabel linkLblGoogle;
        private LinkLabel linkLblGithub;
    }
}