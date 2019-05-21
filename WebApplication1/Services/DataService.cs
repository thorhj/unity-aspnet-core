using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class DataService : IDataService
    {
        private readonly IStorageService<string> _storageService;

        public DataService(IStorageService<string> storageService)
        {
            _storageService = storageService;
        }

        public async Task SetValue(string key, string value)
        {
            await _storageService.SetValue(key, value);
        }

        public async Task<string> GetValue(string key)
        {
            return await _storageService.GetValue(key);
        }
    }
}
