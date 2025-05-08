using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Partial_ClassDemo
{

    public partial class Vehicle
    {
        public string Brand;
        public string Model;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }

   
    public partial class Vehicle
    {
        public int Year;
        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} ({Year}) is starting...");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle v = new Vehicle();
            v.Brand = "Toyota";
            v.Model = "Camry";
            v.Year = 2022;

            v.ShowInfo();
            v.Start();
        }
    }
}

