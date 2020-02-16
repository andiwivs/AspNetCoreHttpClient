using Microsoft.Extensions.DependencyInjection;
using Polly;
using System;

namespace DummyService
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDummyService(this IServiceCollection services, Uri baseUri)
        {
            services.AddSingleton<DummyApiClientFactory>();
            services.AddSingleton<IProvideValues, DummyServiceClient>();

            services
                .AddHttpClient<DummyApiClient>(c => c.BaseAddress = baseUri)
                .AddTransientHttpErrorPolicy(builder =>
                    builder.WaitAndRetryAsync(new[]
                    {
                        TimeSpan.FromSeconds(1),
                        TimeSpan.FromSeconds(5),
                        TimeSpan.FromSeconds(10)
                    })
                )
                .AddTransientHttpErrorPolicy(builder =>
                    builder.RetryAsync(3));

            return services;
        }
    }
}
