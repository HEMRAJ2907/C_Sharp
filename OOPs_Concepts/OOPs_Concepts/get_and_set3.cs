using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class condition
    {
        private int age;

        public int Age
        {
            get { return age; }

            set
            {
                if (value >= 0)
                {
                    age = value;
                    Console.WriteLine($"age is : {age}");
                }
                else
                {
                    Console.WriteLine("age cannot be negative");
                }
            }
        }
    }
    internal class get_and_set3
    {
        public static void Main(String[] args)
        {
            condition c = new condition();
            c.Age = 15;
        }
    }
}
