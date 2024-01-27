using System;

namespace EventsAndDelegates
{
    public class SmsService
    {
        public void SendSmsOnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("SmsService: Sending SMS ..." + e.Video.Title);
        }
    }
}
