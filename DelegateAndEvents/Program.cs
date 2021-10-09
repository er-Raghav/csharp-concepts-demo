using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();      //Publisher

            MailService mail = new MailService();       //Subscriber
            MessageService msg = new MessageService();       //Subscriber
            encoder.VideoEncoded += mail.SendEmail;
            encoder.VideoEncoded += msg.SendMessage;

            encoder.Encode();
            Console.Read();
            
        }

    }

    class MailService {

        public void SendEmail() {
            
            Console.WriteLine("Email Sent!");
        }
    
    }

    class MessageService {
        public void SendMessage()
        {
            Console.WriteLine("Message Sent!");
        }

    }

}
