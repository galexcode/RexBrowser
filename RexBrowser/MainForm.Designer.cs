namespace RexBrowser
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.wkbMain = new WebKit.WebKitBrowser();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.msMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(562, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "msMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.helloToolStripMenuItem.Text = "Hello";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.wkbMain);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(554, 327);
            this.tpMain.TabIndex = 0;
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // wkbMain
            // 
            this.wkbMain.BackColor = System.Drawing.Color.White;
            this.wkbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wkbMain.Location = new System.Drawing.Point(3, 3);
            this.wkbMain.Name = "wkbMain";
            this.wkbMain.Size = new System.Drawing.Size(548, 321);
            this.wkbMain.TabIndex = 0;
            this.wkbMain.Url = null;
            this.wkbMain.DocumentTitleChanged += new System.EventHandler(this.wkbMain_DocumentTitleChanged);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcMain.Location = new System.Drawing.Point(0, 109);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(562, 353);
            this.tcMain.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(151, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 462);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "RexBrowser";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tpMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpMain;
        private WebKit.WebKitBrowser wkbMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.Button btnRefresh;
    }
}

