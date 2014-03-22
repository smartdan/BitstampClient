using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoProxy;
using System.Diagnostics;
using System.Threading;
using InfoProxy.Charts;
using InfoProxy.UserData;
using BtcTick;


namespace Client
{
    public partial class MainForm : Form
    {
        public bool _loaderEnabled { get; set; }
        public BuySellForm _buySellFrm;
        private object locker = new object();
        private UserData _user;
        private bool _loading = false;
        private bool _started = false;
        private bool _loggedIn = false;
        private TickForm _ticker = null;

        public MainForm()
        {
            InitializeComponent();
            _loaderEnabled = false;
            this.button1.Enabled = true;
            this.button1.BackColor = Color.Gray;
            this.button1.Text = "Start polling";
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.SizeChanged += new EventHandler(MainForm_SizeChanged);

            this.labelTick.Text = "Initializing...";
            this.Enabled = false;
        }

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            GetData();
        }

        // Events
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerLoader.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TogglePull();
        }
        private void timerLoader_Tick(object sender, EventArgs e)
        {
            GetDataAsync();
        }
        private void buySellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_buySellFrm == null)
            {
                _buySellFrm = new BuySellForm();
                _buySellFrm.FormClosed += new FormClosedEventHandler(_buySellFrm_FormClosed);
            }
            _buySellFrm.UserData = _user;
            _buySellFrm.Show();
        }

        void _buySellFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _buySellFrm.FormClosed -= new FormClosedEventHandler(_buySellFrm_FormClosed);
            _buySellFrm.Dispose();
            _buySellFrm = null;
        }

        private void webBrowserCharts_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }
        private void webBrowserCharts_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (_started == false)
            {
                TogglePull();
                this.button1.Enabled = true;
                //this.timerTicker.Start();
                _started = true;
                this.Enabled = true;
            }
        }

        private void GetDataAsync()
        {
            var thread = new Thread(() =>
            {
                GetData();
            });

            thread.Start();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_loggedIn)
            {
                var login = new LoginForm();
                if (login.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _user = login.UserData;
                    this.buySellToolStripMenuItem.Enabled = true;
                    _loggedIn = true;
                    this.loginToolStripMenuItem.Text = "Logout";
                }
            }
            else
            {
                _loggedIn = false;
                _user = null;
                this.buySellToolStripMenuItem.Enabled = false;
                this.loginToolStripMenuItem.Text = "Login";
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new About();
            aboutForm.ShowDialog();
        }

        // Pull data
        private void TogglePull()
        {
            if (_loaderEnabled)
            {
                timerLoader.Stop();

                this.Invoke(new Action(() =>
                {
                    this.button1.BackColor = Color.Gray;
                    this.button1.Text = "Start polling";
                }));
            }
            else
            {
                timerLoader.Start();

                this.Invoke(new Action(() =>
                {
                    this.button1.BackColor = Color.Lime;
                    this.button1.Text = "Polling...";
                }));

                GetData();
            }

            _loaderEnabled = !_loaderEnabled;
        }
        private void GetData()
        {
            try
            {
                if (_loading)
                {
                    return;
                }

                lock (locker)
                {
                    _loading = true;

                    var chart = "";
                    var arrowchart = "";
                    var gaugechart = "";
                    var chartorders = "";
                    var tickdescription = "";
                    // Information data
                    var market = SingleInstance.The.Market;

                    var tick = market.GetTick();
                    var transactions = market.GetTransaction(300);

                    if (transactions != null && transactions.Count > 0)
                    {
                        chart = ChartUtils.GetTransactionsChart(transactions);
                    }

                    if (tick != null && tick.last != null)
                    {
                        tickdescription = tick.ToString();

                        arrowchart = ChartUtils.GetArrowChart(tick);
                        //this.webBrowserTick.DocumentText = arrowchart;

                        gaugechart = ChartUtils.GetGaugeChart(tick);

                        var orders = market.GetOrderBook();
                        if (orders != null)
                        {
                            //AUTO TRADING PARAMETERS
                            bool toBuy = false;
                            bool toSell = false;

                            market.EvaluateBook(orders, out toBuy, out toSell);

                            chartorders = ChartUtils.GetOrdersChart(orders, tick);
                        }

                        this.Invoke(new Action(() =>
                        {
                            try
                            {
                                SuspendLayout();
                                webBrowserTransactions.DocumentText = chart;
                                
                                //progressBar1.Minimum = (int)double.Parse(tick.low);
                                //progressBar1.Maximum = (int)double.Parse(tick.high);
                                //progressBar1.Value = (int)double.Parse(tick.last);

                                //webBrowserGauge.DocumentText = gaugechart;
                                webBrowserOrders.DocumentText = chartorders;
                                labelTick.Text = tickdescription;

                                pictureBoxBook.LoadAsync();
                                pictureBoxCandles.LoadAsync();
                                pictureBoxDeepOrders.LoadAsync();

                                ResumeLayout();
                            }
                            catch (Exception exc)
                            {
                                SingleInstance.Log.Debug(exc.Message);
                                this.ResumeLayout();
                            }
                        }));
                    }
                    else
                    {
                        labelTick.Text = "Connection error " + DateTime.Now.ToString();
                    }

                    _loading = false;
                }                
            }
            catch (Exception exc)
            {
                SingleInstance.Log.Debug(exc.Message);
            }
        }

        #region Web

        private void bSOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bitstamp.net/market/order_book/");
        }
        private void bSAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.bitstamp.net/account/login/?next=/market/order/instant/");
        }
        private void marketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://bitcoincharts.com/markets/bitstampUSD.html");
        }
        private void transactionsCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //http://bitcoincharts.com/markets/bitstampUSD.html
            //http://bitcoincharts.com/markets/bitstampUSD_trades.html
            //http://bitcoincharts.com/markets/bitstampUSD_depth.html
            //http://api.bitcoincharts.com/v1/csv/bitstampUSD.csv
            //http://api.bitcoincharts.com/v1/trades.csv?symbol=bitstampUSD
            //http://api.bitcoincharts.com/v1/markets.json
            //http://api.bitcoincharts.com/v1/weighted_prices.json
            Process.Start("http://api.bitcoincharts.com/v1/csv/bitstampUSD.csv");
        }

        #endregion



        //your trigger :timer1.Start();
        private void timerTicker_Tick(object sender, EventArgs e)
        {
            //labelTick.Location = new Point(labelTick.Location.X + 5, labelTick.Location.Y);

            //if (labelTick.Location.X > this.Width)
            //{
            //    labelTick.Location = new Point(12, labelTick.Location.Y);
            //}
        }

        private void labelTick_Click(object sender, EventArgs e)
        {
            //if (timerTicker.Enabled)
            //{
            //    timerTicker.Stop();
            //}
            //else { timerTicker.Start(); }
        }


        private void buttonUpd_Click(object sender, EventArgs e)
        {
            var market = SingleInstance.The.Market;
            var tick = market.GetTick();
            
            // var list = new List<string>() { tick.last };
           // var ret = this.webBrowserGauge.Document.InvokeScript("updateChart", list.ToArray());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_ticker == null)
            {
                _ticker = new TickForm();
                _ticker.Show();
                _ticker.FormClosed += new FormClosedEventHandler(_ticker_FormClosed);
            }
        }

        void _ticker_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ticker.FormClosed -= new FormClosedEventHandler(_ticker_FormClosed);
            _ticker = null;
        }
    }
}
