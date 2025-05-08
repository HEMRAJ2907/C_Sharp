using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Outkeyword
    {
        static void outkey(out int y) {
            y = 100;
        }

        static void Main(string[] args) {
            int h;
            outkey(out h);
            Console.WriteLine($"value by refrance in out keyword {h}");
        }
    }
}
