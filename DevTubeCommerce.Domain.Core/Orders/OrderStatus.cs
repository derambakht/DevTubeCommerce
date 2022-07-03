using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Orders
{
    public enum OrderStatus
    {
        Registerd = 10,
        InProgress = 20,
        Approved = 30,
        Reject = 40,
    }
}
