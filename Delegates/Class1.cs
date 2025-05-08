using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo.MultiCast
{
    public delegate void Notify(); // Declare a delegate

    class Program
    {
        public static void SendEmail()
        {
            Console.WriteLine("Email sent.");
        }

        public static void SendSMS()
        {
            Console.WriteLine("SMS sent.");
        }

        public static void SendPushNotification()
        {
            Console.WriteLine("Push notification sent.");
        }

        static void Main()
        {
            Notify notify = SendEmail;
            notify = notify + SendSMS;
            notify = notify + SendPushNotification;

            notify(); 
        }
    }
}

