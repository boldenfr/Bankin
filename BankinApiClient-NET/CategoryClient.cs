using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public List<Category> GetCategories()
        {
            var queryParams = new Dictionary<string, string> { {"limit", "100"} };
            var uri = CreateUri("categories", queryParams);
            return GetPaginatedResult<Category>(uri);
        }

        public Category GetCategory(long categoryId)
        {
            var uri = CreateUri("categories/" + categoryId, null);
            return GetAsync<Category>(uri);
        }
    }
}
