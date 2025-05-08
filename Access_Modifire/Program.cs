using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AccessDemo
{
    class BaseClass
    {
        public string PublicValue = "I am Public";            // Accessible everywhere
        private string PrivateValue = "I am Private";         // Accessible only in this class
        protected string ProtectedValue = "I am Protected";   // Accessible in this class and derived classes
        internal string InternalValue = "I am Internal";      // Accessible within the same assembly

        public void ShowAccess()
        {
            Console.WriteLine(PublicValue);
            Console.WriteLine(PrivateValue);
            Console.WriteLine(ProtectedValue);
            Console.WriteLine(InternalValue);
        }
    }

    class DerivedClass : BaseClass
    {
        public void ShowDerivedAccess()
        {
            Console.WriteLine(PublicValue);        
            // Console.WriteLine(PrivateValue);     
            Console.WriteLine(ProtectedValue);      
            Console.WriteLine(InternalValue);       
        }
    }

    class Program
    {
        static void Main()
        {
            BaseClass b = new BaseClass();
            b.ShowAccess(); 

            DerivedClass d = new DerivedClass();
            d.ShowDerivedAccess();

           
            Console.WriteLine(b.PublicValue);        
            //Console.WriteLine(b.PrivateValue);    
            // Console.WriteLine(b.ProtectedValue);  
            Console.WriteLine(b.InternalValue);      
        }
    }
}
