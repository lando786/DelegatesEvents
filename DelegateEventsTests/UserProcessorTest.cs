using DelegatesEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DelegateEventsTests
{
    [TestClass]
    public class UserProcessorTest
    {
        private bool _eventRaised = false;
        private UserProcessor _processor;

        [TestInitialize]
        public void Setup()
        {
            _processor = new UserProcessor();
            _processor.UserProcessed += delegate (object sender, EventArgs args)
            {
                _eventRaised = true;
            };
        }

        [TestMethod]
        public void WhenCallingProcessUserEventShouldBeKickedOff()
        {
            _processor.ProcessUser();
            Assert.IsTrue(_eventRaised);
        }
    }
}
