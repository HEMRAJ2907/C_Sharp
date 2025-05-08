using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    class cars
    {
        public void main()
        {
            Console.WriteLine("car class ki methods");
        }
    }

    class toyota
    {
         public cars car = new cars();
        public void run()
        {
            car.main();
            Console.WriteLine("toyota class ki method");
        }
    }
    internal class has_a
    {
        public static void Main(string[] args)
        {
            toyota t = new toyota();
            t.run();
        }
    }
}
