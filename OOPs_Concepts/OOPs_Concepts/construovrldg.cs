using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    internal class construovrldg
    {
        class car
        {
            public string brand;
            public int price;

            public car()
            {
                brand = "tata";
                price = 1000000;
            }

            public car(string b)
            {
                brand = b;
                price = 1100000;
            }

            public car(string b , int p)
            {
                brand = b;
                price = p;

            }
            public void show()
            {
                Console.WriteLine($"brand : {brand} , price : {price}");
            }

            public static void Main(String[] args)
            {
                car c1 = new car();
                car c2 = new car("hyundai");
                car c3 = new car("toyota", 1200000);

                c1.show();
                c2.show();
                c3.show();
            }
        }
    }
}
