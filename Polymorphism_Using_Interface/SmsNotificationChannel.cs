using System;

namespace Polymorphism_Using_Interface
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("Sending SMS ... ");
        }
    }
}
