using System;

namespace Polymorphism_Using_Interface
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void SendMessage(Message message)
        {
            Console.WriteLine("Sending Mail ... ");
        }
    }
}
