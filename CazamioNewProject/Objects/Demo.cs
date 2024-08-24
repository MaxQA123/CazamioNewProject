using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }
        public WashingtonSquareInfo WashingtonSquare { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
                WashingtonSquare = CreateWashingtonSquareInfo(),
            };
        }

        public class SaintJohnsonPlInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class WashingtonSquareInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        private static SaintJohnsonPlInfo CreateSaintJohnsonPlInfo()
        {
            return new SaintJohnsonPlInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Saint Johnson Place" ,
                NumberNameAddressStatic = "9997 Saint Johnson Place",
                NumberAddress = "9997",
                AddressName = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingName = "Building Name",
                LlcName = "LLC Name",
            };
        }

        private static WashingtonSquareInfo CreateWashingtonSquareInfo()
        {
            return new WashingtonSquareInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Saint Johnson Place",
                NumberNameAddressStatic = "5 Washington Square",
                NumberAddress = "5",
                AddressName = "Washington Square",
                City = "New York",
                State = "NY",
                Zip = "10012",
                Neighborhood = "Manhattan",
                BuildingName = "5 Washington Square QA-Building Name (12345) (09876) (*&^%)",
                LlcName = "LLC Name QA Broker (12345) (09876) (*&^%)",
            };
        }
    }
}
