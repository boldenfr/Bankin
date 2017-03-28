using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class PagedArrayResult<T>
    {
        public T[] Resources { get; set; }

        public Pagination Pagination { get; set; }
    }

    public sealed class Pagination
    {
        [JsonProperty("previous_uri")]
        public string PreviousUri { get; set; }

        [JsonProperty("next_uri")]
        public string NextUri { get; set; }
    }
}
