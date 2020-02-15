using System.Threading.Tasks;

namespace WebApplication1.Infrastructure
{
    public interface IProvideValues
    {
        Task<string[]> GetValues();
    }
}
