using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_2
{
    public class User
    {
        string phone;
        string address;
        List<Estate> estates;

        public override string ToString()
        {
            String text = "phone=" + phone + "\naddress=" + address + "\n";
            estates.ForEach(i => text += i + "\n");
            return text;
        }

        public User(string phone, string address, List<Estate> estates)
        {
            this.phone = phone;
            this.address = address;
            this.estates = estates;
        }

        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public List<Estate> Estates { get => estates; set => estates = value; }

    }
}
