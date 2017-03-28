using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class Stock
    {
        public int Id { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        public decimal Quantity { get; set; }

        [JsonProperty("total_value")]
        public decimal TotalValue { get; set; }

        [JsonProperty("average_purchase_price")]
        public decimal AveragePurchasePrice { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public string Ticker { get; set; }

        [JsonProperty("stock_key")]
        public string StockKey { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        public string Isin { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        public string Marketplace { get; set; }

        public string Label { get; set; }

        [JsonProperty("value_date")]
        public DateTime ValueDate { get; set; }
    }
}
