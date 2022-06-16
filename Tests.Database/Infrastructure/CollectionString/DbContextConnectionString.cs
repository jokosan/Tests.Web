using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tests.Database.Context;

namespace Tests.Database.Infrastructure.CollectionString
{
    public class DbContextConnectionString
    {
        public static void Initialize(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UserTestingDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddDbContext<ApplicationIdentityDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
