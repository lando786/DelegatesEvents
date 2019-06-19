using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public class EmailNotificationService
    {
        public void OnUserProcessed(object sender, EventArgs args)
        {
            throw new NotImplementedException();
            SendEmail();
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }
    }
}
