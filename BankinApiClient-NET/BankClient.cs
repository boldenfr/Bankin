using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public List<Bank> GetBanks()
        {
            var queryParams = new Dictionary<string, string> {{"limit", "100"}};
            var uri = CreateUri("banks", queryParams);
            return GetPaginatedResult<Bank>(uri);
        }

        public Bank GetBank(long id)
        {
            var uri = CreateUri("banks/" + id, null);
            var result = GetAsync<Bank>(uri);
            return result;
        }
    }
}
