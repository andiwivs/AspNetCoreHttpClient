using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication1.Infrastructure
{
    public class LocalValuesProvider : IProvideValues
    {
        private readonly IHttpClientFactory _factory;

        public LocalValuesProvider(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<string[]> GetValues()
        {
            var client = _factory.CreateClient("localValuesClient");

            var response = await client.GetStringAsync("http://localhost:5000/api/values");
            
            return JsonConvert.DeserializeObject<string[]>(response);
        }
    }
}
