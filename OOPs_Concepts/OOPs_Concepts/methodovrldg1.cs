using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    //method overloading by data types
    class math

    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public double add(double a, double b)
        {
            return a + b;
        }

        public string add(string a, string b)
        {
            return a + b;

        }
    }
    internal class methodovrldg1
    {

        //method overloading by data types
       

        public static void Main(String[] args)
        {
            math m = new math();
            Console.WriteLine(m.add(10, 20));
            Console.WriteLine(m.add(10.10, 20.25));
            Console.WriteLine(m.add("Surtaiya ", " Hemrajsinh"));

        }
    }
}
