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

        private void btnTest_Click(object sender, EventArgs e)
        {
            wkbMain.Navigate("http://www.google.com");
        }

        private void wkbMain_DocumentTitleChanged(object sender, EventArgs e)
        {
            tpMain.Text = wkbMain.DocumentTitle;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            wkbMain.Refresh();
        }
    }
}
