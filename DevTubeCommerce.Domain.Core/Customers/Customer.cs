using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Customers
{
    public class Customer : AggregateRoot<CustomerId>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Mobile { get; private set; }

        private readonly List<AddressInfo> _addressInfoes = new List<AddressInfo>();
        public IReadOnlyList<AddressInfo> AddressInfoes => _addressInfoes;

        internal static Customer CreateNew(string firstName,string lastName, string mobile, List<AddressInfoData> addressList)
        {
            return new Customer(firstName, lastName, mobile, addressList);
        }

        private void BuildAddressInfoes(List<AddressInfoData> addressList)
        {
            foreach (var item in addressList)
            {
                var addressInfo = AddressInfo.CreateNew(Id, item.PostalCode, item.Address, item.Title);
                _addressInfoes.Add(addressInfo);
            }
        }

        public Customer(string firstName, string lastName, string mobile, List<AddressInfoData> addressList )
        {
            FirstName = firstName;
            LastName = lastName;
            Mobile = mobile;
            BuildAddressInfoes(addressList);
        }

        private Customer()
        {

        }
    }
}
