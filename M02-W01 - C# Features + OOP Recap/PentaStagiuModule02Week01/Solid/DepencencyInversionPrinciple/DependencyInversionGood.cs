using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DepencencyInversionPrincipleGood
{
    interface IEmailSender
    {
        void SendEmail(string address);
    }

    class EmailSender: IEmailSender
    {
        public void SendEmail(string address)
        {
            Console.WriteLine("Sending email to {0} using google account", address);
        }
    }

    class EmailSenderYahoo : IEmailSender
    {
        public void SendEmail(string address)
        {
            Console.WriteLine("Sending email to {0} using yahoo account", address);
        }
    }

    class MailingList
    {
        private IEmailSender _emailSender;

        private List<string> _addresses = new List<string>()
        {
            "a@test.test",
            "b@test.test"
        };

        public MailingList(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendEmails()
        {
            foreach (string address in _addresses)
            {
                _emailSender.SendEmail(address);
            }
        }
    }
    
    class Example
    {
        static void Run()
        {
            IEmailSender sender = new EmailSenderYahoo();
            MailingList list = new MailingList(sender);
            list.SendEmails();
        }
    }
}
