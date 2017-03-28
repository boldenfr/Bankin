using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public class AuthenticatedUser
    {
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "expires_at")]
        public DateTime ExpiresAt { get; set; }
    }
}