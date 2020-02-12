using BinanceExchange.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaCini.Classes
{
    public class EmailsInformation
    {
        public string Subject { get; set; }
        public OrderSide Side { get; set;}
        public DateTime Date { get; set; }
    }
}
