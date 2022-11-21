using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circles
    {
        const double pi = 3.14;
        double r = Convert.ToDouble(Console.ReadLine());

        public double circumference()
        {
            return 2*pi*r;
        }

        public double area()
        {
            return pi * r * r;
        }
    }
}
