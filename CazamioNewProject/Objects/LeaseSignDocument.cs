using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Objects
{
    public class LeaseSignDocument
    {
        public TemplatesNameByMarketplacesInfo TemplatesNameByMarketplaces { get; set; }

        public static LeaseSignDocument Generate()
        {
            return new LeaseSignDocument
            {
                TemplatesNameByMarketplaces = CreateTemplatesNameByMarketplacesInfo(),
            };
        }

        public class TemplatesNameByMarketplacesInfo
        {
            public string FirstNameForMySpace { get; set; }
            public string SecondNameForMySpace { get; set; }
        }

        private static TemplatesNameByMarketplacesInfo CreateTemplatesNameByMarketplacesInfo()
        {
            return new TemplatesNameByMarketplacesInfo
            {
                FirstNameForMySpace = "My Space (first 12345)",
                SecondNameForMySpace = "My Space (Broker 12345 second)",
            };
        }
    }
}
