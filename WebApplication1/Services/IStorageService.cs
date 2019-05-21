using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface IStorageService<T>
    {
        Task SetValue(string key, T value);
        Task<T> GetValue(string key);
    }
}