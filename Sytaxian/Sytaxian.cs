using CefSharp.WinForms;
using CefSharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Sytaxian.Properties;

namespace Sytaxian
{

    public partial class Sytaxian : Form
    {
        ChromiumWebBrowser browser;
        NetworkManagement networkManagement = new NetworkManagement();
        WebClient client = new WebClient();
        public Sytaxian()
        {
            InitializeComponent();
        }
        private void Sytaxian_Load(object sender, EventArgs e)
        {

            CefSettings settings = new CefSettings();
            BrowserSettings browserSettings = new BrowserSettings();
            browser = new ChromiumWebBrowser("https://search.brave.com/");
            browser.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(browser);
            browser.MenuHandler = new CustomMenuHandler();
            browserSettings.Javascript = CefState.Enabled;
            browserSettings.JavascriptDomPaste = CefState.Enabled;
            browser.LifeSpanHandler = new CustomLifeSpanHandler();
            browser.DownloadHandler = new CustomDownloadHandler();
            //Add Events
            browser.TitleChanged += chromeBrowser_TitleChanged;
            browser.LoadError += Browser_LoadError;
            //Setting Check
            UrlTextbx.Focus();
            if (Properties.Settings.Default.Firstboot == 0)
            {
                networkManagement.SetDNS("94.140.14.14");
                Properties.Settings.Default.Firstboot = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void Browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            if(!e.ErrorText.ToString().EndsWith("ERR_ABORTED"))
            {
                browser.LoadHtml(Resources.Loaderror);
            }
        }

        private void chromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                if (browser.Address.StartsWith("https"))
                {
                    SP.Image = Resources.windows_defender_48px;
                }
                else
                {
                    SP.Image = Resources.warning_shield_48px;
                }
                Text = e.Title;
                if (browser.Address == "https://search.brave.com/")
                {
                   Text = "New Tab";
                }
                else
                {
                    UrlTextbx.Text = browser.Address.Replace("https://www.", "");
                    favicon();
                }
                if (browser.CanGoBack == true)
                {
                    back.Enabled = true;
                }
                else if (browser.CanGoBack == false) 
                {
                    back.Enabled = false;
                }
                if (browser.CanGoForward == true)
                {
                    forward.Enabled = true;
                }
                else if (browser.CanGoForward == false)
                {
                    forward.Enabled = false;
                }
            });
        }

        public void favicon()
        {
            try
            {
                Icon img = new Icon(new MemoryStream(client.DownloadData(browser.Address + "/favicon.ico")));
                Icon = img;
                back.Focus();
                img.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void UrlTextbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (UrlTextbx.Text != "")
                {
                    RemoveFocus.Focus();
                    if (UrlTextbx.Text.Contains("."))
                    {
                        browser.Load(UrlTextbx.Text);
                    }
                    else if (UrlTextbx.Text.Contains(""))
                    {
                        browser.Load(Properties.Settings.Default.SearchEngine + UrlTextbx.Text);
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack == true)
            {
                browser.Back();
                favicon();
            }
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward == true)
            {
                browser.Forward();
                favicon();
            }
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.ShowDialog();
        }
    }
}
