using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RexBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ResizeBrowser();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            wkbMain.Navigate("http://www.google.com");
        }

        private void wkbMain_DocumentTitleChanged(object sender, EventArgs e)
        {
            tpMain.Text = wkbMain.DocumentTitle;
            tbAddress.Text = wkbMain.Url.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wkbMain.Refresh();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeBrowser();
        }

        private void ResizeBrowser()
        {
            tcMain.Height = this.Height - msMain.Height - pnlControls.Height - 50;
        }

        private void wkbMain_NewWindowRequest(object sender, WebKit.NewWindowRequestEventArgs e)
        {
            WebBrowser wkbSecondary = new WebBrowser();
            wkbSecondary.Dock= DockStyle.Fill;
            wkbSecondary.Url = new Uri(e.Url);
            TabPage newPage = new TabPage(wkbSecondary.DocumentTitle);
            newPage.Controls.Add(wkbSecondary);
            tcMain.TabPages.Add(newPage);
        }
    }
}
