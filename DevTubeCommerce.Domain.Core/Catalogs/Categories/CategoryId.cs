using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Catalogs.Categories
{
    public sealed class CategoryId : StronglyTypedId<CategoryId>
    {
        public CategoryId(Guid value) : base(value)
        {
        }
    }
}
