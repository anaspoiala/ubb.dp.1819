using System;
using RabbitMQ.Client;

namespace EnterpriseIntegrationPatterns
{
    public class MailSenderClient
    {
        public static void Main(string[] args)
        {
            MailService mailService = new MailService();
            for (int i = 0; i< 1000; i++)
            {
                mailService.SendMail($"Hello World, {i}");
            }
        }

    }
}
