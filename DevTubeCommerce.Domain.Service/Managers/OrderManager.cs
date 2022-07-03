using DevTubeCommerce.Domain.Core.Customers;
using DevTubeCommerce.Domain.Core.Orders;
using DevTubeCommerce.Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Service.Managers
{
    public class OrderManager : IOrderManager
    {
        public Task CancelOrder(OrderId orderId, CustomerId customerId)
        {
            throw new NotImplementedException();
        }

        public Task CancelOrderWithAdmin(OrderId orderId, CustomerId customerId)
        {
            throw new NotImplementedException();
        }


        public Task RegisterOrder(CustomerId customerId, string address, string postalCode, string phone, List<OrderItemData> orderItems)
        {
            //steps :
            // 1- چک کردن موجودی کالاهای سفارش از انبار => با انبار کار کنیم
            // 2- ثبت سفارش و دریافت کد رهگیری سفارش
            // ? - ارسال برای پرداخت سفارش از طریق پرداخت آنلاین => سراغ سیستم پرداخت آنلاین
            // 3- کم کردن موجودی این کالا از انبار => سروقت بخش انبار
            // 4- ارسال این سفارش به کارتابل کارمندان فروش => ارسال به بخش داشبورد
            // 5- 

            return Task.FromResult(customerId);
        }
    }
}
