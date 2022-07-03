using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.User
{
    public sealed class UserId : StronglyTypedId<UserId>
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}
