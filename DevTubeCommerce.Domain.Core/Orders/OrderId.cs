using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Orders
{
    public sealed class OrderId : StronglyTypedId<OrderId>
    {
        public OrderId(Guid value) : base(value)
        {
        }
    }
}
