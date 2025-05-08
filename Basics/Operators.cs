using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

//operators in c#

namespace Assignments
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of a : ");
            string ainput = Console.ReadLine();
            int a =Convert.ToInt32(ainput);

            Console.WriteLine("enter value of b : ");
            string binput = Console.ReadLine(); 
            int b =Convert.ToInt32(binput);


            //arithmatic operators
            Console.WriteLine("addition of a nd b is : " + (a + b));
            Console.WriteLine("subtraction of a and b is : "+(a - b));
            Console.WriteLine("multiplication of a and b is : " + (a * b));
            Console.WriteLine("divion of a and b is : " + (a / b));

            //assignment operators

            //a = 4;
            //b = a;
            //int c = b;

            //b += a;
            //c -= a;
            //b *= a;
            //c /= a;
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // logical operators
            //and 
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.WriteLine(false && true);

            // or

            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine(false || true);

            //not operator

            Console.WriteLine(!true);
            Console.WriteLine(!false);

            // comparison operators

            Console.WriteLine(5 > 50);
            Console.WriteLine(5 >= 50);
            Console.WriteLine(5 <= 50);
            Console.WriteLine(5 == 50);
            Console.WriteLine(5 != 50);

            //math class 

            int x = Math.Max(a, b);
            Console.WriteLine(x);

            int y = Math.Min(a, b);
            Console.WriteLine(y);

            double z = Math.Sqrt(a);
            Console.WriteLine(z);

            double v = Math.Abs(a);
            Console.WriteLine(v);
        }
    }
}
