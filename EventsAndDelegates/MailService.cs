using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void SendMailOnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending Mail ..." + e.Video.Title );
        }
        public void SendMailOnOrderPalced(object source, OrderEventArgs e)
        {
            Console.WriteLine("MailService: Sending Mail ... Order Id : " + e.Order.Id);
        }
    }
}
