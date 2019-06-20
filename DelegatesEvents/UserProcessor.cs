using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesEvents
{
    public class UserProcessor
    {
        public delegate void UserProcesserEventHandler(object source, EventArgs args);

        public event UserProcesserEventHandler UserProcessed;

        public void ProcessUser()
        {
            Console.WriteLine("Processing User...");
            Thread.Sleep(2500);
            OnUserProcessed();
        }

        protected virtual void OnUserProcessed()
        {
            if (UserProcessed != null)
            {
                UserProcessed(this, EventArgs.Empty);
            }
        }
    }
}
