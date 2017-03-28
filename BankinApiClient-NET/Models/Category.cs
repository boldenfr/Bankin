namespace BankinApi.Client.Models
{
    public sealed class Category : Hash
    {
        public string Name { get; set; }

        public Hash Parent { get; set; }
    }
}
