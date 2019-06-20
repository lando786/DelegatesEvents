using DelegatesEvents;
using Microsoft;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEventsTests
{
    [TestClass]
    public class EmailNotificationServiceTest
    {
        private Mock<IEmailNotificationService> _emailService;
        private UserProcessor _userProcessor;

        [TestMethod]
        public void OnUserProcessedShouldBeCalledAfterEventKickedOffByUserProcessor()
        {
            _userProcessor.ProcessUser();
            _emailService.Verify(x => x.OnUserProcessed(It.IsAny<object>(), It.IsAny<EventArgs>()), Times.AtLeastOnce);
        }

        [TestInitialize]
        public void Setup()
        {
            _userProcessor = new UserProcessor();
            _emailService = new Mock<IEmailNotificationService>();
            _userProcessor.UserProcessed += _emailService.Object.OnUserProcessed;
        }
    }
}
