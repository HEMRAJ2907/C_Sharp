using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class methodovrldg2
    {
        // overloading by oreder of parameters

        class rev
        {
            public void print(string a , int b)
            {
                Console.WriteLine($"messge : {a}  num : {b}");
            }

            public void print(int b , string a)
            {
                Console.WriteLine($"num :{b}  message : {a}");

            }

            public static void Main(String[] args)
            {
                rev r = new rev();

                r.print("hemrajsinh", 1);
                r.print(404 , "not found");
            }
        }
    }
}
