using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class VideoEncoder
    {
        //1. Define a delegate
        public delegate void VideoEncodedEventHandler();
        //2.Define a event based on that delegate
        public VideoEncodedEventHandler VideoEncoded;

        public void Encode()
        {
            Thread.Sleep(3000);     //Do Code
            Console.WriteLine("Video Encoded");
            if (VideoEncoded != null)
            {
                VideoEncoded();    //Raise Event
            }

        }
    }
}
