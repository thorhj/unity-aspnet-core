using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public interface IDataService
    {
        Task SetValue(string key, string value);
        Task<string> GetValue(string key);
    }
}