using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_2
{
    public class Apartament : Estate
    {
        private int maxResidenrts;

        public Apartament(int maxResidenrts,string status,double price,double square,string address,DateTime date) : base(status,price,address,date,square)
        {
            this.maxResidenrts = maxResidenrts;
        }
        public override string ToString()
        {
            String text = "Apartament {maxResidents=" + maxResidenrts + " status=" + Status + " price=" + Price + " square=" + Square + " address=" + Address + " date=" + Date + "}\n";

            return text;
        }
        public int MaxResidenrts { get => maxResidenrts; set => maxResidenrts = value; }
    }

}
