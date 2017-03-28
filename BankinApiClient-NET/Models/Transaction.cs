using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class Transaction : Hash
    {
        public string Description { get; set; }

        [JsonProperty("raw_description")]
        public string RawDescription { get; set; }

        public decimal Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        public DateTime Date { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        public Hash Account { get; set; }

        public Hash Category { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
