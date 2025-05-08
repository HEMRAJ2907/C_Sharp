using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{


    class space
    {
        private static readonly object _lock = new object ();
        private static space ins;

        private space()
        {
            Console.WriteLine("space private constructor created");
        }


        public static space Ins
        {
            get
            {
                lock  (_lock){

                    if (ins == null)
                    {
                        Console.WriteLine("craeting intense ........");
                        ins = new space();
                        
                    }
                }
                return ins;
            }


        }

        public static void show(string msg)
        {
            Console.WriteLine($"message : {msg}");
        }
    }
    internal class singleton3
    {
        public static void main(string[] args)
        {
            space.show("helloo  ! ji");
        }
    }
}
