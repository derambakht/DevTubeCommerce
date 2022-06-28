using DevTubeCommerce.Domain.Core.Catalogs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Shared
{
    public record class ProductFeatureValueData
    {
        public FeatureId FeatureId { get; init; }
        public string Value { get; init; }

        public ProductFeatureValueData(FeatureId featureId, string value)
        {
            Value = value;
            FeatureId = featureId;
        }
    }
}
