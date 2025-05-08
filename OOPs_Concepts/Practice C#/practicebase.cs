using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    class A
    {
        public A()
        {
            Console.WriteLine("class A is parent class");
        }

        public void display()
        {
            Console.WriteLine("hellooo ! how are you ");
        }
    }

    class B : A
    {
        public B() : base()
        {
            Console.WriteLine("class B is child class");
        }
    }


    internal class practicebase
    {
        public static void Main()
        {
            B b = new B();
            b.display();
        }
    }
}
