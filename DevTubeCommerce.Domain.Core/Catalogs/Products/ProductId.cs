using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Catalogs.Products
{
    public sealed class ProductId : StronglyTypedId<ProductId>
    {
        public ProductId(Guid value):base(value)
        {

        }
    }
}
