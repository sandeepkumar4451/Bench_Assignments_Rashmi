using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    interface IPrintable
    {
        double calculateGrossSalary();
    }
    class Employee : IPrintable
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public virtual double calculateGrossSalary()
        {
            return EmpSalary;
        }

    }

    // derived class of Employee 
    class Manager : Employee
    {

        private double PA { set; get; }
        private double FA { set; get; }
        private double OA { set; get; }

        public Manager(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            EmpSalary = salary;
            PA = salary * 8 / 100;
            FA = salary * 13 / 100;
            OA = salary * 3 / 100;
        }

        public override double calculateGrossSalary()
        {
            return EmpSalary + PA + FA + OA;
        }
    }
    // derived class of Employee 
    class MarketingExecutive : Employee
    {

        private int kmTravel { set; get; }
        private double TA { set; get; }
        private double TelephoneA { set; get; }

        public MarketingExecutive(int empNo, string empName, double salary, int KmTrav)
        {
            EmpNo = empNo;
            EmpName = empName;
            EmpSalary = salary;
            kmTravel = KmTrav;
            TA = KmTrav * 5;
            TelephoneA = 1000;
        }

        public override double calculateGrossSalary()
        {
            return EmpSalary + TA + TelephoneA;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Manager Id");
            int ManId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Manager Name");
            string MName = Console.ReadLine();
            Console.WriteLine("Enter the Manager Salary");
            double MSalary = Convert.ToDouble(Console.ReadLine());
            Manager manager1 = new Manager(ManId, MName, MSalary);

            Console.WriteLine("Enter the MarketingExecutive Id");
            int MExeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the MarketingExecutive Name");
            string MEName = Console.ReadLine();
            Console.WriteLine("Enter the MarketingExecutive Salary");
            double MESalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Travelling Km");
            int MKm = Convert.ToInt32(Console.ReadLine());
            MarketingExecutive mExecutive1 = new MarketingExecutive(MExeId, MEName, MESalary, MKm);

            double managerSalary = manager1.calculateGrossSalary();
            double mExecutiveSalary = mExecutive1.calculateGrossSalary();

            Console.WriteLine("Manager Gross Salary " + managerSalary);
            Console.WriteLine("Marketing Executive Gross Salary " + mExecutiveSalary);
            Console.ReadLine();
        }
    }
}
