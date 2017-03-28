using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class Account : Hash
    {
        public string Name { get; set; }

        public decimal Balance { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        public int Status { get; set; }

        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public Hash Item { get; set; }

        public Hash Bank { get; set; }

        [JsonProperty("loan_details")]
        public AccountLoan LoanDetails { get; set; }

        [JsonProperty("savings_details")]
        public AccountSavings SavingsDetails { get; set; }
    }

    public sealed class AccountSavings
    {
        [JsonProperty("opening_date")]
        public DateTime OpeningDate { get; set; }

        [JsonProperty("interest_rate")]
        public decimal InterestRate { get; set; }

        public decimal Ceiling { get; set; }
    }
}
