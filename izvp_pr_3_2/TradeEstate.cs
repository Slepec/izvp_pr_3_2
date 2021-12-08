using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_2
{
    public class TradeEstate : Estate
    {
        private string purpose;

        public TradeEstate(string purpose, string status, double price, double square, string address, DateTime date) : base(status, price, address, date, square)
        {
            this.purpose = purpose;
        }
        public override string ToString()
        {
            String text = "TradeEstate={purpose=" + purpose + " status=" + Status + " price=" + Price +  " square=" + Square + " address=" + Address + " date=" + Date+"}\n";
            return text;
        }

    

        public string Purpose { get => purpose; set => purpose = value; }
    }
}
