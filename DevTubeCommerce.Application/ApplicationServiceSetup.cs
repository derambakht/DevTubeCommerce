using DevTubeCommerce.Application.Contract.Interfaces.Catalog;
using DevTubeCommerce.Application.Services.Catalog;
using DevTubeCommerce.Domain.Core.Catalogs.Features;
using DevTubeCommerce.Infrastructure.Repositories.Catalog;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Application
{
    public static class ApplicationServiceSetup
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFeatureService, FeatureService>();
        }
    }
}
