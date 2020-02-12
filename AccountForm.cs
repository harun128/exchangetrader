using BinanceExchange.API.Client;
using BinanceExchange.API.Models.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaCini
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private async void AccountForm_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(SettingsForm.key);
                BinanceClient client = new BinanceClient(new ClientConfiguration()
                {
                    ApiKey = SettingsForm.key,
                    SecretKey = SettingsForm.secret
                });
                
                AccountInformationResponse ais = await client.GetAccountInformation();
                dataGridView1.DataSource = ais.Balances.OrderByDescending(x => x.Free).Where(x => x.Free > 0).ToList();

            }
            catch (Exception ex)
            {
                Form1.AddError(ex);
                
            }
       }
    }
}
