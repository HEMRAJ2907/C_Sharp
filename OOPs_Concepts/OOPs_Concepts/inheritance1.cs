using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// multilevel inheritance 
namespace OOPs_Concepts
{ 
    class persons
    {
        public void main()
        {
            Console.WriteLine("person are working in diffrent areas  !!!");
        }
    }

    class boy : persons
    {
        public void work()
        {
            Console.WriteLine(" boy can work at any where  ");
        }
    }


    class studentss : boy
    {
        public void study()
        {
            Console.WriteLine("student studies important topics");
        }
    }

    internal class inheritance1
    {
        public static void Main(string[] args)
        {
            studentss s = new studentss();
            s.main();
            s.work();
            s.study();
        }
    }
}
