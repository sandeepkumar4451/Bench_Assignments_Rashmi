using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLinkedList
{
    public class Employee<T>
    {
        private List<T> _List = new List<T>();
        public void AddEmployee(T Employee)
        {
            _List.Add(Employee);
        }
        public void Display()
        {
            for (int i = 0; i < _List.Count; i++)
            {
                Console.WriteLine(_List[i]);
            }
            Console.WriteLine("Total Number of Employee : " + _List.Count);
        }
    }
}
