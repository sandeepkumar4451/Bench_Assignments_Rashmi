using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calci
{
    public class calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            string res;
            do
            {
                var min = new calculator();
                Console.WriteLine("Enter number 1 ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter number 2 ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("chooose 1 to add, 2 to sub, 3 to mul, 4 to div");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine(min.Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine(min.Sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine(min.Mul(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine(min.Div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Do you want to continue: y/n");
                res =Console.ReadLine();
            }
            while(res=="y" || res=="Y");
        }
    }
}
