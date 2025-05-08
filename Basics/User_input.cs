using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// printing and taking input from user and output

namespace Assignments
{
    internal class User_input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name :");
            string name = Console.ReadLine(); // 2 byte per character 
            Console.WriteLine("hello " + name + " how are you !");
            // Console.ReadLine();
            int a = 33; // 4 byte
            float b= 3.3f; // 4 byte
            double c = 2.2; // 8 byte
            char d = 'h'; // 2 byte
            Boolean e = true; // 1 bit = 8 byte
            Console.WriteLine(a);
            Console.WriteLine(b);   
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            // int input 
            Console.WriteLine("how many candies do you want ?");
            string val= Console.ReadLine();
            int x = Convert.ToInt32(val);
            Console.WriteLine("you want  "+val+ " candies");
            Console.WriteLine("you will get 4 more candies : " + val + 4);
            Console.WriteLine("you will get 4 more candies : " + (x + 4));
            Console.WriteLine("you will get 4 more cnadies : " + Convert.ToInt32(val) + 4);
            Console.WriteLine("you will get 4 more cnadies : " + (Convert.ToInt32(val) + 4));
        }
    }
}
