using DevTubeCommerce.Domain.Core.Catalogs.Products;
using DevTubeCommerce.Domain.Core.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Shared
{
    public record class OrderItemData
    {
        public ProductId ProductId { get; init; }
        public int ItemCount { get; init; }
        public double Price { get; init; }

        public OrderItemData(ProductId productId, int itemCount, double price)
        {
            ProductId = productId;
            ItemCount = itemCount;
            Price = price;
        }
    }
}
