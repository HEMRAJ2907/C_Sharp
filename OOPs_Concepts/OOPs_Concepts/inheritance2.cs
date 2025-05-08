using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// hirarchical inheritance
namespace OOPs_Concepts
{
    class students
    {
        public void wear()
        {
            Console.WriteLine("students wear any clothes in collage campus");
        }
    }

    class boys : students
    {
        public void bwear()
        {
            Console.WriteLine("boys can wear pant and shirts or t-shirts in campus");
        }
    }

    class girls : students
    {
        public void gwear()
        {
            Console.WriteLine("girls can wear dress or kurties in campus");
        }
    }

    internal class inheritance2
    {
        public static void Main(String[] args)
        {
            boys b = new boys();
            b.wear();
            b.bwear();

            girls g = new girls();
            g.wear();
            g.gwear();
              
        }

    }
}
