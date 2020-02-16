using Microsoft.Extensions.DependencyInjection;
using System;

namespace DummyService
{
    public class DummyApiClientFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DummyApiClientFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public DummyApiClient Create()
        {
            return _serviceProvider.GetRequiredService<DummyApiClient>();
        }
    }
}
