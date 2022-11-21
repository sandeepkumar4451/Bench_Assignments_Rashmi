using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrList
{
    public class Employee
    {
        public int EmpId { get; set; } 
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public Employee(int empId,string empName,double salary)
        {
            EmpId = empId;
            EmpName = empName;
            Salary = salary;
        }
        static void Main(string[] args)
        {
            ArrayList emp = new ArrayList();
            Employee emp1 = new Employee(765,"Sandeep",21000);
            Employee emp2 = new Employee(218, "Shashank", 28002);
            Employee emp3 = new Employee(432,"Abdul",29874);
            emp.Add(emp1);
            emp.Add(emp2);
            emp.Add(emp3);
            foreach (Employee e in emp)
            {
                Console.WriteLine("Employee Id: "+e.EmpId);
                Console.WriteLine("Employee Name: "+e.EmpName);
                Console.WriteLine("Employee Salary: "+e.Salary);
            }
        }
    }
}
