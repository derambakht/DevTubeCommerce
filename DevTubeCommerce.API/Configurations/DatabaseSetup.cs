using DevTubeCommerce.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace DevTubeCommerce.API.Configurations
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            string connString = configuration.GetConnectionString("CommerceConnection");

            services.AddDbContext<CommerceContext>(options =>
            {
                options.UseSqlServer(connString,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                });
            });
        }
    }
}
