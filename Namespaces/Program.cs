using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public struct Student
    {
        public string Name;
        public int Age;

        public void Display()
            => Console.WriteLine($"Student: {Name}, Age: {Age}");
    }
}

namespace Application
{
    using Models;

    public class School
    {
        public void Welcome(Student s)
        {
            Console.WriteLine($"Welcome, {s.Name}! You are {s.Age} years old.");
        }
    }


     internal class Program
    {
         public static void Main()
        {
            var student = new Student { Name = "Hemraj", Age = 22 };
            student.Display();

            var school = new School();
            school.Welcome(student);
        }
    }
}

