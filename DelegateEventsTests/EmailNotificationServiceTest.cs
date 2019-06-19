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
        private Mock<EmailNotificationService> _emailService;
        private UserProcessor _userProcessor;

        [TestMethod]
        public void EmailShouldBeSentAfterEventKickedOffByUserProcessor()
        {
            _userProcessor.ProcessUser();
            _emailService.Verify(x => x.SendEmail(), Times.Once);
        }

        [TestInitialize]
        public void Setup()
        {
            _userProcessor = new UserProcessor();
            _emailService = new Mock<EmailNotificationService>();

            _userProcessor.UserProcessed += _emailService.Object.OnUserProcessed;
        }
    }
}
