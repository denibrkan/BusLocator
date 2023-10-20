using BusLocator.DAL.Interfaces.Repositories;
using BusLocator.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BusLocator.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            services.AddScoped<ILineRepository, LineRepository>();

            return services;
        }
    }
}
