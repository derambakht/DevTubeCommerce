using DevTubeCommerce.Domain.Core.Catalogs.Features;
using DevTubeCommerce.Infrastructure.Patterns;
using DevTubeCommerce.Infrastructure.Repositories.Catalog;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Infrastructure
{
    public static class InfrastructureSetup
    {
        public static void AddInfrastructureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
        }
    }
}
