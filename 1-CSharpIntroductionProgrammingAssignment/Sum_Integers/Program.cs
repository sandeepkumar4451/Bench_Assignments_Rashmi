using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Integers
{
    public class Program
    {
        int[] li = new int[50];
        int i, a, sum = 0;

        public void Sum()
        {
            Console.WriteLine("Enter the number of elements you want to enter:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :\n", a);
            for (i = 0; i < a; i++)
            {
                Console.WriteLine("element {0} : ", i);
                li[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < a; i++)
            {
                sum += li[i];
            }

            Console.Write("\nSum of all integers is:{0}\n\n", +sum);
        }

        static void Main(string[] args)
        {
            Program sumin = new Program();
            sumin.Sum();
        }
    }
}
