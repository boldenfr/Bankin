using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class AccountLoan
    {
        [JsonProperty("next_payment_date")]
        public DateTime NextPaymentDate { get; set; }

        [JsonProperty("next_payment_amount")]
        public decimal NextPaymentAmount { get; set; }

        [JsonProperty("maturity_date")]
        public DateTime MaturityDate { get; set; }

        [JsonProperty("opening_date")]
        public DateTime OpeningDate { get; set; }

        [JsonProperty("interest_rate")]
        public decimal InterestRate { get; set; }

        public string Type { get; set; }

        [JsonProperty("borrowed_capital")]
        public decimal BorrowedCapital { get; set; }

        [JsonProperty("repaid_capital")]
        public decimal RepaidCapital { get; set; }

        [JsonProperty("remaining_capital")]
        public decimal RemainingCapital { get; set; }
    }
}
