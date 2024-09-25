namespace WinformDemo
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            picBoxUser = new PictureBox();
            lblWelcomeMessage = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxUser).BeginInit();
            SuspendLayout();
            // 
            // picBoxUser
            // 
            picBoxUser.Image = (Image)resources.GetObject("picBoxUser.Image");
            picBoxUser.Location = new Point(282, 70);
            picBoxUser.Name = "picBoxUser";
            picBoxUser.Size = new Size(214, 157);
            picBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxUser.TabIndex = 0;
            picBoxUser.TabStop = false;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            lblWelcomeMessage.ForeColor = SystemColors.ControlDarkDark;
            lblWelcomeMessage.Location = new Point(109, 251);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(588, 41);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Hi, Username welcome to the dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Window;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = SystemColors.Window;
            btnLogout.Location = new Point(738, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(33, 32);
            btnLogout.TabIndex = 2;
            btnLogout.Tag = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += this.btnLogout_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(picBoxUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxUser;
        private Label lblWelcomeMessage;
        private Button btnLogout;
    }
}