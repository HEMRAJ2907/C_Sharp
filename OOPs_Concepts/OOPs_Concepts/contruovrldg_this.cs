using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    class student
    {
        public string name;
        public int id;
        public string dept;


        public student(string name)
        {
            this.name = name;
            id = 101;
            dept = "it";
        }

        public student(string name, int id)
        {
            this.name = name;
            this.id = id;
            dept = "cse";
        }

        public student (string name ,int id , string dept)
        {
            this.name = name;
            this.id = id;
            this.dept = dept;
        }

        public void show()
        {
            Console.WriteLine($"name : {name} , id : {id} , department : {dept} ");
        }
    }
    internal class contruovrldg_this
    {
        public static void Main(String[] args)
        {
            student s1 = new student("hemrajsinh");
            student s2 = new student("tilak", 102);
            student s3 = new student("vinit", 103, "civil");

            s1.show();
            s2.show();
            s3.show();
        }
    }
}
