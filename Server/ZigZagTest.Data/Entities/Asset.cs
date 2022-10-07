using HotChocolate.AspNetCore.Authorization;
using System.Text.Json.Serialization;

namespace ZigZagTest.Data.Entities
{
    [Authorize]
    public class Asset
    {
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("change_24h")]
        public double Last24h { get; set; }
        [JsonPropertyName("change_7d")]
        public double Last7d { get; set; }
    }
}
