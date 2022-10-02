using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests.BLL.Services
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void RegisterMustThrowArgumentNullExceptionWhenInvalidFirstName()
        {
            var userService = new UserService();

            var userRegistrationData = new UserRegistrationData()
            {
                FirstName = null,
            };

            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));

            userRegistrationData.FirstName = "";
            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));
        }

        [Test]
        public void RegisterMustThrowArgumentNullExceptionWhenInvalidLastName()
        {
            var userService = new UserService();

            var userRegistrationData = new UserRegistrationData()
            {
                LastName = null,
            };

            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));

            userRegistrationData.LastName = "";
            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));
        }

        [Test]
        public void RegisterMustThrowArgumentNullExceptionWhenInvalidPassword()
        {
            var userService = new UserService();

            var userRegistrationData = new UserRegistrationData()
            {
                Password = null,
            };

            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));

            userRegistrationData.Password = "";
            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));
        }

        [Test]
        public void RegisterMustThrowArgumentNullExceptionWhenInvalidEmail()
        {
            var userService = new UserService();

            var userRegistrationData = new UserRegistrationData()
            {
                Email = null,
            };

            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));

            userRegistrationData.Email = "";
            Assert.Throws<ArgumentNullException>(() => userService.Register(userRegistrationData));
        }
    }
}