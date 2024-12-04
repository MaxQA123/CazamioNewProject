using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartmentsTable
    {
        public UnitColumnInfo UnitColumn { get; set; }
        public StatusColumnInfo StatusColumn { get; set; }
        public AgentColumnnInfo AgentColumn { get; set; }

        public static BuildingApartmentsTable Generate()
        {
            return new BuildingApartmentsTable
            {
                UnitColumn = CreateUnitColumnInfo(),
                StatusColumn = CreateStatusColumnInfo(),
                AgentColumn = CreateAgentColumnnInfo(),
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

        public class AgentColumnnInfo
        {
            public string NotAssigned { get; set; }
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

        private static AgentColumnnInfo CreateAgentColumnnInfo()
        {
            return new AgentColumnnInfo
            {
                NotAssigned = "Not assigned",
            };
        }
    }
}
