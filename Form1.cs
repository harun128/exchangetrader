using BinanceExchange.API.Client;
using BinanceExchange.API.Enums;
using BinanceExchange.API.Models.Request;
using BinanceExchange.API.Models.Response;
using BorsaCini.Classes;
using S22.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaCini
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



       
        public static List<Exception> ExceptionList = new List<Exception>();
        public static List<EmailsInformation> AllEmails = new List<EmailsInformation>();        
        
        public static ImapClient SellClient;
        public static ImapClient BuyClient;

        Thread sets;
        Thread bets;
        static AutoResetEvent reconnectEventSellClient = new AutoResetEvent(false);
        static AutoResetEvent reconnectEventBuyClient = new AutoResetEvent(false);
     
        /*Initializin Error Email*/        

     
        /*Initializin Buy Email*/
        static void InitializeBuyClient()
        {
            if (BuyClient != null)
                BuyClient.Dispose();
            BuyClient = new ImapClient("imap.gmail.com", 993, SettingsForm.BuyEmailAdress, SettingsForm.BuyEmailAdressPw, AuthMethod.Login, true);
            BuyClient.NewMessage += BuyClient_NewMessage1;
            BuyClient.IdleError += BuyClient_IdleError;
        }

        private static void BuyClient_IdleError(object sender, IdleErrorEventArgs e)
        {

            reconnectEventBuyClient.Set();
            AddError(e.Exception);
        }

        private static void BuyClient_NewMessage1(object sender, IdleMessageEventArgs e)
        {
            try
            {
                MailMessage message = e.Client.GetMessage(e.MessageUID, FetchOptions.HeadersOnly);
                string EmailSender = message.From.User.ToString() + "@" + message.From.Host.ToString();
                if (EmailSender == SettingsForm.Sender && message.Subject == SettingsForm.BuySignalTitle)
                {
                    MyBinanceClass mbc = new MyBinanceClass();

                    EmailsInformation inf = new EmailsInformation();
                    inf.Date = DateTime.Now;
                    inf.Subject = message.Subject;
                    inf.Side = OrderSide.Buy;
                    AllEmails.Add(inf);
                    mbc.Buy();
                }
            }
            catch (Exception ex)
            {
                AddError(ex);
            }

        }


        /*Initializin Sell Email*/
        public static  void InitializSellClient()
        {
            if (SellClient != null)
                SellClient.Dispose();
            SellClient = new ImapClient("imap.gmail.com", 993, SettingsForm.SellEmailAdress, SettingsForm.SellEmailAdressPw, AuthMethod.Login, true);

            
            SellClient.NewMessage += SellClient_NewMessage1;
            SellClient.IdleError += SellClient_IdleError;
        }

        private static void SellClient_IdleError(object sender, IdleErrorEventArgs e)
        {                     
            reconnectEventSellClient.Set();
            AddError(e.Exception);
        }

        private static void SellClient_NewMessage1(object sender, IdleMessageEventArgs e)
        {
            try
            {
                MailMessage message = e.Client.GetMessage(e.MessageUID, FetchOptions.HeadersOnly);
                string EmailSender = message.From.User.ToString() + "@" + message.From.Host.ToString();
                if (EmailSender == SettingsForm.Sender && message.Subject == SettingsForm.SellSignalTitle)
                {
                    MyBinanceClass mbc = new MyBinanceClass();

                    EmailsInformation inf = new EmailsInformation();
                    inf.Date = DateTime.Now;
                    inf.Subject = message.Subject;
                    inf.Side = OrderSide.Sell;
                    AllEmails.Add(inf);
                    mbc.Sell();
                }
            }
            catch (Exception ex)
            {
                
                AddError(ex);
            }
        }


        /*Initializing All Emails Thread**/
        public void SellEmailThreadStarting()
        {
            try
            {
                while (true)
                {
                    InitializSellClient();
                    if (SellClient.Authed)
                    {
                        label2.Text = "Sell Signals are following";
                        label2.ForeColor = Color.ForestGreen;
                    }
                    reconnectEventSellClient.WaitOne();                    
                    
                }
            }
            catch (Exception ex)
            {                
                AddError(ex);
            }
            finally
            {
                if (SellClient != null)
                    SellClient.Dispose();

            }
        }
        public void BuyEmailThreadStarting()
        {
            try
            {
                while (true)
                {
                    InitializeBuyClient();
                    if (BuyClient.Authed)
                    {
                        label1.Text = "Buy Signals are following";
                        label1.ForeColor = Color.ForestGreen;
                    }
                    reconnectEventBuyClient.WaitOne();
                    

                }
            }
            catch (Exception ex)
            {
                
                AddError(ex);
            }
            finally
            {
                if (BuyClient != null)
                    BuyClient.Dispose();

            }
        }
        
        private  void Form1_Load(object sender, EventArgs e)
        {
           

            label1.Text = "";
            label2.Text = "";
            CheckForIllegalCrossThreadCalls = false;            
            Orders();
            sets = new Thread(new ThreadStart(SellEmailThreadStarting));
            bets = new Thread(new ThreadStart(BuyEmailThreadStarting));
            sets.Start();
            bets.Start();
            sets.IsBackground = false;
            bets.IsBackground = false;
            sets.Priority = ThreadPriority.Highest;
            sets.Priority = ThreadPriority.Highest;
                        
            
        }

      
       
        public async void Orders()
        {
            try
            {
                MyBinanceClass mbc = new MyBinanceClass();
                List<OrderResponse> or = await mbc.client.GetAllOrders(new AllOrdersRequest
                {
                    Limit = 12,
                    Symbol = SettingsForm.Coin+SettingsForm.TradeCoin
                });
                List<MyOrderResponse> mor = new List<MyOrderResponse>();
                foreach (OrderResponse item in or)
                {
                    mor.Add(new MyOrderResponse
                    {
                        OrderId = item.OrderId,
                        Symbol = item.Symbol,
                        Side = item.Side,
                        Quantity = item.ExecutedQuantity,
                        Time = item.Time,
                        Price = item.Price
                    });
                }
                mor.Reverse();
                OrderDGV.DataSource = mor;
                foreach (DataGridViewRow dr in OrderDGV.Rows)
                {
                    if (dr.Cells["Side"].Value.ToString() == OrderSide.Sell.ToString())
                    {
                        dr.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                        dr.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            catch (Exception ex)
            {
                 //AddError(ex);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrorListForm elf = new ErrorListForm();
            elf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmailsForm ef = new EmailsForm();
            ef.Show();
        }

        private  void timer1_Tick(object sender, EventArgs e)
        {
            Orders();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        

        public static void AddError(Exception ex)
        {
            try
            {
                
                ExceptionList.Add(ex);
                ImapClient ErrorMail = new ImapClient("imap.gmail.com", 993, "apisinyal@gmail.com", "123apiaq", AuthMethod.Login, true);

                MailMessage message = new MailMessage();
                message.From = new MailAddress("apisinyal@gmail.com");
                message.To.Add("harun128@gmail.com");
                message.Subject = ex.GetType().ToString();
                message.Body = "Message:"+ex.Message+"\n"+"InnerException"+ex.InnerException+"\n StackTrace"+ex.StackTrace.ToString();
                ErrorMail.StoreMessage(message); 
            }
            catch (Exception exx)
            {
                ExceptionList.Add(exx);
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(ExceptionList.Count>0)
            {
                button2.Text = "ERRORS(" + ExceptionList.Count.ToString() + ")";
                button2.ForeColor = Color.Red;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.Show();
        }

        private void InternetControl_Tick(object sender, EventArgs e)
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SystemSounds.Hand.Play();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            SettingsForm sf = new SettingsForm();
            sf.Show();
            
        }
    }
}
    
