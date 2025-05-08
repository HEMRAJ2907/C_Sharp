using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Concepts
{
    class salaryslip
    {
        public double amount;

        public void tax()
        {
            Console.WriteLine("tax method ");
        }

    }

    class employee
    {
    

        private salaryslip slip = new salaryslip();

        public void setsalary(double amount)
        {
            slip.amount = amount;
            Console.WriteLine($"slary : {slip.amount}");
        }

        public void printsalary()
        {
            
            Console.WriteLine("employee class ki method");
            slip.tax();
        }
    }
    internal class has_a1
    {
        public static void Main(String[] args)
        {
            employee e = new employee();
            e.setsalary(100000);
             e.printsalary();
           
        }
    }
}
