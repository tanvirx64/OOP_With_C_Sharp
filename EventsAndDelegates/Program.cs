namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Tutorial Video 1.1"};
            
            var videoEncoder = new VideoEncoder();                //Publisher
            var mailService = new MailService();                  //Subscriber
            var smsService = new SmsService();                    //Subscriber
            var notificationService = new NotificationService();  //Subscriber

            videoEncoder.VideoEncoded += mailService.SendMailOnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.SendSmsOnVideoEncoded;
            videoEncoder.VideoEncoded += notificationService.SendNotificationOnVideoEncoded;


            videoEncoder.Encode(video);
        }
    }
}
