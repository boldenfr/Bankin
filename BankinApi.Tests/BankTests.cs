using NUnit.Framework;

namespace BankinApi.Tests
{
    [TestFixture]
    public class BankTests : CommonTests
    {
        [Test]
        public void ListBanks()
        {
            using (var client = CreateClient())
            {
                var result = client.GetBanks();
                Assert.IsNotNull(result);
                Assert.Greater(result.Count, 100);
            }
        }

        [Test]
        public void GetBank()
        {
            const long bankId = 64;

            using (var client = CreateClient())
            {
                var result = client.GetBank(bankId);
                Assert.IsNotNull(result);
                Assert.AreEqual("bank", result.ResourceType);
                Assert.AreEqual("/v2/banks/" + bankId, result.ResourceUri);
                Assert.AreEqual(bankId, result.Id);
                Assert.AreEqual(2, result.Form.Length);
            }
        }
    }
}
