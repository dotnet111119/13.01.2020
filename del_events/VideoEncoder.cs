using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1301_video
{
    public class VideoEncoder
    {

        // 1 - first we define the elegate signature, then we define a public variable of the functions holder
        public delegate void VideoEncodedHandler(Video v, int duration);
        public VideoEncodedHandler VideoEncodedHandler_func;

        // 2 - we define a public variable of the functions holder
        public Action<Video, int> VideoEncodedHandler_func_using_action;


        public void OnVideoEncoded(Video v, int duration)
        {
            if (VideoEncodedHandler_func_using_action != null)
            {
                VideoEncodedHandler_func_using_action.Invoke(v, duration);
            }
        }

        public void EncodeVideo(Video v)
        {
            Random r = new Random();
            Console.WriteLine("Start encoding ...");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            Thread.Sleep(r.Next(1000 + v.Seconds, 4000 + v.Seconds));

            Console.WriteLine("Finished Encoding ...");

            sw.Stop();

            OnVideoEncoded(v, (int)sw.ElapsedMilliseconds / 1000);

        }
    }
}
