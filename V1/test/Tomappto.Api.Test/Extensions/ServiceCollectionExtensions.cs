using Microsoft.Extensions.DependencyInjection;

namespace Tomappto.Api.Test.Extensions
{
    internal static class ServiceCollectionExtensions
    {
        public static void Replace<TRegisteredType>(this IServiceCollection services, TRegisteredType replacement)
        {
            for (var i = 0; i < services.Count; i++)
            {
                if (services[i].ServiceType == typeof(TRegisteredType))
                {
                    services[i] = new ServiceDescriptor(typeof(TRegisteredType), replacement);
                }
            }

        }

    }
}
