using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{

    class getset
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class get_and_set
    {
        public static void Main(String[] args)
        {
            getset g = new getset();
            g.Name = "Hemrajsinh";
            Console.WriteLine(g.Name);


            Console.ReadLine();
        }
    }
}
