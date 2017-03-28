using System;
using BankinApi.Client.Models;
using NUnit.Framework;

namespace BankinApi.Tests
{
    [TestFixture]
    internal class UserTests : CommonTests
    {
        [Test]
        public void CreateUser()
        {
            const string email = "toto@test.com";
            const string password = "Password";
            using (var client = CreateClient())
            {
                var user = new User {Email = email, Password = password };
                var result = client.CreateUser(user);
                Assert.IsNotNull(result);
                Assert.AreEqual(email, result.Email);
                Assert.AreEqual(password, result.Password);
                Assert.IsNotNull(result.Uuid);
            }
        }

        [Test]
        public void LogInAndLogOutUser()
        {
            using (var client = CreateClient())
            {
                var result = client.Authenticate(TestUser);
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.AccessToken);
                Assert.IsTrue(result.ExpiresAt > DateTime.Now);

                client.LogOut(result);
            }
        }
    }
}
