using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductListWithCart.Application.Interfaces;
using ProductListWithCart.Application.Queries.Desserts;
using ProductListWithCart.Application.Repositories;
using ProductListWithCart.DataAccess.Context;
using ProductListWithCart.DataAccess.Repositories;

namespace ProductListWithCart.IoC
{
    public static class AppDependencies
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMenuContext>((sp) => new MenuContext(
                configuration.GetValue<string>("Database")!,
                configuration.GetValue<string>("ConnectionStrings:Default")!
            ));
            services.AddScoped<IDessertsRepository, DessertsRepository>();
            services.AddScoped<IGetDesserts, GetDesserts>();
        }
    }
}
