using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class EnumExample
    {
        enum days
        {
            sunday = 1,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday = 10
        }

        public static void Main(string[] args)
        {
            days present = days.saturday;
            Console.WriteLine($"present day is {present}");  // for finding present day
            Console.WriteLine((int)present);  // for finding value of present day

            foreach (string name in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(name);  // for printing all enum names
            }

            foreach (int value in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine(value);  // for printing all enum values  
            }
        }
    }
}
