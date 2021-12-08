using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_2
{
    public abstract class Estate : Computable
    {
        private string status;
        private double price;
        private string address;
        private DateTime date;
        private double square;

        protected Estate(string status, double price, string address, DateTime date, double square)
        {
            this.status = status;
            this.price = price;
            this.address = address;
            this.date = date;
            this.square = square;
        }

        public double computePrice()
        {
            return  price / square;
        }
        public string Status { get => status; set => status = value; }
        public double Price { get => price; set => price = value; }
        public string Address { get => address; set => address = value; }
        public DateTime Date { get => date; set => date = value; }
        public double Square { get => square; set => square = value; }
    }
}
