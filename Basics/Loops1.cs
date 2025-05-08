using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Loops1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number ehich day you want : ");
            string a = Console.ReadLine();
            int num = Convert.ToInt32(a);

            switch (num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;

                case 2:
                    Console.WriteLine("tuesday");
                    break;

                case 3:
                    Console.WriteLine("wednesday");
                    break;

                case 4:
                    Console.WriteLine("thursday");
                    break;

                case 5:
                    Console.WriteLine("friday");
                    break;

                case 6:
                    Console.WriteLine("saturday");
                    break;

                case 7:
                    Console.WriteLine("sunday");
                    break;

                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
        }
    }
}
