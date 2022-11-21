using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestMark
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter avg mark of student no.1");
            int s1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avg mark of student no.2");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avg mark of student no.3");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avg mark of student no.4");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter avg mark of student no.5");
            int s5 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2 && s1 > s3 && s1 > s4 && s1 > s5)
                Console.WriteLine("Highest number is " + s1);
            else if (s2 > s1 && s2 > s3 && s2 > s4 && s2 > s5)
                Console.WriteLine("Highest number is " + s2);
            else if (s3 > s1 && s3 > s2 && s3 > s4 && s3 > s5)
                Console.WriteLine("Highest number is " + s3);
            else if (s4 > s1 && s4 > s2 && s4 > s3 && s4 > s5)
                Console.WriteLine("Highest number is " + s4);
            else Console.WriteLine("Highest number is " + s5);
            
        }
    }
}

