using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{  
    class boy1
    {
         string name;
         public string Name
        {
            get { return name; } 
            set { name = value; }
        }
    }

    class Teacher
    {

        public string name;
        public int id;
        static string dept;

        static Teacher()
        {
            Console.WriteLine("this is a static constructor");
        }
        public Teacher(string name)
        {
            this.name = name;
            id = 103;
            dept = "cs";
        }

        public Teacher(string name,int id)
        {
            this.name = name;
            this.id = id;
            
        }

        public Teacher ()
        {
            name = "tilak";
            id = 101;
         
           
        }
        public void show()
        {
            Console.WriteLine($"name : {name} , id : {id}  , dept : {dept}");
        }
    }
    internal class practice_1
    {
        public static void Main(String[] args)
        {
            Teacher t = new Teacher();
            Teacher t1 = new Teacher("rahul", 102);
            Teacher t2 = new Teacher("varun");

            t.show();
            t1.show();
            t2.show();

            boy1 b = new boy1();
            b.Name = "Hemrajsinh";
            Console.WriteLine(b.Name);
        }
    }
}
