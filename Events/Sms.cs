using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Sms
    {
        public delegate void MyDelegate(string message, int number);
        public event MyDelegate SentMessage;
        public event MyDelegate ReceiveMessage;

        public void SendedMessage(string message,int number)
        {
            SentMessage.Invoke(message, number);
        }
        public void HandleSentMessage(string message, int number)
        {
            Console.WriteLine($"Sent Message: {message}, Number: {number}");
        }
        public void ReceivedMessage(string message, int number)
        {
            ReceiveMessage.Invoke(message, number);
        }
        public void HandleReceivedMessage(string message, int number)
        {
            Console.WriteLine($"Received Message: {message}, Number: {number}");
        }
    }
}
