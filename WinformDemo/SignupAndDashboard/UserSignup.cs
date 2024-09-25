
namespace WinformDemo
{
    public partial class UserSignup : Form
    {
        public static string Username { get; set; }
        public UserSignup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkDeclaration.Checked == true)
            {
                if (txtUsername.Text != string.Empty)
                {
                    if (IsValidUsername(txtUsername.Text.Trim()))
                    {
                        if (IsValidPassword(txtPassword.Text.Trim(), txtConfirmPassword.Text.Trim()))
                        {
                            DialogResult result = MessageBox.Show("Sigup successfully", "Success", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                Username = txtUsername.Text;
                                this.Hide();
                                UserDashboard userDashboard = new UserDashboard();
                                userDashboard.ShowDialog();
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password can not empty and should be greater than 8 with a minimum capital and small letter.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username must be in character between 2 to 50.");
                    }
                }
                else
                {
                    MessageBox.Show("Username should not be empty");
                }
            }
            else
            {
                MessageBox.Show("Terms and conditions should be checked.");
            }
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
            if (username.Length > 2 && username.Length < 50 && !username.Any(char.IsSymbol))
                return true;
            else
                return false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            chkDeclaration.Checked = false;
        }
    }
}
