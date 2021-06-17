
namespace browsr
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.browsermain = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dockcenter = new System.Windows.Forms.Panel();
            this.url = new Guna.UI.WinForms.GunaTextBox();
            this.dockright = new System.Windows.Forms.Panel();
            this.options = new Guna.UI.WinForms.GunaImageButton();
            this.dockleft = new System.Windows.Forms.Panel();
            this.home = new Guna.UI.WinForms.GunaImageButton();
            this.refresh = new Guna.UI.WinForms.GunaImageButton();
            this.right = new Guna.UI.WinForms.GunaImageButton();
            this.left = new Guna.UI.WinForms.GunaImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resize_urlbar = new System.Windows.Forms.Timer(this.components);
            this.downloads = new Guna.UI.WinForms.GunaImageButton();
            this.panel1.SuspendLayout();
            this.dockcenter.SuspendLayout();
            this.dockright.SuspendLayout();
            this.dockleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // browsermain
            // 
            this.browsermain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browsermain.Location = new System.Drawing.Point(0, 49);
            this.browsermain.MinimumSize = new System.Drawing.Size(20, 20);
            this.browsermain.Name = "browsermain";
            this.browsermain.Size = new System.Drawing.Size(1001, 504);
            this.browsermain.TabIndex = 0;
            this.browsermain.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.browsermain.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webbrowser_update_url);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dockcenter);
            this.panel1.Controls.Add(this.dockright);
            this.panel1.Controls.Add(this.dockleft);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 49);
            this.panel1.TabIndex = 1;
            // 
            // dockcenter
            // 
            this.dockcenter.Controls.Add(this.url);
            this.dockcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockcenter.Location = new System.Drawing.Point(140, 0);
            this.dockcenter.Name = "dockcenter";
            this.dockcenter.Size = new System.Drawing.Size(800, 48);
            this.dockcenter.TabIndex = 14;
            // 
            // url
            // 
            this.url.BackColor = System.Drawing.Color.Transparent;
            this.url.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.url.BorderColor = System.Drawing.Color.Silver;
            this.url.BorderSize = 0;
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.FocusedBaseColor = System.Drawing.Color.White;
            this.url.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.url.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.url.Location = new System.Drawing.Point(2, 12);
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.Radius = 11;
            this.url.SelectedText = "";
            this.url.Size = new System.Drawing.Size(781, 26);
            this.url.TabIndex = 6;
            this.url.Text = "Type in a url here";
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.url_keys);
            // 
            // dockright
            // 
            this.dockright.BackColor = System.Drawing.Color.Transparent;
            this.dockright.Controls.Add(this.downloads);
            this.dockright.Controls.Add(this.options);
            this.dockright.Dock = System.Windows.Forms.DockStyle.Right;
            this.dockright.Location = new System.Drawing.Point(940, 0);
            this.dockright.Name = "dockright";
            this.dockright.Size = new System.Drawing.Size(61, 48);
            this.dockright.TabIndex = 13;
            // 
            // options
            // 
            this.options.DialogResult = System.Windows.Forms.DialogResult.None;
            this.options.Image = ((System.Drawing.Image)(resources.GetObject("options.Image")));
            this.options.ImageSize = new System.Drawing.Size(20, 20);
            this.options.Location = new System.Drawing.Point(33, 14);
            this.options.Name = "options";
            this.options.OnHoverImage = null;
            this.options.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.options.Size = new System.Drawing.Size(20, 20);
            this.options.TabIndex = 10;
            // 
            // dockleft
            // 
            this.dockleft.Controls.Add(this.home);
            this.dockleft.Controls.Add(this.refresh);
            this.dockleft.Controls.Add(this.right);
            this.dockleft.Controls.Add(this.left);
            this.dockleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.dockleft.Location = new System.Drawing.Point(0, 0);
            this.dockleft.Name = "dockleft";
            this.dockleft.Size = new System.Drawing.Size(140, 48);
            this.dockleft.TabIndex = 12;
            // 
            // home
            // 
            this.home.DialogResult = System.Windows.Forms.DialogResult.None;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageSize = new System.Drawing.Size(20, 20);
            this.home.Location = new System.Drawing.Point(111, 14);
            this.home.Name = "home";
            this.home.OnHoverImage = null;
            this.home.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.home.Size = new System.Drawing.Size(20, 20);
            this.home.TabIndex = 9;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // refresh
            // 
            this.refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageSize = new System.Drawing.Size(20, 20);
            this.refresh.Location = new System.Drawing.Point(82, 14);
            this.refresh.Name = "refresh";
            this.refresh.OnHoverImage = null;
            this.refresh.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.refresh.Size = new System.Drawing.Size(20, 20);
            this.refresh.TabIndex = 8;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // right
            // 
            this.right.DialogResult = System.Windows.Forms.DialogResult.None;
            this.right.Image = ((System.Drawing.Image)(resources.GetObject("right.Image")));
            this.right.ImageSize = new System.Drawing.Size(20, 20);
            this.right.Location = new System.Drawing.Point(49, 14);
            this.right.Name = "right";
            this.right.OnHoverImage = null;
            this.right.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.right.Size = new System.Drawing.Size(20, 20);
            this.right.TabIndex = 7;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.DialogResult = System.Windows.Forms.DialogResult.None;
            this.left.Image = ((System.Drawing.Image)(resources.GetObject("left.Image")));
            this.left.ImageSize = new System.Drawing.Size(20, 20);
            this.left.Location = new System.Drawing.Point(20, 14);
            this.left.Name = "left";
            this.left.OnHoverImage = null;
            this.left.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.left.Size = new System.Drawing.Size(20, 20);
            this.left.TabIndex = 0;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 1);
            this.panel2.TabIndex = 2;
            // 
            // resize_urlbar
            // 
            this.resize_urlbar.Tick += new System.EventHandler(this.resize_urlbar_Tick);
            // 
            // downloads
            // 
            this.downloads.DialogResult = System.Windows.Forms.DialogResult.None;
            this.downloads.Image = ((System.Drawing.Image)(resources.GetObject("downloads.Image")));
            this.downloads.ImageSize = new System.Drawing.Size(20, 20);
            this.downloads.Location = new System.Drawing.Point(7, 14);
            this.downloads.Name = "downloads";
            this.downloads.OnHoverImage = null;
            this.downloads.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.downloads.Size = new System.Drawing.Size(20, 20);
            this.downloads.TabIndex = 11;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.browsermain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "browsr";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.dockcenter.ResumeLayout(false);
            this.dockright.ResumeLayout(false);
            this.dockleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser browsermain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox url;
        private Guna.UI.WinForms.GunaImageButton options;
        private Guna.UI.WinForms.GunaImageButton home;
        private Guna.UI.WinForms.GunaImageButton refresh;
        private Guna.UI.WinForms.GunaImageButton right;
        private Guna.UI.WinForms.GunaImageButton left;
        private System.Windows.Forms.Panel dockleft;
        private System.Windows.Forms.Panel dockright;
        private System.Windows.Forms.Panel dockcenter;
        private System.Windows.Forms.Timer resize_urlbar;
        private Guna.UI.WinForms.GunaImageButton downloads;
    }
}