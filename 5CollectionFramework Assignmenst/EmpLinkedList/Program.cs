using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var List = new Employee<string>();
            Console.WriteLine("Employee List : ");
            List.AddEmployee("Sandeep");
            List.AddEmployee("Vishnu");
            List.AddEmployee("Shashank");
            List.AddEmployee("Manoj");
            List.Display();
            Console.ReadLine();
        }
    }
}
