using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class student
    {
        private Dictionary<string, int> marks = new Dictionary<string, int>();

        public int this[string subject]
        {
            get
            {
                if (marks.ContainsKey(subject))
                {
                    return marks[subject];
                }
                else
                {
                    Console.WriteLine("ye wala subject hai hi nahi to 0 dega");
                    return 0;
                }
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("0 se leke 100 ke bich me daal bhai ");
                }
                else
                {
                    marks[subject] = value;
                }
            }
        }
        public void show()
        {
            Console.WriteLine("sabhi saubject ke marks ");
            foreach (var sub in marks)
            {
                Console.WriteLine($"{sub.Key} : {sub.Value}");
            }

        }
    }
    internal class indexers4
    {
        public static void Main(string[] args)
        {
            student s = new student();
            s["math"] = 98;
            s["science"] = 92;
            s["chemistry"] = 90;

            Console.WriteLine("math ke marks " + s["math"]);
            Console.WriteLine("science ke marks " + s["science"]);
            Console.WriteLine("english ke marks " + s["english"]);

            s["history"] = 120;
            

            s.show();
        }

    }
}
