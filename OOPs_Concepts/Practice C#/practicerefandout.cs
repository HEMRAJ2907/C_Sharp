using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
       
    internal class practicerefandout
    {
        static void refr(ref int y, out int h)
        {
            y = y * 10;
            h = 100;
        }

        static void Main()
        {
            int a = 20;
            int b;
            refr(ref a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}

