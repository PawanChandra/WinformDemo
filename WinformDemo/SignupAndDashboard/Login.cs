using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformDemo;

namespace WinformDemos.SignupAndDashboard
{
    public partial class Login : Form
    {
        public string username = "testuser";
        public string password = "test@321";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() !=string.Empty && txtPassword.Text.Trim() != string.Empty)
            {
                if(txtPassword.Text.Trim() == password && txtUsername.Text.Trim() == username)
                {
                    MessageBox.Show("Ohh! You guessed it right.");
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password");
            }
        }

        private void linkLblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new UserSignup().ShowDialog();
        }
    }
}
