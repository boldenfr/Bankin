using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BankinApi.Client.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemStatus
    {
        Ok = 0,

        [EnumMember(Value = "just_added")]
        JustAdded = -2,

        [EnumMember(Value = "just_edited")]
        JustEdited = -3,

        [EnumMember(Value = "login_failed")]
        LoginFailed = 402,

        [EnumMember(Value = "needs_human_action")]
        NeedsHumanAction = 429,

        [EnumMember(Value = "could_not_refresh")]
        CouldNotRefresh = 1003,

        [EnumMember(Value = "not_supported")]
        NotSupported = 1005,

        [EnumMember(Value = "disabled_temporarily")]
        DisabledTemporarily = 1007,

        Incomplete = 1009,

        [EnumMember(Value = "needs_manual_refresh")]
        NeedsManualRefresh = 1010,

        Migration = 1099,

        [EnumMember(Value = "info_required")]
        InfoRequired = 700,

        [EnumMember(Value = "invalid_creds")]
        InvalidCreds = 800,

        Authenticating = 100,

        [EnumMember(Value = "retrieving_data")]
        RetrievingData = 150,

        Finished = 205,

        [EnumMember(Value = "finished_error")]
        FinishedError = 505
    }
}
