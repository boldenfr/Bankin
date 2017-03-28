using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public PagedArrayResult<Account> GetAccounts()
        {
            var queryParams = new Dictionary<string, string> {{"limit", "10"}};
            var uri = CreateUri("accounts", queryParams);
            var result = GetAsync<PagedArrayResult<Account>>(uri);
            return result;
        }

        public Account GetAccount(long id)
        {
            var uri = CreateUri("accounts/" + id, null);
            var result = GetAsync<Account>(uri);
            return result;
        }
    }
}
