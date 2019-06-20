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
            processor.UserProcessed += emailService.OnUserProcessed;

            processor.ProcessUser();
        }
    }
}
