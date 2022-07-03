using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Customers
{
    public class AddressInfo : Entity<Guid>
    {
        public CustomerId CustomerId { get; private set; }
        public string PostalCode { get; private set; }
        public string Address { get; private set; }
        public string Title { get; private set; }

        internal static AddressInfo CreateNew(CustomerId customerId, string postalCode, string address, string title)
        {
            return new AddressInfo(customerId, postalCode, address, title);
        }

        private AddressInfo(CustomerId customerId, string postalCode, string address, string title)
        {
            CustomerId = customerId;
            PostalCode = postalCode;
            Address = address;
            Title = title;
        }

        private AddressInfo()
        {

        }
    }
}
