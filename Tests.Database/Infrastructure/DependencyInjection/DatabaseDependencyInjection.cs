using Microsoft.Extensions.DependencyInjection;
using Tests.Database.Infrastructure.UnitOfWorks;

namespace Tests.Database.Infrastructure.DependencyInjection
{
    public class DatabaseDependencyInjection
    {
        public static void Initialize(IServiceCollection services)
        {
            // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
