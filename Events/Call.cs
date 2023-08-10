using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Call
    {
        public delegate void MyDelegate(string name, long phonenumber);
        public event MyDelegate OnCalled;
        public event MyDelegate OnReceived;

        //Event Method

        public void CallEvent(string name, long phonenumber)
        {
            OnCalled.Invoke(name, phonenumber);
        }
        public void ReceiveEvent(string name, long phonenumber)
        {
            OnReceived.Invoke(name, phonenumber);
        }

        //Methods

        public void Called(string name, long phonenumber)
        {
            Console.WriteLine("Called name is {0} Phone number is {1}",name,phonenumber);
        }
        public void Received(string name, long phonenumber)
        {
            Console.WriteLine("Received name is {0} Phone number is {1}", name, phonenumber);
        }


    }
}
