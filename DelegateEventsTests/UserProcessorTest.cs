using DelegatesEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DelegateEventsTests
{
    [TestClass]
    public class UserProcessorTest
    {
        private bool eventRaised = false;
        private UserProcessor processor;

        [TestInitialize]
        public void Setup()
        {
            processor = new UserProcessor();
            processor.UserProcessed += delegate (object sender, EventArgs args)
            {
                eventRaised = true;
            };
        }

        [TestMethod]
        public void WhenCallingProcessUserEventShouldBeKickedOff()
        {
            processor.ProcessUser();
            Assert.IsTrue(eventRaised);
        }
    }
}
