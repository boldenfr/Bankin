using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using BankinApi.Client.Models;

namespace BankinApi.Client
{
    public partial class ApiClient : HttpClient, IBankinApiClient
    {
        private const string BankinVersion = "2016-01-18";
        private const string BaseUrl = "https://sync.bankin.com/";

        public string ClientId { get; }
        public string ClientSecret { get; }
        
        public ApiClient(string clientId, string clientSecret)
        {
            BaseAddress = new Uri(BaseUrl);
            AddRequestHeader("Bankin-Version", BankinVersion);
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public void AddRequestHeader(string name, string value)
        {
            RemoveRequestHeader(name);
            DefaultRequestHeaders.Add(name, value);
        }

        public void RemoveRequestHeader(string name)
        {
            DefaultRequestHeaders.Remove(name);
        }

        private TResponse GetAsync<TResponse>(string uri)
        {
            var response = GetAsync(uri).Result;
            return HandleResult<TResponse>(response);
        }
        
        private TResponse PostAsync<TRequest, TResponse>(string uri, TRequest item)
        {
            var response = this.PostAsJsonAsync(uri, item).Result;
            return HandleResult<TResponse>(response);
        }
        
        private TResponse DeleteAsync<TResponse>(string uri)
        {
            var response = DeleteAsync(uri).Result;
            return HandleResult<TResponse>(response);
        }

        private static T HandleResult<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new APIException(response);
            }

            var result = response.Content.ReadAsAsync<T>().Result;
            return result;
        }

        private string CreateUri(string path, Dictionary<string, string> queryParams)
        {
            var stringBuilder = new StringBuilder(BaseUrl);
            stringBuilder.AppendFormat("v2/{0}?", path);
            if (queryParams != null)
            {
                foreach (var queryParam in queryParams)
                {
                    stringBuilder.AppendFormat("{0}={1}&", queryParam.Key, queryParam.Value);
                }
            }
            stringBuilder.AppendFormat("client_id={0}&client_secret={1}", ClientId, ClientSecret);
            return stringBuilder.ToString();
        }

        private string AppendCredentials(string uri)
        {
            return string.Format("{0}&client_id={1}&client_secret={2}", uri, ClientId, ClientSecret);
        }

        private List<T> GetPaginatedResult<T>(string uri)
        {
            var result = GetAsync<PagedArrayResult<T>>(uri);
            var array = new List<T>(result.Resources);
            if (!string.IsNullOrEmpty(result.Pagination.NextUri))
            {
                while (!string.IsNullOrEmpty(result.Pagination.NextUri))
                {
                    uri = AppendCredentials(result.Pagination.NextUri);
                    result = GetAsync<PagedArrayResult<T>>(uri);
                    array.AddRange(result.Resources);
                }
            }
            return array;
        }
    }
}
