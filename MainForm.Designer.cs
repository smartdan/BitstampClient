namespace Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerLoader = new System.Windows.Forms.Timer(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quotationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buySellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageMarkets = new System.Windows.Forms.TabPage();
            this.pictureBoxCandles = new System.Windows.Forms.PictureBox();
            this.webBrowserCharts = new System.Windows.Forms.WebBrowser();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.webBrowserOrders = new System.Windows.Forms.WebBrowser();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.webBrowserTransactions = new System.Windows.Forms.WebBrowser();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDeepOrders = new System.Windows.Forms.TabPage();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.pictureBoxDeepOrders = new System.Windows.Forms.PictureBox();
            this.labelTick = new System.Windows.Forms.Label();
            this.timerTicker = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPageMarkets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandles)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDeepOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeepOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoader
            // 
            this.timerLoader.Interval = 15000;
            this.timerLoader.Tick += new System.EventHandler(this.timerLoader_Tick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // quotationsToolStripMenuItem
            // 
            this.quotationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketsToolStripMenuItem,
            this.transactionsCSVToolStripMenuItem});
            this.quotationsToolStripMenuItem.Name = "quotationsToolStripMenuItem";
            this.quotationsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.quotationsToolStripMenuItem.Text = "Data";
            // 
            // marketsToolStripMenuItem
            // 
            this.marketsToolStripMenuItem.Name = "marketsToolStripMenuItem";
            this.marketsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.marketsToolStripMenuItem.Text = "Markets";
            this.marketsToolStripMenuItem.Click += new System.EventHandler(this.marketsToolStripMenuItem_Click);
            // 
            // transactionsCSVToolStripMenuItem
            // 
            this.transactionsCSVToolStripMenuItem.Name = "transactionsCSVToolStripMenuItem";
            this.transactionsCSVToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.transactionsCSVToolStripMenuItem.Text = "Transactions CSV";
            this.transactionsCSVToolStripMenuItem.Click += new System.EventHandler(this.transactionsCSVToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tickerToolStripMenuItem,
            this.bSOrderToolStripMenuItem,
            this.bSAccountToolStripMenuItem,
            this.buySellToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // tickerToolStripMenuItem
            // 
            this.tickerToolStripMenuItem.Name = "tickerToolStripMenuItem";
            this.tickerToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.tickerToolStripMenuItem.Text = "Ticker";
            this.tickerToolStripMenuItem.Click += new System.EventHandler(this.tickerToolStripMenuItem_Click);
            // 
            // bSOrderToolStripMenuItem
            // 
            this.bSOrderToolStripMenuItem.Name = "bSOrderToolStripMenuItem";
            this.bSOrderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bSOrderToolStripMenuItem.Text = "BS Order";
            this.bSOrderToolStripMenuItem.Click += new System.EventHandler(this.bSOrderToolStripMenuItem_Click);
            // 
            // bSAccountToolStripMenuItem
            // 
            this.bSAccountToolStripMenuItem.Name = "bSAccountToolStripMenuItem";
            this.bSAccountToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.bSAccountToolStripMenuItem.Text = "BS Account";
            this.bSAccountToolStripMenuItem.Click += new System.EventHandler(this.bSAccountToolStripMenuItem_Click);
            // 
            // buySellToolStripMenuItem
            // 
            this.buySellToolStripMenuItem.Enabled = false;
            this.buySellToolStripMenuItem.Name = "buySellToolStripMenuItem";
            this.buySellToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.buySellToolStripMenuItem.Text = "BuySell";
            this.buySellToolStripMenuItem.Click += new System.EventHandler(this.buySellToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LawnGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.quotationsToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(726, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Toggle data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageMarkets
            // 
            this.tabPageMarkets.Controls.Add(this.pictureBoxCandles);
            this.tabPageMarkets.Controls.Add(this.webBrowserCharts);
            this.tabPageMarkets.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarkets.Name = "tabPageMarkets";
            this.tabPageMarkets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkets.Size = new System.Drawing.Size(860, 503);
            this.tabPageMarkets.TabIndex = 3;
            this.tabPageMarkets.Text = "Market 15 Min";
            this.tabPageMarkets.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCandles
            // 
            this.pictureBoxCandles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCandles.ImageLocation = "http://bitcoincharts.com/charts/chart.png?width=940&m=bitstampUSD&SubmitButton=Dr" +
    "aw&r=1&i=&c=0&s=&e=&Prev=&Next=&t=S&b=&a1=&m1=10&a2=&m2=25&x=0&i1=&i2=&i3=&i4=&v" +
    "=1&cv=0&ps=0&l=0&p=0&";
            this.pictureBoxCandles.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCandles.Name = "pictureBoxCandles";
            this.pictureBoxCandles.Size = new System.Drawing.Size(854, 497);
            this.pictureBoxCandles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCandles.TabIndex = 2;
            this.pictureBoxCandles.TabStop = false;
            // 
            // webBrowserCharts
            // 
            this.webBrowserCharts.Location = new System.Drawing.Point(3, 175);
            this.webBrowserCharts.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCharts.Name = "webBrowserCharts";
            this.webBrowserCharts.ScriptErrorsSuppressed = true;
            this.webBrowserCharts.Size = new System.Drawing.Size(343, 199);
            this.webBrowserCharts.TabIndex = 0;
            this.webBrowserCharts.Url = new System.Uri("http://bitcoincharts.com/markets/bitstampUSD.html", System.UriKind.Absolute);
            this.webBrowserCharts.Visible = false;
            this.webBrowserCharts.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserCharts_DocumentCompleted);
            this.webBrowserCharts.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserCharts_Navigating);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.webBrowserOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(860, 503);
            this.tabPageOrders.TabIndex = 2;
            this.tabPageOrders.Text = "Recent orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // webBrowserOrders
            // 
            this.webBrowserOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserOrders.Location = new System.Drawing.Point(3, 3);
            this.webBrowserOrders.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserOrders.Name = "webBrowserOrders";
            this.webBrowserOrders.ScriptErrorsSuppressed = true;
            this.webBrowserOrders.ScrollBarsEnabled = false;
            this.webBrowserOrders.Size = new System.Drawing.Size(854, 497);
            this.webBrowserOrders.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.webBrowserTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransactions.Size = new System.Drawing.Size(860, 503);
            this.tabPageTransactions.TabIndex = 0;
            this.tabPageTransactions.Text = "Recent transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // webBrowserTransactions
            // 
            this.webBrowserTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserTransactions.Location = new System.Drawing.Point(3, 3);
            this.webBrowserTransactions.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTransactions.Name = "webBrowserTransactions";
            this.webBrowserTransactions.ScrollBarsEnabled = false;
            this.webBrowserTransactions.Size = new System.Drawing.Size(854, 497);
            this.webBrowserTransactions.TabIndex = 3;
            this.webBrowserTransactions.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMarkets);
            this.tabControlMain.Controls.Add(this.tabPageDeepOrders);
            this.tabControlMain.Controls.Add(this.tabPageTransactions);
            this.tabControlMain.Controls.Add(this.tabPageOrders);
            this.tabControlMain.Location = new System.Drawing.Point(12, 52);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(868, 559);
            this.tabControlMain.TabIndex = 4;
            // 
            // tabPageDeepOrders
            // 
            this.tabPageDeepOrders.Controls.Add(this.pictureBoxBook);
            this.tabPageDeepOrders.Controls.Add(this.pictureBoxDeepOrders);
            this.tabPageDeepOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeepOrders.Name = "tabPageDeepOrders";
            this.tabPageDeepOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeepOrders.Size = new System.Drawing.Size(860, 533);
            this.tabPageDeepOrders.TabIndex = 4;
            this.tabPageDeepOrders.Text = "Deep orders 15 Min";
            this.tabPageDeepOrders.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBook.ImageLocation = "http://bitcoincharts.com/charts/bitstampUSD/orderbook.png";
            this.pictureBoxBook.Location = new System.Drawing.Point(6, 237);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(854, 293);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBook.TabIndex = 3;
            this.pictureBoxBook.TabStop = false;
            // 
            // pictureBoxDeepOrders
            // 
            this.pictureBoxDeepOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDeepOrders.ImageLocation = "http://bitcoincharts.com/charts/bitstampUSD/accumulated_orderbook.png";
            this.pictureBoxDeepOrders.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxDeepOrders.Name = "pictureBoxDeepOrders";
            this.pictureBoxDeepOrders.Size = new System.Drawing.Size(851, 255);
            this.pictureBoxDeepOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeepOrders.TabIndex = 2;
            this.pictureBoxDeepOrders.TabStop = false;
            // 
            // labelTick
            // 
            this.labelTick.AutoSize = true;
            this.labelTick.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTick.Location = new System.Drawing.Point(12, 31);
            this.labelTick.Name = "labelTick";
            this.labelTick.Size = new System.Drawing.Size(27, 15);
            this.labelTick.TabIndex = 5;
            this.labelTick.Text = "Tick";
            this.labelTick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTick.Click += new System.EventHandler(this.labelTick_Click);
            // 
            // timerTicker
            // 
            this.timerTicker.Tick += new System.EventHandler(this.timerTicker_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(885, 656);
            this.Controls.Add(this.labelTick);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageMarkets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandles)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageTransactions.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDeepOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeepOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLoader;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quotationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buySellToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageMarkets;
        private System.Windows.Forms.WebBrowser webBrowserCharts;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.WebBrowser webBrowserOrders;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.WebBrowser webBrowserTransactions;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Label labelTick;
        private System.Windows.Forms.ToolStripMenuItem bSOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timerTicker;
        private System.Windows.Forms.PictureBox pictureBoxCandles;
        private System.Windows.Forms.TabPage tabPageDeepOrders;
        private System.Windows.Forms.PictureBox pictureBoxDeepOrders;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.ToolStripMenuItem tickerToolStripMenuItem;
    }
}

