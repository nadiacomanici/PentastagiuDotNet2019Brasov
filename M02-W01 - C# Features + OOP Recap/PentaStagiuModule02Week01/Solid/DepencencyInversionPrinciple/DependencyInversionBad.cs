using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.DepencencyInversionPrincipleBad
{
    class EmailSender
    {
        public void SendEmail(string address)
        {
            Console.WriteLine("Sending email to {0}", address);
        }
    }

    class MailingList
    {
        private EmailSender _emailSender;

        private List<string> _addresses = new List<string>()
        {
            "a@test.test",
            "b@test.test"
        };

        public MailingList()
        {
            _emailSender = new EmailSender();
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
            MailingList list = new MailingList();
            list.SendEmails();
        }
    }
}
