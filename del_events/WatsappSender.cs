using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1301_video
{
    public class WatsappSender
    {
        public void SendWatsapp(Video v, int encodDuraion)
        {
            Console.WriteLine("Sending whatsapp");
            Console.WriteLine($"Video {v.Title} length {v.Seconds} was encoded during {encodDuraion}");
        }
    }
}
