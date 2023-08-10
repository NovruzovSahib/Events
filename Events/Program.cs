using Events;
using System;
using System.Diagnostics;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Onmoving += car.StartMoving; // Just pass the method reference
        car.StartEvent();


        Mail mail = new Mail();
        mail.OnSendMail += mail.ResultMailSuccess;
        mail.EventMailSuccess("Sahib");
        mail.OnSendMailFail += mail.ResultMailFail;
        mail.EventMailFail("Ali");


        Sms sms = new Sms();
        sms.SentMessage += sms.HandleSentMessage;
        sms.ReceiveMessage += sms.HandleReceivedMessage;
        sms.SendedMessage("Hello, this is a sent message.", 42);
        sms.ReceivedMessage("Hi there!", 17);


        Call call = new Call();
        call.OnCalled += call.Called;
        call.CallEvent("Sahib",503852885);
        call.OnReceived += call.Received;
        call.ReceiveEvent("Ali", 559253256);

        Console.ReadLine();
    }

}
