using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Catalogs.Features
{
    public sealed class FeatureId: StronglyTypedId<FeatureId>
    {
        public FeatureId(Guid value): base(value)
        {

        }
    }
}
