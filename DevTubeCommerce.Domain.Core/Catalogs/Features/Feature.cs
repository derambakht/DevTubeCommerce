using DevTubeCommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Domain.Core.Catalogs.Features
{
    public class Feature:AggregateRoot<FeatureId>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int SortOrder { get; set; }

        public static Feature CreateNew(string title, string description, int sortOrder)
        {
            return new Feature(title, description, sortOrder);
        }

        private Feature(string title, string description, int sortOrder)
        {
            //validation
            Title = title;
            Description = description;
            SortOrder = sortOrder;
        }

        private Feature() { }
    }
}
