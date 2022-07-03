using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Customers
{
    public sealed class CustomerId : StronglyTypedId<CustomerId>
    {
        public CustomerId(Guid value) : base(value)
        {
        }
    }
}
