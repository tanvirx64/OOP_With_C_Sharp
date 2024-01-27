using System;

namespace EventsAndDelegates
{
    public class NotificationService
    {
        public void SendNotificationOnVideoEncoded(object source, VideoEventArgs e) {
            Console.WriteLine("NotificationService: Sending Notification ..." + e.Video.Title);
        }
    }
}
