using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    //// method overloading by number of parameters
    class person
    {
        public void student()
        {
            string name = "virat";
            int age = 30;
            Console.WriteLine($"name : {name} , age : {age}");

        }
        public void student(string name)
        {
            Console.WriteLine(name);
        }

        public void student(string name, int age)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(name);
            }
        }
        internal class methodovrldg
    {
        
           


            public static void Main(String[] args)
            {
                person p = new person();

                p.student();
                p.student("rahul");
                p.student("hardik", 6);
            }
        }


       
       
        
    }
}
