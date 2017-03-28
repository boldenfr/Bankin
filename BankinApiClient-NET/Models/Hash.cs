using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public class Hash
    {
        public long Id { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }
    }
}
