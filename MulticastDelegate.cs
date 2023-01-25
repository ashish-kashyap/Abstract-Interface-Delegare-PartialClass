using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class MulticastDelegate
    {
        public delegate void NewDelegate(int x, int y);

        // static method
        static void Add(int x, int y)
        {
            Console.WriteLine($"Sum of x and y: {x + y}");;
        }
        static void Subtract(int x, int y)
        {
            Console.WriteLine($"Difference of x and y: {x - y}");
        }

        // Non-static method
        public void Multiply(int x, int y)
        {
            Console.WriteLine($"Product of x and y: {x * y}");
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine($"Division of x and y: {x / y}");
        }

        static void Main(string[] args)
        {
            // Static method within same class can be accessed directly
            NewDelegate d1 = new NewDelegate(Add);
            NewDelegate d2 = new NewDelegate(Subtract);

            // Non-static method must be accessed through object
            MulticastDelegate MDel = new MulticastDelegate();

            NewDelegate d3 = new NewDelegate(MDel.Multiply);
            NewDelegate d4 = new NewDelegate(MDel.Divide);

            // d5 is a multicast delegate
            NewDelegate d5 = d1 + d2 + d3 + d4;

            Console.WriteLine("Invoking Multicast Delegate: ");
            d5.Invoke(20, 5);
            

            // Invoking Multicast Delegate after removing one delegate
            Console.WriteLine("Invoking Multicast Delegate after removing one delegate: ");
            d5 = (d5 - d2)!;
            d5(22, 7);

        }
        
    }
}