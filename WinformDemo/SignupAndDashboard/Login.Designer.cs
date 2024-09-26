namespace WinformDemos.SignupAndDashboard
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            chkRemember = new CheckBox();
            pictureBox2 = new PictureBox();
            linkLblSignup = new LinkLabel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Javanese Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(184, 151);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(371, 49);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Javanese Text", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(184, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(371, 49);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Javanese Text", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(184, 349);
            button1.Name = "button1";
            button1.Size = new Size(129, 53);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.BackColor = Color.Transparent;
            chkRemember.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRemember.ForeColor = Color.Black;
            chkRemember.Location = new Point(184, 290);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(129, 38);
            chkRemember.TabIndex = 6;
            chkRemember.Text = "Remember me";
            chkRemember.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(303, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // linkLblSignup
            // 
            linkLblSignup.AutoSize = true;
            linkLblSignup.Cursor = Cursors.Hand;
            linkLblSignup.Font = new Font("Javanese Text", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLblSignup.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblSignup.Location = new Point(356, 416);
            linkLblSignup.Name = "linkLblSignup";
            linkLblSignup.Size = new Size(67, 38);
            linkLblSignup.TabIndex = 9;
            linkLblSignup.TabStop = true;
            linkLblSignup.Text = "Signup";
            linkLblSignup.LinkClicked += linkLblSignup_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(191, 422);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account ?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(698, 474);
            Controls.Add(label1);
            Controls.Add(linkLblSignup);
            Controls.Add(pictureBox2);
            Controls.Add(chkRemember);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            ForeColor = SystemColors.Window;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private CheckBox chkRemember;
        private PictureBox pictureBox2;
        private LinkLabel linkLblSignup;
        private Label label1;
    }
}