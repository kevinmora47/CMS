using System;
using System.Collections.Generic;

#nullable disable

namespace CMS.Models
{
    public partial class Price
    {
        public int IdPrice { get; set; }
        public string Header { get; set; }
        public string Legend { get; set; }
        public string PriceCardOneheader { get; set; }
        public string PriceCardTwoheader { get; set; }
        public string PriceCardThreeheader { get; set; }
        public string PriceOneBody { get; set; }
        public string PriceTwoBody { get; set; }
        public string PriceThreeBody { get; set; }
        public string CardOneButton { get; set; }
        public string CardTwoButton { get; set; }
        public string CardThreeButton { get; set; }
    }
}
