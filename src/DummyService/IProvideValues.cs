using System.Threading.Tasks;

namespace DummyService
{
    public interface IProvideValues
    {
        Task<string[]> GetValues();
    }
}
