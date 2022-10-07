using ZigZagTest.Data.Entities;
using ZigZagTest.WebAPI.Services.Interfaces;

namespace ZigZagTest.WebAPI.Services
{
    public class CryptingUpService : ICryptingUpService
    {
        private readonly HttpClient _httpClient;

        public CryptingUpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://cryptingup.com/api/");
        }

        public async Task<List<Asset>?> GetSomeAssets() 
        {
            // to simplify I'm not passing the size parameter so it will use the default value
            // the size default value is 100 records
            var result = await _httpClient.GetFromJsonAsync<AssetsList>("assets");

            if (result != null && result.Assets != null && result.Assets.Count() > 0)
                return result.Assets.ToList();
            else return null;
        }

        public async Task<Asset?> GetAssetById(string id) 
        {
            var result = await _httpClient.GetFromJsonAsync<AssetInfo>($"assets/{id}");

            if (result != null && result.Asset != null)
                return result.Asset;
            else return null;
        }
    }
}
