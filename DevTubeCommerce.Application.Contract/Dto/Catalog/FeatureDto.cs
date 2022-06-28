using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Application.Contract.Dto.Catalog
{
    public class FeatureDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
    }
}
