using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class customerinfo
    {
        private string name;
        private string email;

        public string this[string key]
        {
            get
            {
                if (key == "name")
                {
                    return name;
                }
                else if (key == "email")
                {
                    return email;
                }
                else
                {
                    return "invalid key";
                }

            }
            set
            {
                if (key == "name")
                {
                    name = value;
                }
                else if (key == "email")
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("invalid key");
                }
            }
        }
    }

    internal class indexers2
    {
        public static void Main(String[] args)
        {
            customerinfo c = new customerinfo();
            c["name"] = "hemrajsinh";
            c["email"] = "hem@gmail.com";
            
            Console.WriteLine(c["name"]);
            Console.WriteLine(c["email"]);
            Console.WriteLine(c["age"]);

            customerinfo c1 = new customerinfo();
            c1["name"] = "harsh";
            c1["email"] = "harsh02@gmail.com";

            Console.WriteLine(c1["name"]);
            Console.WriteLine(c1["email"]);
            Console.WriteLine(c1["age"]);
        }
    }
}
