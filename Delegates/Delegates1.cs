using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate int Operation(int a, int b); 

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Compute(Operation op, int x, int y)
        {
            int result = op(x, y);
            Console.WriteLine("Result: " + result);
        }
        internal class Delegates1
        {
            public static void Main(String[] args)
            {
                Compute(Add, 10, 20);
                Compute(Multiply, 10, 6);
            }
        }
    }
}
