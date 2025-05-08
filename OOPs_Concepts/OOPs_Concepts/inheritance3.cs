using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
// inheritance with base keyword
// base() keyword is used for call based calss member
namespace OOPs_Concepts
{

    class men
    {
        public men()
        {
            Console.WriteLine("men constructor called");
        }

        public void greet()
        {
            Console.WriteLine("hellooooo ! every one ");
        }
    }

    class stu : men
    {
        public stu() : base()
        {
            Console.WriteLine("student constructor called");
        }
    }
    internal class inheritance3
    {
         public static void Main(String[] args)
        {
            stu s = new stu();
            s.greet();

        }
    }
}
