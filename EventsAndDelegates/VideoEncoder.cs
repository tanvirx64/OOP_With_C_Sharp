using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video{ get; set; }
    }
    public class VideoEncoder {
        // 1. Define a Delegate
        // 2. Define an Event based on that Delegate
        // 3. Raise the Event

        //using Custom Delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //usign EventHandler<T>
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
