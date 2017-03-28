using NUnit.Framework;

namespace BankinApi.Tests
{
    [TestFixture]
    public class ItemTests : CommonTests
    {
        [Test]
        public void Connect()
        {
            const string expectedUri = "https://sync.bankin.com/v2/items/connect?bank_id=64&client_id=d7a60888db9e4d83a85fb5834e6aec54&access_token=ACCESS_TOKEN&redirect_url=REDIRECT_URL";
            using (var client = CreateClient())
            {
                var result = client.Connect(64, "ACCESS_TOKEN", "REDIRECT_URL");
                Assert.AreEqual(expectedUri, result);
            }
        }
    }
}
