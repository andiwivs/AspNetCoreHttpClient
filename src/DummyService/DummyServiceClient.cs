using System.Threading.Tasks;

namespace DummyService
{
    public class DummyServiceClient : IProvideValues
    {
        private readonly DummyApiClientFactory _clientFactory;

        public DummyServiceClient(DummyApiClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<string[]> GetValues()
        {
            var client = _clientFactory.Create();

            return await client.GetValues();
        }
    }
}
