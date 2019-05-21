using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.Services
{
    public class StorageService<T> : IStorageService<T>
    {
        private readonly Dictionary<string, T> _values;

        public StorageService()
        {
            _values = new Dictionary<string, T>();
        }

        public async Task SetValue(string key, T value)
        {
            _values[key] = value;
            await Task.CompletedTask;
        }

        public async Task<T> GetValue(string key)
        {
            return await Task.FromResult(_values[key]);
        }
    }
}
