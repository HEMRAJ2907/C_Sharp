using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// string method 

namespace Assignments
{
    internal class String_methods
    {
        static void Main(string[] args)
        {
            string hello = "hello hemraj how are you ?";
            Console.WriteLine(hello);
            Console.WriteLine("length :" + hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());

            //string interpolation
            Console.WriteLine("enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter number of candies : ");
            string can = Console.ReadLine();
            Console.WriteLine($"hello {name} how are you . you will get {can} cans .");

            // for printing individual character
            Console.WriteLine(hello[6]);

            // for finding index
            Console.WriteLine(hello.IndexOf("how"));    

            // fro making sub string
            Console.WriteLine(hello.Substring(6));

            //verbatisn string 
            Console.WriteLine(@"hello ! how \n are \t you ?");

            // verbatian string for multiple line 
            Console.WriteLine( @"hellooo
             hey    how are you 
                hemraj");

        }


    }

}
