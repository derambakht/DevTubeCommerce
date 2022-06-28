using DevTubeCommerce.Domain.Core.Catalogs.Features;
using DevTubeCommerce.Infrastructure.Base;
using DevTubeCommerce.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Infrastructure.Repositories.Catalog
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly CommerceContext context;

        public FeatureRepository(CommerceContext context)
        {
            this.context = context;
        }

        public async Task<Feature> GetById(FeatureId featureId)
        {
            return await context.Features.FindAsync(featureId);
        }

        public async Task<FeatureId> Insert(Feature feature)
        {
            await context.AddAsync(feature);
            return feature.Id;
        }

        public async Task Update(Feature feature)
        {
            var currentFeature = await context.Features.FindAsync(feature.Id);

            if (currentFeature == null) throw new DatabaseException("feature Id in not valid");
            currentFeature.Update(feature);
            //call save changes from UnitOfWork

        }

        public void Delete(FeatureId featureId)
        {
            //1 => get feature from db with featureId
            //====> remove from dbContext
            //======>SaveChanges

            //2 => create newFeature with featureId
            //====> remove from dbContext
            //======>SaveChanges
            var feature = Feature.CreateNewForDelete(featureId);
            context.Remove(feature);
            //call save changes from UnitOfWork
        }

    }
}
