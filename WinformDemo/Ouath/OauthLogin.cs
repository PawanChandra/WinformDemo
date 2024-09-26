using WinformDemos.Helper;

namespace WinformDemos.Ouath
{
    public partial class OauthLogin : Form
    {
        public OauthLogin()
        {
            InitializeComponent();
        }

        private void linkLblGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string authUri = DefaultValues.GoogleAuthUri+DefaultValues.GoogleRedirectUri +"&client_id="+DefaultValues.GoogleClientId ;
            OauthLoginWithWebView oauthLogin = new OauthLoginWithWebView(authUri);
            oauthLogin.FormClosed += (s, args) =>
            {
                MessageBox.Show("Oauth Login Success");
            };
            oauthLogin.ShowDialog();
        }

        private void linkLblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            return;
        }
    }
}
