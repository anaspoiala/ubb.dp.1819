using System;
using System.Threading;

namespace EnterpriseIntegrationPatterns
{
    public class MailService
    {
        public void SendMail(string message)
        {
            Console.WriteLine($"Sending email: {message}");
            Thread.Sleep(1000);
            Console.WriteLine("Email sent!");
        }
    }
}
