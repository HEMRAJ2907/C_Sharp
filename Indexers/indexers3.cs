using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class twodim
    {
        private int[,] C = new int[3,3];

        public int this[int row, int column]
        {
            get
            {
                if(row >=0 && row < 2 || column >=0 && column < 2)
                {
                    return C[row, column];
                }
                else
                {
                    Console.WriteLine("invalid numbers");
                    return 0;
                }
            }
            set
            {
                if (row >= 0 && row < 2 || column >= 0 && column < 0)
                {
                     C[row, column] = value;
                }
                else
                {
                    Console.WriteLine("invalid numbers can't assign");
                    
                }
            }
        }
    }
    internal class indexers3
    {
        public static void Main(String[] args)
        {
            twodim t = new twodim();
            t[0, 1] = 15;
            t[1, 2] = 20;

            Console.WriteLine(t[0, 1]);
            Console.WriteLine(t[1, 2]);
          //  Console.WriteLine(t[2, 2]);
        }
    }
}
