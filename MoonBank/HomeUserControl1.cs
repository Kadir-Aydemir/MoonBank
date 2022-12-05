using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Net;
using HtmlAgilityPack;

namespace MoonBank
{
    public partial class HomeUserControl1 : UserControl
    {
        public HomeUserControl1()
        {
            InitializeComponent();          
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string numara;
        public string html;
        public Uri url;
        public void GoldBuySell(string Url, string XPath, Label buy)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
                if(MessageBox.Show("Hatalı url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
            catch (ArgumentNullException)
            {
                if (MessageBox.Show("Hatalı url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
                if (MessageBox.Show("Hatalı url", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
              // buy.Text = doc.DocumentNode.SelectSingleNode(XPath).InnerText;
            }
            catch (NullReferenceException)
            {
                if (MessageBox.Show("Hatalı XPath", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {

                }
            }
        }
        public void balance()
        {
            SqlCommand komut = new SqlCommand("select * from HESAP where HESAPNO='" + numara + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblBalance.Text = dr[1].ToString() + " TRY";
                lblbakiye.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
        private void HomeUserControl1_Load(object sender, EventArgs e)
        {
            balance();
            GOLD();
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";            
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblusdalis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblusdsatis.Text = dolarsatis;
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalis.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatis.Text = eurosatis;
            usdbuy= Convert.ToDouble(lblusdalis.Text.Replace(".", ","));
            usdsell = Convert.ToDouble(lblusdsatis.Text.Replace(".", ","));
            eurobuy = Convert.ToDouble(lbleuroalis.Text.Replace(".", ","));
            eurosell = Convert.ToDouble(lbleurosatis.Text.Replace(".", ","));
            lblDollarBuy.Text = (usdbuy - 0.25).ToString();
            lblDollarSell.Text = (usdsell + 0.25).ToString();
            lblEuroBuy.Text = (eurobuy - 0.25).ToString();
            lblEuroSell.Text = (eurosell + 0.25).ToString();
            timer1.Start();
        }
        
        double goldbuy,goldsell, usdbuy, usdsell, eurobuy, eurosell;

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(lblGoldSell.Text);
            miktar = Convert.ToDouble(lblbakiye.Text);
            tutar = (miktar / kur);
            tutar = Math.Round(tutar, 2);
            lblBalance.Text = tutar.ToString()+" GLD";
        }

        private void btnEUR_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(lblEuroSell.Text);
            miktar = Convert.ToDouble(lblbakiye.Text);
            tutar = (miktar / kur);
            tutar = Math.Round(tutar, 2);
            lblBalance.Text = tutar.ToString() + " EUR";
        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            double kur,miktar,tutar;
            kur = Convert.ToDouble(lblDollarSell.Text);
            miktar = Convert.ToDouble(lblbakiye.Text);
            tutar = (miktar / kur);
            tutar=Math.Round(tutar, 2);
            lblBalance.Text = tutar.ToString() + " USD";
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            balance();
        }
        void GOLD()
        {
            GoldBuySell("https://altinfiyatlari.biz/gram/", "/html/body/div/div[3]/div/div[3]/div[1]/div[2]/div[1]/span[2]", lblgoldalis);
            GoldBuySell("https://altinfiyatlari.biz/gram/", "/html/body/div/div[3]/div/div[3]/div[1]/div[2]/div[2]/span[2]", lblgoldsatis);
           // goldbuy = Convert.ToDouble(lblgoldalis.Text.Replace(".", ","));
            //goldsell = Convert.ToDouble(lblgoldsatis.Text.Replace(".", ","));
            //lblGoldBuy.Text = (goldbuy - 7).ToString();
            //lblGoldSell.Text = (goldsell + 2).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GOLD();
        }
    }
}
