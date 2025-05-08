using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// methods are use for doing specific task, making reusability of code
namespace Assignments
{
    internal class methods
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static void main() {
            int sum = add(10, 50);
            Console.WriteLine(sum);
        }
    }
}
