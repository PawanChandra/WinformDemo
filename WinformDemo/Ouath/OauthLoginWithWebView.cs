using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
using WinformDemos.Helper;

namespace WinformDemos.Ouath
{
    public partial class OauthLoginWithWebView : Form
    {
        private bool isAuthtenticated = false;
        public OauthLoginWithWebView(string authUrl)
        {
            InitializeComponent();
            OpenWebView(authUrl);
        }

        private async void OpenWebView(string authUrl)
        {
            var environment = await CoreWebView2Environment.CreateAsync(null, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WebView2UserData"));

            await webViewOauth.EnsureCoreWebView2Async(environment);
            webViewOauth.CoreWebView2.Navigate(authUrl);
            webViewOauth.CoreWebView2.NavigationCompleted += CoreWebView2_NavigationCompleted;
        }

        private void CoreWebView2_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            webViewOauth.CoreWebView2
                .ExecuteScriptAsync(@"
                 var reloadUrl=window.loadTimeDataRow.reloadButton.reloadUrl;
                 window.chrome.webview.postMessage(reloadUrl);
                 ");
            webViewOauth.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void CoreWebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            if (isAuthtenticated)
                return;
            string reloadUrl = e.Source;
            if (reloadUrl != null)
            {
                GetAuthenticationToken(reloadUrl);
            }
        }

        private async void GetAuthenticationToken(string url)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var fragment = new Uri(url).Fragment;
                if (!fragment.StartsWith("#"))
                {
                    Uri uriCode = new Uri(url);
                    string queryString = uriCode.Query;
                    var queryParameters = HttpUtility.ParseQueryString(queryString);
                    string code = queryParameters["code"];
                    string scope = queryParameters["scope"];

                    HttpClient httpClient = new HttpClient();

                    if (code != string.Empty && scope != string.Empty)
                    {
                        var rquestDataForToken = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<string, string>("client_id",DefaultValues.GoogleClientId),
                            new KeyValuePair<string, string>("client_secret",DefaultValues.GoogleClientSecret),
                            new KeyValuePair<string, string>("redirect_uri",DefaultValues.GoogleRedirectUri),
                            new KeyValuePair<string, string>("code",code),
                            new KeyValuePair<string, string>("grant_type","authorization_code"),
                        });

                        var googleApiResponse = await httpClient.PostAsync(DefaultValues.GoogleTokenUri, rquestDataForToken);
                        if (googleApiResponse.IsSuccessStatusCode)
                        {
                            var responseContent=await googleApiResponse.Content.ReadAsStringAsync();

                            var response=JsonConvert.DeserializeObject<Dictionary<string,string>>(responseContent);
                            if(response.TryGetValue("access_token",out var accessToken))
                            {
                                isAuthtenticated = true;
                                string _username =await GetGoogleUserProfile(accessToken);
                            }
                            else
                            {
                                MessageBox.Show("Token not returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetGoogleUserProfile(string accessToken)
        {
            string username = string.Empty;
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",accessToken);
                var googleUserResponse = await httpClient.GetAsync(DefaultValues.GoogleUserInfoUri);
                if(googleUserResponse.IsSuccessStatusCode)
                {
                    var userInfoString=await googleUserResponse.Content.ReadAsStringAsync();
                    var userInfo=JsonConvert.DeserializeObject<dynamic>(userInfoString);

                    username = userInfo.Name;
                    string email = userInfo.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return username;
        }
    }
}
