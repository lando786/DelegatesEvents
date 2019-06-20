using System;

namespace DelegatesEvents
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Running Application!");
            var processor = new UserProcessor();
            var emailService = new EmailNotificationService();
            var textService = new TextMessageNotificationService();
            processor.UserProcessed += emailService.OnUserProcessed;
            processor.UserProcessed += textService.OnUserProcessed;
            processor.ProcessUser();
        }
    }
}
