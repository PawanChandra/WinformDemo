
using WinformDemos.SignupAndDashboard;

namespace WinformDemo
{
    public partial class UserSignup : Form
    {
        public static string? Username { get; set; }
        public UserSignup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!chkDeclaration.Checked)
            {
                ShowWarning("The terms and conditions must be accepted.");
                return;
            }

            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            var confirmPassword = txtConfirmPassword.Text.Trim();

            if (!IsValidUsername(username))
                ShowWarning("Username cannot be empty and must be between 2 to 50 characters long.");
            else if (!IsValidEmail(email))
                ShowWarning("Email cannot be empty and must be a valid format.");
            else if (!IsValidPassword(password, confirmPassword))
                ShowWarning("Password cannot be empty and must be at least 8 characters long, including both uppercase and lowercase letters.");
            else
            {
                if (MessageBox.Show("Signup successfully", "Success", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Username = username;
                    Hide();
                    new UserDashboard().ShowDialog();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            chkDeclaration.Checked = false;
        }
        public bool IsValidPassword(string password, string confirmPassword)
        {
            if (password != string.Empty && confirmPassword != string.Empty && password == confirmPassword && password.Length > 8
                && password.Any(char.IsUpper) && password.Any(char.IsLower))
                return true;
            else
                return false;
        }
        public bool IsValidUsername(string username)
        {
            if (username != string.Empty && username.Length > 2 && username.Length < 50 && !username.Any(char.IsSymbol))
                return true;
            else
                return false;
        }
        public bool IsValidEmail(string email)
        {
            if ((email.EndsWith("@gmail.com") || email.EndsWith("@outlook.com") || email.EndsWith("@yahoo.com")) && email != string.Empty)
                return true;
            else
                return false;
        }
        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK);
        }

        private void linkLblLoginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }
    }
}
