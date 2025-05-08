using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ModifierDemo
{
    class TestClass
    {
        public string PublicData = "Public Member";
        private string PrivateData = "Private Member";
        protected string ProtectedData = "Protected Member";
        internal string InternalData = "Internal Member";

        public void ShowAll()
        {
            Console.WriteLine("Inside TestClass:");
            Console.WriteLine(PublicData);
            Console.WriteLine(PrivateData);
            Console.WriteLine(ProtectedData);
            Console.WriteLine(InternalData);
        }
    }

    class AnotherClass
    {
        public void TryAccess()
        {
            TestClass obj = new TestClass();
            Console.WriteLine("\nInside AnotherClass:");
            Console.WriteLine(obj.PublicData);     
            // Console.WriteLine(obj.PrivateData);  
            // Console.WriteLine(obj.ProtectedData);
            Console.WriteLine(obj.InternalData);    
        }
    }

    class Program
    {
        static void Main()
        {
            TestClass t = new TestClass();
            t.ShowAll();

            AnotherClass a = new AnotherClass();
            a.TryAccess();
        }
    }
}

