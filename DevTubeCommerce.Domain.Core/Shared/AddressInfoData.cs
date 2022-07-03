using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Shared
{
    public record class AddressInfoData
    {
        public string PostalCode { get; init; }
        public string Address { get; init; }
        public string Title { get; init; }
    }
}
