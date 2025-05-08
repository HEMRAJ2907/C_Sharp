using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples.Basic
{
    public delegate void GreetDelegate(string name);

    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }

    internal class Program
    {
         public static void Main()
        {
            Greeter g = new Greeter();
            GreetDelegate greet = g.SayHello;
            greet("Hemraj");
        }
    }
}
