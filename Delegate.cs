using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP
{
    public class Delegate
    {
        public delegate int NewDelegate(int x, int y);

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            NewDelegate d1 = new NewDelegate(Add);
            NewDelegate d2 = new NewDelegate(Subtract);

            Console.WriteLine(d1(10, 20));
            Console.WriteLine(d2(10, 20));
        }
    }
}