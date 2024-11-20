using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Tables.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        public UnitColumnInfo UnitColumn { get; set; }

        public static BuildingApartments Generate()
        {
            return new BuildingApartments
            {
                UnitColumn = CreateUnitColumnInfo(),
            };
        }

        public class UnitColumnInfo
        {
            public string UnitForNineNineNineEightSaintJohnsonPlace { get; set; }
            public string FirstNameNewTenantMainApplicant { get; set; }
            public string LastNameNewTenantMainApplicant { get; set; }
        }

        private static UnitColumnInfo CreateUnitColumnInfo()
        {
            return new UnitColumnInfo
            {
                UnitForNineNineNineEightSaintJohnsonPlace = "",
                //FirstNameNewTenantMainApplicant = Name.FirstName(),
                //LastNameNewTenantMainApplicant = Name.LastName(),
            };
        }
    }
}
