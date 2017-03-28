namespace BankinApi.Client.Models
{
    public sealed class Item : Hash
    {
        public ItemStatus Status { get; set; }

        public Hash Bank { get; set; }

        public Hash[] Accounts { get; set; }
    }
}
