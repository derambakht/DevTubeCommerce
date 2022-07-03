using DevTubeCommerce.Domain.Core.Customers;
using DevTubeCommerce.Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Orders
{
    //Domain Service ===> Service = Manager
    public interface IOrderManager
    {
        Task RegisterOrder(CustomerId customerId, string address, string postalCode, string phone, List<OrderItemData> orderItems);
        Task CancelOrder(OrderId orderId, CustomerId customerId);
        Task CancelOrderWithAdmin(OrderId orderId, CustomerId customerId);
    }
}
