using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.Objects
{
    public class ApartmentApplicationsTable
    {
        public ApartmentColumnInfo ApartmentColumn { get; set; }
        public ApplicantsColumnInfo ApplicantsColumn { get; set; }
        public PriceColumnInfo PriceColumn { get; set; }
        public CreatedOnColumnInfo CreatedOnColumn { get; set; }
        public AgentColumnnInfo AgentColumn { get; set; }
        public StatusColumnInfo StatusColumn { get; set; }

        public static ApartmentApplicationsTable Generate()
        {
            return new ApartmentApplicationsTable
            {
                ApartmentColumn = CreateApartmentColumnInfo(),
                ApplicantsColumn = CreateApplicantsColumnInfo(),
                PriceColumn = CreatePriceColumnInfo(),
                CreatedOnColumn = CreateCreatedOnColumnInfo(),
                AgentColumn = CreateAgentColumnnInfo(),
                StatusColumn = CreateStatusColumnInfo(),
            };
        }

        public class ApartmentColumnInfo
        {
            public string UnitForNineNineNineEightSaintJohnsonPlace { get; set; }
        }

        public class ApplicantsColumnInfo
        {
            public string FirstLastNameMainApplicant { get; set; }
        }

        public class PriceColumnInfo
        {
            public string Price { get; set; }
        }

        public class CreatedOnColumnInfo
        {
            public string Date { get; set; }
        }

        public class AgentColumnnInfo
        {
            public string NotAssigned { get; set; }
        }

        public class StatusColumnInfo
        {
            public string Draft { get; set; }
            public string Vacant { get; set; }
        }

        private static ApartmentColumnInfo CreateApartmentColumnInfo()
        {
            return new ApartmentColumnInfo
            {
                UnitForNineNineNineEightSaintJohnsonPlace = "",
            };
        }

        private static ApplicantsColumnInfo CreateApplicantsColumnInfo()
        {
            return new ApplicantsColumnInfo
            {
                FirstLastNameMainApplicant = "",
            };
        }

        private static PriceColumnInfo CreatePriceColumnInfo()
        {
            return new PriceColumnInfo
            {
                Price = "",
            };
        }

        private static CreatedOnColumnInfo CreateCreatedOnColumnInfo()
        {
            return new CreatedOnColumnInfo
            {
                Date = "",
            };
        }

        private static AgentColumnnInfo CreateAgentColumnnInfo()
        {
            return new AgentColumnnInfo
            {
                NotAssigned = "Not assigned",
            };
        }

        private static StatusColumnInfo CreateStatusColumnInfo()
        {
            return new StatusColumnInfo
            {
                Draft = "Draft",
                Vacant = "Vacant",
            };
        }
    }
}
