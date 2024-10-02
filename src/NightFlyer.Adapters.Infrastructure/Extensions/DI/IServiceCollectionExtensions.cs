using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NightFlyer.Adapters.Infrastructure.Data;

namespace NightFlyer.Adapters.Infrastructure.Extensions.DI
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddAPIDbContext(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<ApiDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
