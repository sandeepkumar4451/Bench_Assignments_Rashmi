using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_ass1
{
    public class Swap
    {
        public void Swapping(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("First integer after swapping: "+ a);
            Console.WriteLine("Second integer after swapping: " + b);
        }
    }
}
