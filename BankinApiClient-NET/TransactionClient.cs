using System;
using System.Collections.Generic;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public List<Transaction> GetTransactions()
        {
            var queryParams = new Dictionary<string, string>
            {
                {"limit", "50"},
                {"until", DateTime.Today.ToString("yyyy-MM-dd")}
            };
            var uri = CreateUri("transactions", queryParams);
            return GetPaginatedResult<Transaction>(uri);
        }
    }
}
