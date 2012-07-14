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
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            wkbMain.Navigate("http://www.google.com");
        }

        private void wkbMain_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = wkbMain.DocumentTitle;
            tbAddress.Text = wkbMain.Url.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wkbMain.Refresh();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text.IndexOf("http://") == -1)
                tbAddress.Text = "http://" + tbAddress.Text;
            wkbMain.Url = new Uri(tbAddress.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
