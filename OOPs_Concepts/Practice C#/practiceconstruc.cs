using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_C_
{
    class C
    {
        public string name;
        public int age;

        static C()
        {
            Console.WriteLine("helloo  this is simple constructor");
        }

        public C(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public C(C s)
        {
            name = s.name;
            age = s.age;
        }

        public void show()
        {
            Console.WriteLine($"name : {name} , age : {age}");
        }
    }

  

internal class practiceconstruc
    {
        public static void Main(string[] args)
        {
            C c = new C("tilak", 101);
            C c1 = new C(c);

            c.show();
            c1.show();
        }
    }
}
