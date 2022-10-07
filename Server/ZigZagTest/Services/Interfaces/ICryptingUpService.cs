using ZigZagTest.Data.Entities;

namespace ZigZagTest.WebAPI.Services.Interfaces
{
    public interface ICryptingUpService
    {
        Task<List<Asset>?> GetSomeAssets();

        Task<Asset?> GetAssetById(string id);
    }
}
