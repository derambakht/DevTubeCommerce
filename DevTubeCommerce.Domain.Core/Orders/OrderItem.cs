using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Products;
using DevTubeCommerce.Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Orders
{
    public class OrderItem : Entity<Guid>
    {
        public OrderId OrderId { get; private set; }
        public ProductId ProductId { get; private set; }
        public int ItemCount { get; private set; }
        public double Price { get; set; }

        internal static OrderItem CreateNew(OrderId orderId, ProductId productId, int itemCount, double price)
        {
            return new OrderItem(orderId, productId, itemCount, price);
        }

        private OrderItem(OrderId orderId, ProductId productId, int itemCount, double price)
        {
            OrderId = orderId;
            ProductId = productId;
            ItemCount = itemCount;
            Price = price;
        }

        private OrderItem()
        {

        }
    }
}
