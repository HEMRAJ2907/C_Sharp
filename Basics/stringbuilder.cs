using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class stringbuilder
    {
        static void Main()
        {
            //building a new string
            StringBuilder a = new StringBuilder("Hello ");

            //append a string 
            a.Append("Hemraj");

            // insert in to string 
            a.Insert(5, '!');

            //repalce the string 
            a.Replace("Hemraj", "c#");

            //remove a string 
            a.Remove(2, 1);

            Console.WriteLine(a.ToString());
        }
    }
}
