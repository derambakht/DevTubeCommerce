using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Base
{
    public class BusinessRuleException:Exception
    {
        public BusinessRuleException(string message):base(message)
        {

        }
    }
}
