using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }
        public WashingtonSquareInfo WashingtonSquare { get; set; }
        public CrownStInfo CrownSt { get; set; }
        public AlbermaleRdInfo AlbermaleRd { get; set; }
        public East51stStreetPedestrianCrossingInfo East51stStreetPedestrianCrossing { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
                WashingtonSquare = CreateWashingtonSquareInfo(),
                CrownSt = CreateCrownStInfo(),
                AlbermaleRd = CreateAlbermaleRdInfo(),
                East51stStreetPedestrianCrossing = CreateEast51stStreetPedestrianCrossingInfo(),
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

        public class CrownStInfo
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

        public class AlbermaleRdInfo
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

        public class East51stStreetPedestrianCrossingInfo
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
                NumberNameAddressStatic = "9996 Saint Johnson Place",
                NumberAddress = "9996",
                AddressName = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingName = "9996 Saint Johnson Place AGENT QA-Building Name (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static WashingtonSquareInfo CreateWashingtonSquareInfo()
        {
            return new WashingtonSquareInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(4) + " " + "Washington Square",
                NumberNameAddressStatic = "6 Washington Square",
                NumberAddress = "6",
                AddressName = "Washington Square",
                City = "New York",
                State = "NY",
                Zip = "10012",
                Neighborhood = "Manhattan",
                BuildingName = "6 Washington Square Broker QA-Building Name (12345) (09876) (*&^%)",
                LlcName = "LLC Name QA Broker (12345) (09876) (*&^%)",
            };
        }

        private static CrownStInfo CreateCrownStInfo()
        {
            return new CrownStInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(3) + " " + "Crown St",
                NumberNameAddressStatic = "40-49 Crown St",
                NumberAddress = "40-49",
                AddressName = "Crown St",
                City = "Brooklyn",
                State = "NY",
                Zip = "11225",
                Neighborhood = "Crown Heights",
                BuildingName = "40-49 Crown St Broker QA-Building Name (12345) (09876) (*&^%)",
                LlcName = "LLC Name QA Broker (12345) (09876) (*&^%)",
            };
        }

        private static AlbermaleRdInfo CreateAlbermaleRdInfo()
        {
            return new AlbermaleRdInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(2) + " " + "Albermale Rd",
                NumberNameAddressStatic = "100A Albermale Rd",
                NumberAddress = "100A",
                AddressName = "Albermale Rd",
                City = "Brooklyn",
                State = "NY",
                Zip = "11226",
                Neighborhood = "East Flatbush",
                BuildingName = "100A Albermale Rd AGENT QA-Building Name (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static East51stStreetPedestrianCrossingInfo CreateEast51stStreetPedestrianCrossingInfo()
        {
            return new East51stStreetPedestrianCrossingInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(1) + " " + "East 51st Street Pedestrian Crossing",
                NumberNameAddressStatic = "100-109 East 51st Street Pedestrian Crossing",
                NumberAddress = "100-109",
                AddressName = "East 51st Street Pedestrian Crossing",
                City = "New York",
                State = "NY",
                Zip = "10022",
                Neighborhood = "Manhattan",
                BuildingName = "100-109 East 51st Street Pedestrian Crossing AGENT QA-Building Name (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }
    }
}
