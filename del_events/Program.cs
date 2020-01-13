using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1301_video
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder videoEncoder = new VideoEncoder();
            WatsappSender watsapp = new WatsappSender();
            MailSender mailer = new MailSender();

            videoEncoder.VideoEncodedHandler_func_using_action = watsapp.SendWatsapp; // event is better ...
            videoEncoder.VideoEncodedHandler_func_using_action += mailer.SendMail; // event is better ...

            //videoEncoder.VideoEncodedHandler_func_using_action -= watsapp.SendWatsapp; // remove method from delegate

            //videoEncoder.VideoEncodedHandler_func_using_action.GetInvocationList --> gets all the methods in his belly

            // videoEncoder.VideoEncodedHandler_func_using_action.Invoke(null, -1000); // event is better

            videoEncoder.VideoEncodedHandler_func_using_action += (v, t) => { Console.WriteLine("Notify using lambda"); };

            videoEncoder.EncodeVideo(new Video { Title = "Super man", Seconds = 200 });

            Console.WriteLine("Main finished...");
        }
    }
}
