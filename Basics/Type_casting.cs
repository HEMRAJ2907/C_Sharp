using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// type conversion and casting 
// type conversion (auto conversion or implicite)
//type casting ( done by programmer  or explicite)

namespace Assignments
{
    internal class Type_casting
    {
        static void Main(string[] args)
        {
            // type casting implicit
            // char - int - long - float - double 
            int a = 2;
            double b = a;
            long c = 'y';
            double d = c;
            float e = 20.5f;
            double f = e;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);


            // type casting explicit

            double g = (int)2.5;
           // int n = (int)g;
            double h =(float)5.2265;
            float i = (char)2.555;
            long j = (char)99;
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);   
            Console.WriteLine(j);


            //type conversion (in built method)

            //float k = 3.55; // gives error
            int k = 29;
            double l = 29.07;
            float m = 55.25f;

            Console.WriteLine(Convert.ToString(m));
            Console.WriteLine(Convert.ToInt32(l));
            Console.WriteLine(Convert.ToDouble(k));
        }
    }
}
