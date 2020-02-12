using BinanceExchange.API.Market;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BorsaCini
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        public Form1  f1 = new Form1();
        public static string Coin;
        public static string TradeCoin;
        public static string BuyEmailAdress;
        public static string BuyEmailAdressPw;
        public static string SellEmailAdress;
        public static string SellEmailAdressPw;

        public static string BuySignalTitle;
        public static string SellSignalTitle;
        public static string Sender;
        public static string key;
        public static string secret;
        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuySignalTitle = BuySignalTitleText.Text;
            SellSignalTitle = SellSignalTitleText.Text;
            Sender = SenderText.Text;
            key = ApiKeyText.Text;
            secret = SecretKeyText.Text;
            BuyEmailAdress = BuyEmailAdressText.Text;
            BuyEmailAdressPw = BuyEmailAdressPwText.Text;
            SellEmailAdress = SellEmailAdressText.Text;
            SellEmailAdressPw = SellEmailAdressPwText.Text;
            key = ApiKeyText.Text;
            secret = SecretKeyText.Text;
            Coin = CoinText.Text;
            TradeCoin = TradeCoinText.Text;

            XmlTextWriter writer = new XmlTextWriter("settings.xml",System.Text.UTF8Encoding.UTF8);
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("settings");
                writer.WriteElementString("BuySignalTitle", BuySignalTitle);
                writer.WriteElementString("SellSignalTitle", SellSignalTitle);
                writer.WriteElementString("Sender", Sender);
                writer.WriteElementString("Key", key);
                writer.WriteElementString("Secret", secret);
                writer.WriteElementString("BuyEmailAdress", BuyEmailAdress);
                writer.WriteElementString("BuyEmailAdressPw", BuyEmailAdressPw);
                writer.WriteElementString("SellEmailAdress", SellEmailAdress);
                writer.WriteElementString("SellEmailAdressPw", SellEmailAdressPw);
                writer.WriteElementString("Coin", Coin);
                writer.WriteElementString("TradeCoin", TradeCoin);
                writer.WriteEndElement();
                writer.Close();
            }
            catch (Exception ex)
            {

                Form1.AddError(ex);
            }
            this.Hide();            
            f1.Show();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ReadXML();
            CoinText.Text = Coin;
            TradeCoinText.Text = TradeCoin;
            BuySignalTitleText.Text = BuySignalTitle;
            SellSignalTitleText.Text = SellSignalTitle;
            SenderText.Text = Sender;
            ApiKeyText.Text = key;
            SecretKeyText.Text = secret;
            BuyEmailAdressText.Text = BuyEmailAdress;
            BuyEmailAdressPwText.Text = BuyEmailAdressPw;
            SellEmailAdressText.Text = SellEmailAdress;
            SellEmailAdressPwText.Text = SellEmailAdressPw;

            ApiKeyText.PasswordChar = '*';
            SecretKeyText.PasswordChar = '*';
            BuyEmailAdressPwText.PasswordChar = '*';
            SellEmailAdressPwText.PasswordChar = '*';

            decimal sayi = 0.4525m;
            decimal yenisayi =(sayi + 0.003m);
            //MessageBox.Show(yenisayi.ToString());
        }

        public void ReadXML()
        {
            XmlTextReader oku = new XmlTextReader("settings.xml");
            try
            {
                while (oku.Read()) //Dosyadaki veriler tükenene kadar okuma işlemi devam eder.
                {
                    if (oku.NodeType == XmlNodeType.Element)//Düğümlerdeki veri element türünde ise okuma gerçekleşir.
                    {
                        switch (oku.Name)//Elementlerin isimlerine göre okuma işlemi gerçekleşir.
                        {
                            case "BuySignalTitle":
                                BuySignalTitle = oku.ReadString();
                                break;
                            case "SellSignalTitle":
                                SellSignalTitle = oku.ReadString();
                                break;
                            case "Sender":
                                Sender = oku.ReadString();
                                break;
                            case "Key":
                                key = oku.ReadString();
                                break;
                            case "Secret":
                                secret = oku.ReadString();
                                break;
                            case "BuyEmailAdress":
                                BuyEmailAdress = oku.ReadString();
                                break;
                            case "BuyEmailAdressPw":
                                BuyEmailAdressPw = oku.ReadString();
                                break;
                            case "SellEmailAdress":
                                SellEmailAdress = oku.ReadString();
                                break;
                            case "SellEmailAdressPw":
                                SellEmailAdressPw = oku.ReadString();
                                break;
                            case "Coin":
                                Coin = oku.ReadString();
                                break;
                            case "TradeCoin":
                                TradeCoin = oku.ReadString();
                                break;
                        }
                    }
                }
                oku.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xml Bağlantı Hatası : " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
