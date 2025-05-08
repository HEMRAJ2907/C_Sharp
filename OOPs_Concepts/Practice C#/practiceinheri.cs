using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class food
    {
        public virtual void eat()
        {
            Console.WriteLine("food contain both drinkable and eatable");
        }
    }
    class cola : food
    {
        public override void eat()
        {
            Console.WriteLine("cola is also drinkable");
        }
    }

    class sevenup : food
    {
        public override void eat()
        {
            Console.WriteLine("sevenup is also drinkable");
        }
    }

    class appless : food
    {
        public new void eat()
        {
            Console.WriteLine("apple are eatable food");
        }
    }



    class mangoes : food
    {
        public new void eat()
        {
            Console.WriteLine("mangoes are eatable food");
        }
    }
    internal class practiceinheri
    {
        public static void Main()
        {

            food a = new cola();
            a.eat();

            food f = new appless();
            f.eat();

            food m = new mangoes();
            m.eat();

            food s = new sevenup();
            s.eat();

            
        }
    }
}
