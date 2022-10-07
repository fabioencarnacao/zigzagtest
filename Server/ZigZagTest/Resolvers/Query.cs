using ZigZagTest.Data.Entities;
using ZigZagTest.WebAPI.Services.Interfaces;

namespace ZigZagTest.WebAPI.Resolvers
{
    public class Query
    { 
        public Task<List<Asset>?> GetAssets([Service] ICryptingUpService _cryptingUpService)
        {
            return _cryptingUpService.GetSomeAssets();
        }

        public Task<Asset?> GetAsset(string id, [Service] ICryptingUpService _cryptingUpService)
        {
            return _cryptingUpService.GetAssetById(id);
        }
    }
}
