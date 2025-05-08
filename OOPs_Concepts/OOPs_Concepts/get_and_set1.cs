using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class autocall
    {
        public string Name
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }
    }
    internal class get_and_set1
    {
        public static void Main(String[] args)
        {
            autocall c = new autocall();
            c.Name = "Rajubhai";
            c.id = 111;

            Console.WriteLine($"name : {c.Name} , id : {c.id}  ");

            Console.ReadLine();
        }
    }
}
