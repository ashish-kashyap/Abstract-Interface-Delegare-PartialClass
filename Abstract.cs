using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Employee                 // abstract class
    {
        public abstract int GetSalary();    // abstract method
    }

    class Developer : Employee
    {
        private int salary;
        public Developer(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }

    class Tester : Employee
    {
        private int salary;
        public Tester(int s)
        {
            salary = s;
        }
        public override int GetSalary()
        {
            return salary;
        }
    }

    class Abstract
    {
        static void Main(string[] args)
        {
            Developer Ashish = new Developer(50000);
            Tester Soham = new Tester(40000);

            int Developerpay = Ashish.GetSalary();
            int Testerpay = Soham.GetSalary();

            Console.WriteLine($"Salary of Developer: {Developerpay}");
            Console.WriteLine($"Salary of Tester: {Testerpay}");
        }
    }
}