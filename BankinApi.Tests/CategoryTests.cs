using NUnit.Framework;

namespace BankinApi.Tests
{
    [TestFixture]
    public class CategoryTests : CommonTests
    {
        [Test]
        public void GetCategoriesAndSpecigicCategory()
        {
            using (var client = CreateClient())
            {
                var result = client.GetCategories();
                Assert.IsNotNull(result);
                Assert.Greater(result.Count, 101);

                var item = client.GetCategory(result[102].Id);
                Assert.IsNotNull(item);
                Assert.IsNotEmpty(item.Name);
                Assert.IsNotNull(item.Parent);
            }
        }
    }
}
