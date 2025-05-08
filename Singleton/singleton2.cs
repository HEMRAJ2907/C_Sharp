using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

     class student
    {
        public static student ins;

        private student()
        {

        }

        public static student Ins
        {
            get
            {
                if(ins == null)
                {
                    ins = new student();
                    
                }
                return ins;
            }

        }
        public void show( string mess)
        {
            Console.WriteLine($"message : {mess}"); 
        }
    }
    internal class singleton2
    {
        public static void main( string[] args )
        {
            student.Ins.show("ye hai private constructor ");
        }
    }
}
