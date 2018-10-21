using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CurrencyVietCbank.Models;
using Xamarin.Forms;
using System.Net;

namespace CurrencyVietCbank
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetExrate();
        }

        private void GetExrate()
        {
            // link XML of Vietcombank (Bank of Viet Nam)
            string url = "https://www.vietcombank.com.vn/exchangerates/ExrateXML.aspx";

            //Use HTTPWebRequest
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            //Get Response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Call GetResponseStream() to return Stream
            Stream responseStream = response.GetResponseStream();

            //Convert from XML to C# model:
            XmlSerializer serializer = new XmlSerializer(typeof(ExrateList));
            ExrateList exrateList = (ExrateList)serializer.Deserialize(responseStream);
            LabelDate.Text = "Date: " + exrateList.DateTime;

            //AUD
            LabelAUDBuy.Text = exrateList.Exrates[0].Buy;
            LabelAUDSell.Text = exrateList.Exrates[0].Sell;

            //CAD
            LabelCADBuy.Text = exrateList.Exrates[1].Buy;
            LabelCADSell.Text = exrateList.Exrates[1].Sell;

            //CHF
            LabelCHFBuy.Text = exrateList.Exrates[2].Buy;
            LabelCHFSell.Text = exrateList.Exrates[2].Sell;

            //DKK
            LabelDKKBuy.Text = exrateList.Exrates[3].Buy;
            LabelDKKSell.Text = exrateList.Exrates[3].Sell;

            //EUR
            LabelEURBuy.Text = exrateList.Exrates[4].Buy;
            LabelEURSell.Text = exrateList.Exrates[4].Sell;

            //GBP
            LabelGBPBuy.Text = exrateList.Exrates[5].Buy;
            LabelGBPSell.Text = exrateList.Exrates[5].Sell;

            //HKD
            LabelHKDSell.Text = exrateList.Exrates[6].Buy;
            LabelHKDSell.Text = exrateList.Exrates[6].Sell;

            //INR
            LabelINRBuy.Text = exrateList.Exrates[7].Buy;
            LabelINRSell.Text = exrateList.Exrates[7].Sell;

            //JPY
            LabelJPYBuy.Text = exrateList.Exrates[8].Buy;
            LabelJPYSell.Text = exrateList.Exrates[8].Sell;

            //KRW
            LabelKRWBuy.Text = exrateList.Exrates[9].Buy;
            LabelKRWSell.Text = exrateList.Exrates[9].Sell;

            //KWD
            LabelKWDBuy.Text = exrateList.Exrates[10].Buy;
            LabelKWDSell.Text = exrateList.Exrates[10].Sell;

            //MYR
            LabelMYRBuy.Text = exrateList.Exrates[11].Buy;
            LabelMYRSell.Text = exrateList.Exrates[11].Sell;

            //NOK
            LabelNOKBuy.Text = exrateList.Exrates[12].Buy;
            LabelNOKSell.Text = exrateList.Exrates[12].Sell;

            //RUB
            LabelRUBBuy.Text = exrateList.Exrates[13].Buy;
            LabelRUBSell.Text = exrateList.Exrates[13].Sell;

            //USD
            LabelUSDBuy.Text = exrateList.Exrates[18].Buy;
            LabelUSDSell.Text = exrateList.Exrates[18].Sell;


        }
    }
}
