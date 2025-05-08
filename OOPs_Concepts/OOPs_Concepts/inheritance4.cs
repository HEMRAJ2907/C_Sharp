using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  // virtual is used for mehod as virtual
  // override is used for override method of base class form derived class
namespace OOPs_Concepts
{ class fruit
    {
        public  virtual void eat()
        {
            Console.WriteLine("fruits are healthy and sweet");
        }
    }
    class mango : fruit
    {
        public override void eat()
        {
            Console.WriteLine("mango are haelthy and sweets");
        }
    }

    class apple : fruit
    {
        public new void eat()
        {
            Console.WriteLine("apple are healthy and sweet");
        }
    }
    internal class inheritance4
    {
        public static void Main(String[] args)
        {
            fruit a = new mango();  
            a.eat();  // it's override so it will print  class mango

            fruit m = new apple();
            m.eat(); //it's overhide do it will print base class fruit

            //apple f = new apple();
            //f.eat(); // it's simple object of apple class
            Console.ReadLine();

        }
    }
}
