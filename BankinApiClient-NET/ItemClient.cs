using System.Collections.Generic;
using System.Text;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient
    {
        public string Connect(long bankId, string accessToken, string redirectUrl = null)
        {
            var stringBuilder = new StringBuilder(BaseAddress.ToString());
            stringBuilder.AppendFormat("v2/items/connect?bank_id={0}&client_id={1}&access_token={2}", bankId, ClientId, accessToken);
            if (redirectUrl != null)
            {
                stringBuilder.AppendFormat("&redirect_url={0}", redirectUrl);
            }
            return stringBuilder.ToString();
        }

        public List<Item> GetItems()
        {
            var queryParams = new Dictionary<string, string> {{"limit", "100"}};
            var uri = CreateUri("items", queryParams);
            return GetPaginatedResult<Item>(uri);
        }

        public Item GetItem(long id)
        {
            var uri = CreateUri("items/" + id, null);
            return GetAsync<Item>(uri);
        }

        public string EditItem(long itemId, string accessToken, string redirectUrl = null)
        {
            var stringBuilder = new StringBuilder(BaseAddress.ToString());
            stringBuilder.AppendFormat("v2/items/{0}/edit?client_id={1}&access_token={2}", itemId, ClientId, accessToken);
            if (redirectUrl != null)
            {
                stringBuilder.AppendFormat("&redirect_url={0}", redirectUrl);
            }
            return stringBuilder.ToString();
        }

        public void Refresh(long id)
        {
            var uri = CreateUri(string.Format("items/{0}/refresh", id), null);
            PostAsync<object, object>(uri, null);
        }
        
        public RefreshStatus GetItemResRefreshStatus(long itemId, string authToken)
        {
            AddRequestHeader("Authorization", "Bearer " + authToken);
            var uri = CreateUri(string.Format("items/{0}/refresh/status", itemId), null);
            return GetAsync<RefreshStatus>(uri);
        }

        public void SendMfa(long itemId, string otp)
        {
            var queryParams = new Dictionary<string, string> {{"otp", otp}};
            var uri = CreateUri(string.Format("items/{0}/mfa", itemId), queryParams);
            PostAsync<object, object>(uri, null);
        }
    }
}
