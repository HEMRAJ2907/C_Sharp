using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// simple inheritance 
namespace OOPs_Concepts
{
    class animal
    {
        public void eat()
        {
            Console.WriteLine("animal can eat ..........");
        }
    }

    class dog : animal
    {
        public void bark()
        {
            Console.WriteLine("dog can bark ..........");
        }
    }
    internal class inheritance
    {
        public static void Main(string[] args)
        {
            dog d = new dog();
            d.bark();
            d.eat();
        }
    }
}
