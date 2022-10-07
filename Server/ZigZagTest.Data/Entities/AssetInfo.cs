using HotChocolate.AspNetCore.Authorization;
using System.Text.Json.Serialization;

namespace ZigZagTest.Data.Entities
{
    [Authorize]
    public class AssetInfo
    {
        [JsonPropertyName("asset")]
        public Asset Asset { get; set; }
    }
}
