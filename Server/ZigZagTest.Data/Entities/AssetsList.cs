using HotChocolate.AspNetCore.Authorization;
using System.Text.Json.Serialization;

namespace ZigZagTest.Data.Entities
{
    [Authorize]
    public class AssetsList
    {
        [JsonPropertyName("assets")]
        public IEnumerable<Asset> Assets { get; set; }
    }
}
