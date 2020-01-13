using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1301_video
{
    public class MailSender
    {
        public void SendMail(Video v, int encodDuraion)
        {
            Console.WriteLine("Sending Mail");
            Console.WriteLine($"Body: [Video {v.Title} length {v.Seconds} was encoded during {encodDuraion}]");
        }
    }
}
