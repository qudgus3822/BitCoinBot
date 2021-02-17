using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinBot
{
    public partial class Form1 : Form
    {
        string sAPI_Key = "f43e94893f73581ef0d3837d44219696 ";
        string sAPI_Secret = "7d471443ceb15661d90865fda3dbc320";

        string sParams = "order_currency=BTC&payment_currency=KRW";
        string sRespBodyData = String.Empty;
        XCoinAPI hAPI_Svr;
        JObject JObj = null;



        BackgroundWorker bg = new BackgroundWorker();
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JObj = GetAccount();
            lb_total.Text = JObj["data"]["total_krw"].ToString();
            lb_orderable.Text = JObj["data"]["available_krw"].ToString();
            lb_sellable.Text = JObj["data"]["available_btc"].ToString();



            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            bg.RunWorkerCompleted += delegate
            {
                bg.RunWorkerAsync();
            };
            bg.DoWork += delegate
             {

                 hAPI_Svr = new XCoinAPI(sAPI_Key, sAPI_Secret);

                 //
                 // public api
                 //
                 // /public/ticker
                 // /public/recent_ticker
                 // /public/orderbook
                 // /public/recent_transactions

                 JObj = hAPI_Svr.xcoinApiCall("/public/ticker", sParams, ref sRespBodyData);

                 
                 
                 this.Invoke(new Action(
                     delegate
                     {

                         lb_date.Text = Convert.ToString(time.AddSeconds(Convert.ToDouble(JObj["data"]["date"]) / 1000).ToLocalTime());                    
                         lb_currentPrice.Text = JObj["data"]["closing_price"].ToString();
                         lb_fluctate.Text = JObj["data"]["fluctate_24H"].ToString();
                         lb_fluctateRate.Text = JObj["data"]["fluctate_rate_24H"].ToString();
                         //양초에이피아이로했을때 
                         //textBox1.Text = "";

                         //textBox1.Text += Convert.ToString(time.AddSeconds(Convert.ToDouble(JObj["data"][JObj["data"].Count() - 1][0]) / 1000).ToLocalTime());
                         //textBox1.Text += "\r\n";
                         //textBox1.Text += JObj["data"][JObj["data"].Count() - 1][1].ToString();
                         //textBox1.Text += "\r\n";
                         //textBox1.Text += JObj["data"][JObj["data"].Count() - 1][2].ToString();
                         //textBox1.Text += "\r\n";
                         //textBox1.Text += JObj["data"][JObj["data"].Count() - 1][3].ToString();
                         //textBox1.Text += "\r\n";
                         //textBox1.Text += JObj["data"][JObj["data"].Count() - 1][4].ToString();
                         //textBox1.Text += "\r\n";
                         //textBox1.Text += JObj["data"][JObj["data"].Count() - 1][5].ToString();
                         //textBox1.Text += "\r\n";

                     }));


                 Thread.Sleep(1000);

             };

                bg.RunWorkerAsync();


        }

        public JObject GetAccount()
        {
            hAPI_Svr = new XCoinAPI(sAPI_Key, sAPI_Secret);

            return hAPI_Svr.xcoinApiCall("/info/balance", sParams, ref sRespBodyData);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
           

            hAPI_Svr = new XCoinAPI(sAPI_Key, sAPI_Secret);
            float unit = 0;
            float orderPrice = 0;
           ;
            if (float.TryParse(tb_order.Text, out unit) && float.TryParse(tb_order.Text,out orderPrice))
            {

                float currentPrice = float.Parse(lb_currentPrice.Text);
                unit = orderPrice / currentPrice;
                string buyParams = String.Format("units={0:F4}&order_currency=BTC&payment_currency=KRW", unit);
                JObj = hAPI_Svr.xcoinApiCall("/trade/market_buy", buyParams, ref sRespBodyData);
            }
            else
            {
                MessageBox.Show("금액을 정확히 입력해주세요");
            }

            if (JObj["status"].ToString() == "0000")
            {
                MessageBox.Show("주문성공");
            }
            else
            {
                MessageBox.Show("주문실패 " + JObj["message"].ToString());
            }
            

        }
    }
}
