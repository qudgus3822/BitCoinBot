using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitCoinBot
{

   


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string sAPI_Key = "f43e94893f73581ef0d3837d44219696 ";
    //        string sAPI_Secret = "7d471443ceb15661d90865fda3dbc320";

    //        string sParams = "order_currency=BTC&payment_currency=KRW";
    //        string sRespBodyData = String.Empty;
    //        XCoinAPI hAPI_Svr;
    //        JObject JObj = null;


    //        hAPI_Svr = new XCoinAPI(sAPI_Key, sAPI_Secret);

    //        //
    //        // public api
    //        //
    //        // /public/ticker
    //        // /public/recent_ticker
    //        // /public/orderbook
    //        // /public/recent_transactions

    //        Console.WriteLine("Bithumb Public API URI('/public/ticker') Request...");
    //        JObj = hAPI_Svr.xcoinApiCall("/public/ticker", sParams, ref sRespBodyData);
    //        if (JObj == null)
    //        {
    //            Console.WriteLine("Error occurred!");
    //            Console.WriteLine("HTTP Response JSON Data: {0}", sRespBodyData);
    //        }
    //        else
    //        {
    //            Console.WriteLine(JObj.ToString());

    //            if (String.Compare(JObj["status"].ToString(), "0000", true) == 0)
    //            {
    //                Console.WriteLine("- Status Code: {0}", JObj["status"].ToString());
    //                Console.WriteLine("- Opening Price: {0}", JObj["data"]["opening_price"].ToString());
    //                Console.WriteLine("- Closing Price: {0}", JObj["data"]["closing_price"].ToString());
    //                Console.WriteLine("- Sell Price: {0}", JObj["data"]["sell_price"].ToString());
    //                Console.WriteLine("- Buy Price: {0}", JObj["data"]["buy_price"].ToString());
    //            }
    //        }

    //        Console.Write("\n\n");


    //        //
    //        // private api
    //        //
    //        // endpoint => parameters
    //        // /info/current
    //        // /info/account
    //        // /info/balance
    //        // /info/wallet_address

    //        /* Console.WriteLine("Bithumb Private API URI('/info/account') Request...");
    //        JObj = hAPI_Svr.xcoinApiCall("/info/account", sParams, ref sRespBodyData);
    //        if (JObj == null)
    //        {
    //            Console.WriteLine("Error occurred!");
    //            Console.WriteLine("HTTP Response JSON Data: {0}", sRespBodyData);
    //        }
    //        else {
    //            Console.WriteLine(JObj.ToString());

    //            if (String.Compare(JObj["status"].ToString(), "0000", true) == 0) {
    //                Console.WriteLine("- Status Code: {0}", JObj["status"].ToString());
    //                Console.WriteLine("- Created: {0}", JObj["data"]["created"].ToString());
    //                Console.WriteLine("- Account ID: {0}", JObj["data"]["account_id"].ToString());
    //                Console.WriteLine("- Trade Fee: {0}", JObj["data"]["trade_fee"].ToString());
    //                Console.WriteLine("- Balance: {0}", JObj["data"]["balance"].ToString());
    //            }
    //        } */
    //    }
    //}
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
