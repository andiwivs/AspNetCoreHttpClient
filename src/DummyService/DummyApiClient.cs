using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace DummyService
{
    public class DummyApiClient
    {
        private readonly HttpClient _client;

        public DummyApiClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<string[]> GetValues()
        {
            var response = await _client.GetStringAsync("values").ConfigureAwait(false);
            
            return JsonConvert.DeserializeObject<string[]>(response);
        }
    }
}
