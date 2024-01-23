using System.Collections.Generic;

namespace Polymorphism_Using_Interface
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private readonly IList<INotificationChannel> _notificationChannels;
        public VideoEncoder() {
            //this._mailService = new MailService();
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Encode Video
            //_mailService.Send(new Mail());

            foreach (var channel in _notificationChannels)
            {
                channel.SendMessage(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
