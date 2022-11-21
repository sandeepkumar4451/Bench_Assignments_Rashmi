using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            Circles c=new Circles();
            Console.WriteLine("Area of circle: "+c.area());
            Console.WriteLine("Circumference of circle: "+c.circumference());
        }
    }
}
