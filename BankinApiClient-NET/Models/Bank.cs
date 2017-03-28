using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class Bank : Hash
    {
        public string Name { get; set; }

        public BankField[] Form { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("automatic_refresh")]
        public bool AutomaticRefresh { get; set; }
    }

    public sealed class BankField
    {
        public string Label { get; set; }
        public string Type { get; set; }
        public string IsNum { get; set; }
        public int? MaxLength { get; set; }
    }
}
