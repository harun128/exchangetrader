using BinanceExchange.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaCini.Classes
{
    public class MyOrderResponse
    {
        public string Symbol { get; set; }
        public long OrderId { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public OrderType Type { get; set; }
        public OrderSide Side { get; set; }
        public DateTime Time { get; set; }
    }
}
