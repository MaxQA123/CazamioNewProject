using System;

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
            public string PriceFourNumberStatic { get; set; }
            public string PriceFiveNumberStatic { get; set; }
        }

        public class CreatedOnColumnInfo
        {
            public string DateCurrent { get; set; }
        }

        public class AgentColumnnInfo
        {
            public string NotAssigned { get; set; }
        }

        public class StatusColumnInfo
        {
            public string Draft { get; set; }
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
                PriceFourNumberStatic = "$1555",
                PriceFiveNumberStatic = "$10333",
            };
        }

        private static CreatedOnColumnInfo CreateCreatedOnColumnInfo()
        {
            return new CreatedOnColumnInfo
            {
                DateCurrent = DateTime.Now.ToString("MM/dd/yyyy"), // Форматирует текущую дату как "12/14/2024"
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
            };
        }
    }
}
