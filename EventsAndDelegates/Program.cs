namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mailService = new MailService();                  //Subscriber
            var smsService = new SmsService();                    //Subscriber
            var notificationService = new NotificationService();  //Subscriber




            var video = new Video() { Title = "Tutorial Video 1.1"};
            
            var videoEncoder = new VideoEncoder();                //Publisher
            videoEncoder.VideoEncoded += mailService.SendMailOnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.SendSmsOnVideoEncoded;
            videoEncoder.VideoEncoded += notificationService.SendNotificationOnVideoEncoded;

            videoEncoder.Encode(video);





            var order = new Order() { Id = 1, Amount = 1500.50M };

            var orderProcessor = new OrderProcessor();            //Publisher
            orderProcessor.OrderPlaced += mailService.SendMailOnOrderPalced;
            orderProcessor.OrderPlaced += smsService.SendSmsOnOrderPalced;
            orderProcessor.OrderPlaced += notificationService.SendNotificationOnOrderPalced;

            orderProcessor.PlaceOrder(order);
            
        }
    }
}
