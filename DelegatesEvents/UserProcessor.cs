using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEvents
{
    public class UserProcessor
    {
        public delegate void UserProcesseEventHandler(object source, EventArgs args);

        public event UserProcesseEventHandler UserProcessed;

        public void ProcessUser()
        {
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
