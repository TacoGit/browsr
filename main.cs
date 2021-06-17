using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;

namespace browsr
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void resize_urlbar_Tick(object sender, EventArgs e)
        {
            Task.Delay(1000);

            string urlSize = url.Size
                .ToString()
                .ToLower()
                .Replace("{", "")
                .Replace("}", "")
                .Replace(",", "")
                .Replace("width", "")
                .Replace("=", "")
                .Replace("height", "");

            // Width + Height
            var width = Int32.Parse(Regex.Match(urlSize, @"^([\w\-]+)").ToString());
            var height = Int32.Parse(urlSize.Split(' ')[1].ToString());

            var parentpanel = dockcenter.Size.ToString()
                .ToLower()
                .Replace("{", "")
                .Replace("}", "")
                .Replace(",", "")
                .Replace("width", "")
                .Replace("=", "")
                .Replace("height", "");

            var parentpanelwidth = Int32.Parse(Regex.Match(parentpanel, @"^([\w\-]+)").ToString());

            url.Size = new Size(parentpanelwidth - 1, height);
        }

        private void main_Load(object sender, EventArgs e)
        {
            browsermain.ScriptErrorsSuppressed = true;
            resize_urlbar.Start();
            if (!Directory.Exists("cache"))
            {
                Directory.CreateDirectory("cache");
            }
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", AppDomain.CurrentDomain.FriendlyName, 11000);
            Thread.Sleep(1000);
        }

        private void url_keys(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                browsermain.Navigate(url.Text.ToString());
            }
        }

        private void home_Click(object sender, EventArgs e) { browsermain.Navigate("https://google.com"); }
        private void refresh_Click(object sender, EventArgs e) { browsermain.Refresh(); }
        private void webbrowser_update_url(object sender, WebBrowserNavigatedEventArgs e) { url.Text = browsermain.Url.ToString(); }
        private void left_Click(object sender, EventArgs e) { browsermain.GoBack(); }
        private void right_Click(object sender, EventArgs e) { browsermain.GoForward(); }
    }
}
