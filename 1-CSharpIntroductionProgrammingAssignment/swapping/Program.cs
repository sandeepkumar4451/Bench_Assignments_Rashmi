using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_ass1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Swap swap = new Swap();
            Console.WriteLine("Enter integer 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            swap.Swapping(a,b);
        }

       
    }
}
