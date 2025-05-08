using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{

    class Logger
    {
        private static  Logger instance = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger instance created");
        }


        public static Logger Instance
        {
            get { return instance; }
        }


        public void log (string msg)
        {
            Console.WriteLine($"message : {msg}");
        }
    }
    internal class singleton1
    {
        static void Main(string[] args)
        {

            Logger.Instance.log("prrinting the message.................");
            Logger.Instance.log("helloooooo ! to kese hai aap sab log ?");
        }
    }
}
