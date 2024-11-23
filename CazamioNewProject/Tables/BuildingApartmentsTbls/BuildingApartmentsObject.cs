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
        public StatusColumnInfo StatusColumn { get; set; }

        public static BuildingApartments Generate()
        {
            return new BuildingApartments
            {
                UnitColumn = CreateUnitColumnInfo(),
                StatusColumn = CreateStatusColumnInfo(),
            };
        }

        public class UnitColumnInfo
        {
            public string UnitForNineNineNineEightSaintJohnsonPlace { get; set; }
        }

        public class StatusColumnInfo
        {
            public string DepositReceived { get; set; }
        }

        private static UnitColumnInfo CreateUnitColumnInfo()
        {
            return new UnitColumnInfo
            {
                UnitForNineNineNineEightSaintJohnsonPlace = "",
            };
        }

        private static StatusColumnInfo CreateStatusColumnInfo()
        {
            return new StatusColumnInfo
            {
                DepositReceived = "Deposit Received",
            };
        }
    }
}
