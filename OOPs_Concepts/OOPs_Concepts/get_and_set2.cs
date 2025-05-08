using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    class onlyone
    {
        private int pass;

        public int ID
        {
            get { return pass; }
        }

        public int Pass
        {
           
            set { pass = value; }
        }

        //public void show()
        //{
        //    Console.WriteLine($"password : {pass}");
        //}
    }
    internal class get_and_set2
    {
        public static void Main(String[] args)
        {
            onlyone a = new onlyone();
            a.Pass = 2907;
           // a.show();
            
        }
    }
}
