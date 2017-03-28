using System;
using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public sealed class RefreshStatus
    {
        public ItemStatus Status { get; set; }

        public MfaObject Mfa { get; set; }
        
        [JsonProperty("refreshed_at")]
        public DateTime RefreshedAt { get; set; }

        [JsonProperty("refreshed_accounts_count")]
        public int? RefreshedAccountsCount { get; set; }

        [JsonProperty("total_accounts_count")]
        public int? TotalAccountsCount { get; set; }
    }

    public sealed class MfaObject
    {
        public string Label { get; set; }
        
        [JsonProperty("is_numeric")]
        public bool IsNumeric { get; set; }
    }
}
