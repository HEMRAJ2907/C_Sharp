using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    static class stud
    {
        static int rollno;

        static stud()
        {
            rollno = 1;
            Console.WriteLine("static class constructor called ");
        }

        public static void increa()
        {
            rollno++ ;
        }

        public static void count()
        {
            Console.WriteLine($"roll no : {rollno}");
        }
    }

    class stude
    {
        public string name;
        public int age;

        static stude()
        {
            Console.WriteLine("staic constructor of class called");
        }

        public stude(string name,int age)
        {
            this.name = name;
            this.age = age;
            stud.increa();
            Console.WriteLine("parameterrised constructor called");
        }

        public stude(stude s)
        {
            name = s.name;
            age = s.age;
            stud.increa();
            Console.WriteLine("copy constructor called");
        }

        public void data()
        {
            Console.WriteLine($"name : {name} , age : {age}");
        }

    }
    internal class static_and_copy
    {
        public static void Main(String[] args)
        {
           
            stude s1 = new stude("sachine", 1);
            //stude s3 = new stude("hemraj", 102);
            stude s2 = new stude(s1);
            //stude s4 = new stude(s3);
            s1.data();
            s2.data();
            //s3.data();
            //s4.data();

            Console.WriteLine();
            stud.increa();
            stud.count();
        }
    }
}
