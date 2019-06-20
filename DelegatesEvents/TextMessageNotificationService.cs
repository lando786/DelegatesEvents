using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public class TextMessageNotificationService
    {
        public void OnUserProcessed(object sender, EventArgs args)
        {
            SendText();
        }

        public void SendText()
        {
            Console.WriteLine("Sending Text Message...");
        }
    }
}
