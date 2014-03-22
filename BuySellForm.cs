using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InfoProxy;
using InfoProxy.Charts;

namespace Client
{
    public partial class BuySellForm : Form
    {
        PrivateMarket market = SingleInstance.The.BuySell;

        public BuySellForm()
        {
            InitializeComponent();
        }
        public InfoProxy.UserData.UserData UserData { get; set; }

        private void BuySellForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetBalance();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                BuyLimitOrder();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                SellLimitOrder();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                CancelOrder();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            try
            {
                GetTransactions();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            try
            {
                GetBalance();
                GetOrders();
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }

        private void GetBalance()
        {
            try
            {
                var balance = market.GetBalance(UserData);

                //usd_balance - USD balance
                //btc_balance - BTC balance
                //usd_reserved - USD reserved in open orders
                //btc_reserved - BTC reserved in open orders
                //usd_available- USD available for trading
                //btc_available - BTC available for trading
                //fee - customer trading fee

                labelValueBalance.Text = String.Format("USD {0} - BTC {1} - USD Reserved {2} - BTC Reserved {3} - USD Avail {4} - BTC Avail {5} - Fee {6}",
                    balance.usd_balance, balance.btc_balance, balance.usd_reserved, balance.btc_reserved, balance.usd_available, balance.btc_available, balance.fee);

            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void BuyLimitOrder()
        {
            try
            {
                var price = textPrice.Text;
                var amount = textAmount.Text;

                if (!String.IsNullOrEmpty(amount) && !String.IsNullOrEmpty(price))
                {
                    var result = market.BuyLimit(UserData, amount, price);

                    labelStatus.Text = "Result: Id " + result.id;
                }
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void SellLimitOrder()
        {
            try
            {
                var price = textPrice.Text;
                var amount = textAmount.Text;

                if (!String.IsNullOrEmpty(amount) && !String.IsNullOrEmpty(price))
                {
                    var result = market.SellLimit(UserData, amount, price);
                    labelStatus.Text = "Result: Id " + result.id;
                }
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void CancelOrder()
        {
            try
            {
                var idOrder = textId.Text;

                if (!String.IsNullOrEmpty(idOrder))
                {
                    var result = market.CancelOrders(UserData, idOrder);
                    labelStatus.Text = "Cancel result: " + result.id;
                }
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void GetTransactions()
        {
            try
            {
                var transactions = market.GetUserTransactions(UserData);

                /* id - transaction id
                    type - transaction type (0 - deposit; 1 - withdrawal; 2 - market trade)
                    usd - USD amount
                    btc - BTC amount
                    fee - transaction fee
                    oder_id - executed order id
                */
                listViewTransactions.Clear();

                foreach (var item in transactions)
                {
                    var tt = "deposit";
                    if (item.type == "0")
                        tt = "deposit";

                    if (item.type == "1")
                        tt = "withdrawal";

                    if (item.type == "2")
                        tt = "market trade";

                    var trr = String.Format("id {0} - type {1} - usd {2} - btc {3} - btc_usd {4} - datetime {5} - fee {6} - order_id {7}", item.id, tt, item.usd, item.btc, item.btc_usd, item.datetime, item.fee, item.order_id);
                    listViewTransactions.Items.Add(trr);
                }

            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }
        private void GetOrders()
        {

            try
            {
                var orders = market.GetUserOpenOrders(UserData);


                listViewOpenBuy.Clear();
                listViewOpenSell.Clear();

                foreach (var item in orders)
                {
                    /*
                      id - order id
                      datetime - date and time
                      type - buy or sell (0 - buy; 1 - sell)
                      price - price
                      amount - amount
                    */

                    // Buy
                    if (item.type == "0")
                    {
                        //var datetime = ChartUtils.UnixTimestampToDateTime(long.Parse(item.datetime));

                        var trr = String.Format("id {0} - time {1} - price {2} - amount {3}", item.id, item.datetime, item.price, item.amount);
                        listViewOpenBuy.Items.Add(trr);
                    }

                    // Sell      
                    if (item.type == "1")
                    {
                        //var datetime = ChartUtils.UnixTimestampToDateTime(long.Parse(item.datetime));

                        var trr = String.Format("id {0} - time {1} - price {2} - amount {3}", item.id, item.datetime, item.price, item.amount);
                        listViewOpenSell.Items.Add(trr);
                    }

                }
            }
            catch (Exception exc)
            {
                LogError(exc);
            }
        }

        private void LogError(Exception exc)
        {
            SingleInstance.Log.Debug(exc.Message);
            labelValueBalance.Text = DateTime.Now + " Error: " + exc.Message;
        }
    }
}
