using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_pr_3_2
{
    public class MyClass : MyInterface
    {
        private double[,] array;

        public MyClass(double[,] array)
        {
            this.array = array;
        }
        public MyClass(double[] array)
        {
            this.array = new double[1,array.Length];
            for(int i=0;i<array.Length;i++)
            {
                this.array[0,i] = array[i];
            }
        }

        public double myMax()
        {
            double maxEl = array[0,0];
            foreach(double el in array)
            {
                if (el > maxEl)
                    maxEl = el;
            }
            return maxEl;
        }

        public double myMin()
        {
            double minEl = array[0, 0];
            foreach (double el in array)
            {
                if (el < minEl)
                    minEl = el;
            }
            return minEl;
        }

        public double mySum()
        {
            double sum = 0;
            foreach (double el in array)
            {
                sum += el;
            }
            return sum;
        }
    }
}
