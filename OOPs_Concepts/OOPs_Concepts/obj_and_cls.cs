using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class car
    {
        public string brand; // Changed to public
        public int price; // Changed to public

        // Constructor to initialize brand and price
        public car(string brand, int price)
        {
            this.brand = brand;
            this.price = price;
        }

        public void data()
        {
            Console.WriteLine($"brand : {brand} , price : {price}");
        }

    }
    internal class obj_and_cls
    {
       
        public static void Main(String[] args)
        {
            car c1 = new car("tata", 1000000);
            c1.data();

            car c2 = new car("hyundai", 1100000);
            c2.data();

           
        }
    }
}

