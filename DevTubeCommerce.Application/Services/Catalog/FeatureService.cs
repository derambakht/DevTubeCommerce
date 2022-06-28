using DevTubeCommerce.Application.Contract.Dto.Catalog;
using DevTubeCommerce.Application.Contract.Interfaces.Catalog;
using DevTubeCommerce.Domain.Core.Catalogs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTubeCommerce.Infrastructure.Patterns;

namespace DevTubeCommerce.Application.Services.Catalog
{
    public class FeatureService : IFeatureService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IFeatureRepository featureRepository;

        public FeatureService(IUnitOfWork unitOfWork, IFeatureRepository featureRepository)
        {
            this.unitOfWork = unitOfWork;
            this.featureRepository = featureRepository;
        }
        public async Task Add(FeatureDto model)
        {
            var feature = Feature.CreateNew(model.Title, model.Description, model.SortOrder);
            await featureRepository.Insert(feature);
            await unitOfWork.SaveChanges();

            //insert to db
            //=> 1.call Repository
            //=> 2.create DbContext
        }

        public async Task Edit(FeatureDto model)
        {
            var feature = Feature.CreateNewForUpdate(model.Id, model.Title, model.Description, model.SortOrder);
            await featureRepository.Update(feature);
            await unitOfWork.SaveChanges();
        }

        public Task<List<FeatureDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<FeatureDto> GetById(Guid id)
        {
            var feature = await featureRepository.GetById(new FeatureId(id));
            return new FeatureDto
            {
                Title = feature.Title,
                Description = feature.Description,
                Id = id,
                SortOrder = feature.SortOrder,
            };
        }

        public async Task Remove(Guid id)
        {
            featureRepository.Delete(new FeatureId(id));
            await unitOfWork.SaveChanges();
        }
    }
}
