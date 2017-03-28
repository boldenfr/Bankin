using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public enum AccountType
    {
        Unknown = 1,

        Checking = 2,

        Savings = 4,

        Securities = 8,

        Card = 16,

        Loan = 32,

        [JsonProperty("share_savings_plan")]
        ShareSavingsPlan = 64,

        Pending = 128,

        [JsonProperty("life_insurance")]
        LifeInsurance = 256,

        Special = 512
    }
}
