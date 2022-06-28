using DevTubeCommerce.Application.Contract.Dto.Catalog;
using DevTubeCommerce.Application.Contract.Interfaces.Catalog;
using DevTubeCommerce.Domain.Core.Catalogs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Application.Services.Catalog
{
    public class FeatureService : IFeatureService
    {
        public Task Add(FeatureDto model)
        {
           var feature = Feature.CreateNew(model.Title, model.Description, model.SortOrder);

           //insert to db
           //=> 1.call Repository
           //=> 2.create DbContext
        }

        public Task Edit(FeatureDto model)
        {
            throw new NotImplementedException();
        }

        public Task<List<FeatureDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<FeatureDto> GetById()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
