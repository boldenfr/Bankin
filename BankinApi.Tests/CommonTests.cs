using System;
using System.Globalization;
using BankinApi.Client;
using BankinApi.Client.Models;
using NUnit.Framework;

namespace BankinApi.Tests
{
    public class CommonTests
    {
        protected string ClientId
        {
            get { return "YOUR_CLIENT_ID"; }
        }

        protected string ClientSecret
        {
            get { return "YOUR_CLIENT_SECRET"; }
        }
        
        protected string TimedId
        {
            get
            {
                return DateTime.UtcNow.ToString("yyMMdd-HHmmssfff", CultureInfo.InvariantCulture);
            }
        }

        public User TestUser { get; private set; }

        protected ApiClient CreateClient()
        {
            var client = new ApiClient(ClientId, ClientSecret);
            return client;
        }

        [OneTimeSetUp]
        public void CreateTestUser()
        {
            using (var client = CreateClient())
            {
                var user = new User { Email = "john.doe+" + TimedId + "@mail.fr", Password = "PASSWORD" };
                TestUser = client.CreateUser(user);
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            using (var client = CreateClient())
            {
                client.DeleteAllUsers();
            }
        }
    }
}
