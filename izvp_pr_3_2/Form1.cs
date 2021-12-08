using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izvp_pr_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyClass mc1 = new MyClass( new double[2, 3] { { 1, 2.12, 3 },{4,2.2,1.9 }});
            MyClass mc2 = new MyClass( new double[4] { 9, 10, 8, 6 });
            Console.WriteLine("mc1.max==>" + mc1.myMax());
            Console.WriteLine("mc1.min==>" + mc1.myMin());
            Console.WriteLine("mc1.sum==>" + mc1.mySum());
            Console.WriteLine("mc2.max==>" + mc2.myMax());
            Console.WriteLine("mc2.min==>" + mc2.myMin());
            Console.WriteLine("mc2.sum==>" + mc2.mySum());


            List<Estate> estates = new List<Estate>();
            estates.Add(new Apartament(6,"здається",20000,300,"address",DateTime.Now));
            estates.Add(new Apartament(2, "не зайняята", 10050, 120, "address2", DateTime.Now));
            estates.Add(new TradeEstate("офіс", "здається", 50000, 500, "address3", DateTime.Now));
            User user = new User("123123", "asdasd", estates);
            Console.WriteLine(user);
            foreach(Estate est in estates){
                Console.WriteLine(est.computePrice());
            }
        }
    }
}
