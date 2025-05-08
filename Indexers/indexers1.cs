using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class myarray
    {
        private string[] arr = new string[3];

        public string this[int index]
        {
            get
            {
                if (index >= 0 || index <= arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    return "Invalid index";
                }
            }

            set
            {
                if (index >= 0 || index <= arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    Console.WriteLine("Invalid index number");
                }
            }

        }
    }
    internal class indexers1
    {
      
        public static void Main(string[] args)
        {
            myarray a = new myarray();
            a[0] = "hello";
            a[1] = "Hemrajsinh";
            a[2] = "suratiya";
            


            for (int i = 0;i< 3; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
