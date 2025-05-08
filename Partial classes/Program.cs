using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Partial_Class
{
    
    public partial class Person
    {
        public string Name;
        public void Greet()
        {
            Console.WriteLine($"Hello, I’m {Name}");
        }
    }

    
    public partial class Person
    {
        public int Age;
        public void ShowAge()
        {
            Console.WriteLine($"I’m {Age} years old.");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "Hemraj";
            p.Age = 25;

            p.Greet();
            p.ShowAge();
        }
    }
}

