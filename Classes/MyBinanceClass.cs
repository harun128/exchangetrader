using BinanceExchange.API.Client;
using BinanceExchange.API.Enums;
using BinanceExchange.API.Market;
using BinanceExchange.API.Models.Request;
using BinanceExchange.API.Models.Response;
using BinanceExchange.API.Models.Response.Abstract;
using BinanceExchange.API.Models.Response.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaCini.Classes
{
    public class MyBinanceClass
    {
        public BinanceClient client;

        
        public MyBinanceClass()
        {
            try
            {               
                this.client =   new BinanceClient(new ClientConfiguration()
                {
                    ApiKey = SettingsForm.key,
                    SecretKey = SettingsForm.secret
                });
            }
            catch (Exception ex)
            {
                Form1.AddError(ex);
            }            
        }

        public async void Sell()
        {
            try
            {
                AccountInformationResponse ais = await client.GetAccountInformation();
                BaseCreateOrderResponse cor = await client.CreateOrder(new CreateOrderRequest
                {
                    Type = OrderType.Market,
                    Side = OrderSide.Sell,
                    Quantity = ais.Balances.Find(x=>x.Asset == SettingsForm.Coin).Free,
                    Symbol = SettingsForm.Coin+SettingsForm.TradeCoin
                });
                
            }
            catch (BinanceBadRequestException ex)
            {
                Form1.AddError(ex);

            }
            catch (BinanceServerException ex)
            {
                Form1.AddError(ex);
            }
            catch (BinanceTimeoutException ex)
            {
                Form1.AddError(ex);
            }
            catch (BinanceException ex)
            {
                Form1.AddError(ex);

            }
            catch(Exception ex)
            {
                Form1.AddError(ex);
            }
        }

        public async void Buy()
        {           
            try
            {
                List<SymbolPriceResponse> spr =  await client.GetSymbolsPriceTicker();
                decimal price = (spr.Find(x => x.Symbol == SettingsForm.Coin+SettingsForm.TradeCoin).Price);
                AccountInformationResponse ais = await client.GetAccountInformation();
                decimal quantity = Math.Floor(ais.Balances.Find(x => x.Asset == SettingsForm.TradeCoin).Free / price) -1;
                
                BaseCreateOrderResponse cor = await client.CreateOrder(new CreateOrderRequest
                {
                    Type = OrderType.Market,
                    Side = OrderSide.Buy,
                    Quantity = quantity,
                    Symbol = SettingsForm.Coin+SettingsForm.TradeCoin
                });                
            }
            catch (BinanceBadRequestException ex)
            {
                Form1.AddError(ex);

            }
            catch (BinanceServerException ex)
            {
                Form1.AddError(ex);

            }
            catch (BinanceTimeoutException ex)
            {
                Form1.AddError(ex);

            }
            catch (BinanceException ex)
            {
                Form1.AddError(ex);

            }
            catch (Exception ex)
            {
                Form1.AddError(ex);
            }
        }

       
    }
}
