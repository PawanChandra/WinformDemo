using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemo
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            string _username=UserSignup.Username;
            if (_username == string.Empty)
            {
                this.Hide();
                UserSignup userSignup = new UserSignup();
                userSignup.ShowDialog();
            }
            lblWelcomeMessage.Visible = true;
            lblWelcomeMessage.Text = "Hi, "+_username+" welcome to the dashboard";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSignup userSignup = new UserSignup();
            userSignup.ShowDialog();
            DialogResult= DialogResult.Abort;
        }
    }
}
