using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class refkeyword
    {
        static void refr(ref int y)
        {
            y = y * 10;
        }
         
        static void Main()
        {
            int h = 20;
            refr(ref h);
            Console.WriteLine(h);
        }

    }
}
