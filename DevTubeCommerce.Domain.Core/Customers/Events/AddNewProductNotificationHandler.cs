using DevTubeCommerce.Domain.Core.Catalogs.Products.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Customers.Events
{
    public class AddNewProductNotificationHandler : INotificationHandler<AddProductSendNotificationEvent>
    {
        public Task Handle(AddProductSendNotificationEvent notification, CancellationToken cancellationToken)
        {
            //send sms to All users
           return Task.FromResult(notification);
        }
    }
}
