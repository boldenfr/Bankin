using Newtonsoft.Json;

namespace BankinApi.Client.Models
{
    public class User : Hash
    {
        public string Uuid { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
