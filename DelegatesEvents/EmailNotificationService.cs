using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public interface IEmailNotificationService
    {
        void OnUserProcessed(object sender, EventArgs args);

        void SendEmail();
    }

    public class EmailNotificationService : IEmailNotificationService
    {
        public void OnUserProcessed(object sender, EventArgs args)
        {
            SendEmail();
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }
    }
}
