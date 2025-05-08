using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age : ");
            string a = Console.ReadLine();
            int age = Convert.ToInt32(a);

            //nested if...else

           if (age >= 18)
                {
                    Console.WriteLine("you can drive a vhichels");
                }
                else if (age >= 16 && age < 18)
                {
                    Console.WriteLine("you can drive a  non-gear vehichels");
                }
                else
                {
                    Console.WriteLine("sorry ! you can't drive a vhichels");
                }
        }
    }
}
