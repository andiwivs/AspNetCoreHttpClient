using Microsoft.Extensions.DependencyInjection;
using System;

namespace DummyService
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDummyService(this IServiceCollection services, Uri baseUri)
        {
            services.AddSingleton<DummyApiClientFactory>();
            services.AddHttpClient<DummyApiClient>(c => c.BaseAddress = baseUri);
            services.AddSingleton<IProvideValues, DummyServiceClient>();

            return services;
        }
    }
}
