using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProductListWithCart.IoC
{
    public static class AppDependencies
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
        }
    }
}
