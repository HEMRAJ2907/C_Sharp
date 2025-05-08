using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

     class A
    {
        public void methodA()
        {
            Console.WriteLine("class A ki methods ");
        }
    }

    class B
    {
        private A a = new A();

        public void methodB()
        {
            a.methodA();
            Console.WriteLine("class B ki Mwthods ");
        }
    }
    internal class has_a2
    {
        public static void Main(String[] args)
        {
            B b = new B();
            b.methodB();
        }
    }
}
