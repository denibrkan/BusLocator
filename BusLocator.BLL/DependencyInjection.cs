using BusLocator.BLL.Interfaces.Services;
using BusLocator.BLL.Services;
using BusLocator.BLL.Utilities.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace BusLocator.BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<ILineService, LineService>();

            return services;
        }
    }
}
