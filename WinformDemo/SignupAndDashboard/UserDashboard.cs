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
            string? username = UserSignup.Username;
            if (string.IsNullOrEmpty(username))
            {
                OpenUserSignup();
                return;
            }

            lblWelcomeMessage.Visible = true;
            lblWelcomeMessage.Text = $"Hi, {username} welcome to the dashboard";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenUserSignup();
        }

        private void OpenUserSignup()
        {
            Hide();
            new UserSignup().ShowDialog();
        }
    }
}
