using NUnit.Framework;
using TaskManagementAPI;
using Moq;
using Microsoft.Extensions.Configuration;

namespace TaskTest
{
    public class AuthServiceTests
    {
        [Test]
        public void Authenticate_ValidUser_ReturnsToken()
        {
            var mockTokenService = new Mock<ITokenService>();
            mockTokenService
                .Setup(t => t.GenerateToken("yugaraj", Role.Admin.ToString()))
                .Returns("dummy-token");

            var authService = new AuthService(mockTokenService.Object);

            var login = new UserLogin { Username = "yugaraj", Password = "pass" };
            var result = authService.Authenticate(login);

            Assert.IsNotNull(result);
            Assert.AreEqual("dummy-token", result);
        }

    }
}
