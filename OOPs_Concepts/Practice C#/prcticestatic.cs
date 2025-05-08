using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    static class c
    {
        static int id;


        static c()
        {
            Console.WriteLine("this is staic constructor");
        }

        public static void Show()
        {
            Console.WriteLine("hello how are you ?");
        }
    }

     class names
    {
       

        public  names()
        {
           
            Console.WriteLine(" this is a  class constructor");
        }

        public  void show()
        {
            Console.WriteLine("this is the  class method");
        }

    }
    internal class prcticestatic
    { 
        public static void Main()
        {
            names n = new names();
            n.show();

            c.Show();
        }
    }
}
