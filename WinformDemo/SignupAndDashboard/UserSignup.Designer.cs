namespace WinformDemo
{
    partial class UserSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignup));
            lblSignUp = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblPassword = new Label();
            lblCPassword = new Label();
            chkDeclaration = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            linkLblLoginHere = new LinkLabel();
            SuspendLayout();
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.BackColor = Color.Transparent;
            lblSignUp.Font = new Font("Impact", 25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = SystemColors.MenuHighlight;
            lblSignUp.Location = new Point(439, 23);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(144, 52);
            lblSignUp.TabIndex = 0;
            lblSignUp.Text = "SignUp";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MediumPurple;
            lblUsername.Location = new Point(323, 124);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(114, 29);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MediumPurple;
            lblEmail.Location = new Point(323, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 29);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(519, 114);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(377, 34);
            txtUsername.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(519, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(377, 34);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(519, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(377, 34);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(519, 282);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(377, 34);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MediumPurple;
            lblPassword.Location = new Point(323, 234);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(107, 29);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // lblCPassword
            // 
            lblCPassword.AutoSize = true;
            lblCPassword.BackColor = Color.Transparent;
            lblCPassword.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCPassword.ForeColor = Color.MediumPurple;
            lblCPassword.Location = new Point(323, 287);
            lblCPassword.Name = "lblCPassword";
            lblCPassword.Size = new Size(190, 29);
            lblCPassword.TabIndex = 8;
            lblCPassword.Text = "Confirm Password";
            // 
            // chkDeclaration
            // 
            chkDeclaration.AutoSize = true;
            chkDeclaration.BackColor = Color.Transparent;
            chkDeclaration.Cursor = Cursors.Hand;
            chkDeclaration.Font = new Font("Impact", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDeclaration.ForeColor = Color.MediumPurple;
            chkDeclaration.Location = new Point(519, 335);
            chkDeclaration.Name = "chkDeclaration";
            chkDeclaration.Size = new Size(409, 21);
            chkDeclaration.TabIndex = 9;
            chkDeclaration.Text = "I acknowledge that I have read and agree to the Terms and Conditions.";
            chkDeclaration.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumPurple;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Impact", 14F);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(519, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 47);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Tomato;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Impact", 14F);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(680, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 47);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Clear";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(523, 472);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 12;
            label1.Text = "Already have an account ?";
            // 
            // linkLblLoginHere
            // 
            linkLblLoginHere.AutoSize = true;
            linkLblLoginHere.BackColor = Color.Transparent;
            linkLblLoginHere.Cursor = Cursors.Hand;
            linkLblLoginHere.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLblLoginHere.ForeColor = Color.MediumPurple;
            linkLblLoginHere.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblLoginHere.LinkColor = Color.MediumPurple;
            linkLblLoginHere.Location = new Point(718, 472);
            linkLblLoginHere.Name = "linkLblLoginHere";
            linkLblLoginHere.Size = new Size(43, 19);
            linkLblLoginHere.TabIndex = 13;
            linkLblLoginHere.TabStop = true;
            linkLblLoginHere.Text = "Login";
            linkLblLoginHere.VisitedLinkColor = Color.Transparent;
            linkLblLoginHere.LinkClicked += linkLblLoginHere_LinkClicked;
            // 
            // UserSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1028, 528);
            Controls.Add(linkLblLoginHere);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkDeclaration);
            Controls.Add(lblCPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblSignUp);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserSignup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignUp;
        private Label lblUsername;
        private Label lblEmail;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label lblPassword;
        private Label lblCPassword;
        private CheckBox chkDeclaration;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private LinkLabel linkLblLoginHere;
    }
}