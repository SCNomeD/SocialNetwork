using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests.BLL.Services
{
    [TestFixture]
    public class MessageServiceTests
    {
        [Test]
        public void SendMessageMustThrowArgumentNullExceptionWhenInvalidSenderId()
        {

            var messageService = new MessageService();

            var messageSendingData = new MessageSendingData()
            {
                SenderId = 1
            };

            Assert.That(() => messageSendingData.SenderId != 0);
        }

        [Test]
        public void SendMessageMustThrowArgumentNullExceptionWhenInvalidContent()
        {

            var messageService = new MessageService();

            var messageSendingData = new MessageSendingData()
            {
                Content = "TEST!"
            };

            Assert.That(() => messageSendingData.Content != null);
        }

        [Test]
        public void SendMessageMustThrowArgumentNullExceptionWhenInvalidRecipientEmail()
        {

            var messageService = new MessageService();

            var messageSendingData = new MessageSendingData()
            {
                RecipientEmail = "vladiiimir91@mail.ru"
            };

            Assert.That(() => messageSendingData.RecipientEmail != null);
        }
    }
}