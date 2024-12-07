using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public class BuildingApartmentsTable
    {
        public UnitColumnInfo UnitColumn { get; set; }
        public StatusColumnInfo StatusColumn { get; set; }
        public PriceColumnInfo PriceColumn { get; set; }
        public BedroomsColumnInfo BedroomsColumn { get; set; }
        public BathroomsColumnInfo BathroomsColumn { get; set; }

        public static BuildingApartmentsTable Generate()
        {
            return new BuildingApartmentsTable
            {
                UnitColumn = CreateUnitColumnInfo(),
                StatusColumn = CreateStatusColumnInfo(),
                PriceColumn = CreatePriceColumnInfo(),
                BedroomsColumn = CreateBedroomsColumnInfo(),
                BathroomsColumn = CreateBathroomsColumnInfo(),
            };
        }

        public class UnitColumnInfo
        {
            public string UnitForNineNineNineEightSaintJohnsonPlace { get; set; }
        }

        public class StatusColumnInfo
        {
            public string DepositReceived { get; set; }
            public string Vacant { get; set; }
        }

        public class PriceColumnInfo
        {
            public string Price { get; set; }
        }

        public class BedroomsColumnInfo
        {
            public string Bed { get; set; }
        }

        public class BathroomsColumnInfo
        {
            public string Bath { get; set; }
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
                Vacant = "Vacant",
            };
        }

        private static PriceColumnInfo CreatePriceColumnInfo()
        {
            return new PriceColumnInfo
            {
                Price = "",
            };
        }

        private static BedroomsColumnInfo CreateBedroomsColumnInfo()
        {
            return new BedroomsColumnInfo
            {
                Bed = "",
            };
        }

        private static BathroomsColumnInfo CreateBathroomsColumnInfo()
        {
            return new BathroomsColumnInfo
            {
                Bath = "",
            };
        }
    }
}
