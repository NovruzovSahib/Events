using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Mail
    {
        public delegate void MyDelegate(string message);
        public event MyDelegate OnSendMail;
        public event MyDelegate OnSendMailFail;

        public void ResultMailSuccess(string message)
        {
            Console.WriteLine(message + "Successfully sent");
        }
        public void ResultMailFail(string message)
        {
            Console.WriteLine(message + "Unsent");
        }
        public void EventMailSuccess(string message)
        {
                OnSendMail.Invoke(message);
                Console.WriteLine("Email successfull sent");
        }
        public void EventMailFail(string message)
        {
            OnSendMailFail.Invoke(message);
            Console.WriteLine("Email Unsent");
        }
    }
}
