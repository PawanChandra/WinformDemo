namespace WinformDemos.Ouath
{
    partial class OauthLoginWithWebView
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
            webViewOauth = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewOauth).BeginInit();
            SuspendLayout();
            // 
            // webViewOauth
            // 
            webViewOauth.AllowExternalDrop = true;
            webViewOauth.CreationProperties = null;
            webViewOauth.DefaultBackgroundColor = Color.White;
            webViewOauth.Location = new Point(1, 1);
            webViewOauth.Name = "webViewOauth";
            webViewOauth.Size = new Size(800, 452);
            webViewOauth.TabIndex = 0;
            webViewOauth.ZoomFactor = 1D;
            // 
            // OauthLoginWithWebView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webViewOauth);
            Name = "OauthLoginWithWebView";
            Text = "OauthLoginWithWebView";
            ((System.ComponentModel.ISupportInitialize)webViewOauth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewOauth;
    }
}