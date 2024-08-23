using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class DemoOne
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }
        //public AddressInfo Address { get; set; }
        //public NumberWithAddressInfo NumberWithAddress { get; set; }
        //public CityInfo City { get; set; }
        //public string State { get; set; }
        //public ZipInfo Zip { get; set; }
        //public NeighborhoodInfo Neighborhood { get; set; }
        //public BuildingNameInfo BuildingName { get; set; }
        //public string ShortBuildingName { get; set; }
        //public LlcNameInfo LlcName { get; set; }
        //public TextLoremInfo TextLorem { get; set; }
        //public string DescriptionShort { get; set; }
        //public string InternalNotesShort { get; set; }
        //public string DescriptionLong { get; set; }
        //public string InternalNotesLong { get; set; }
        //public CreditScreeningFeeInfo CreditScreeningFee { get; set; }
        //public HoldDepositInfo HoldDeposit { get; set; }
        //public PaymentSystemInfo PaymentSystem { get; set; }
        //public ApiKeyInfo ApiKey { get; set; }
        //public NameLocationInfo NameLocation { get; set; }
        //public ConcessionsInfo Concessions { get; set; }
        //public FreeStuffInfo FreeStuff { get; set; }
        //public AdditionalInfoInfo AdditionalInfo { get; set; }

        public static DemoOne Generate()
        {
            return new DemoOne
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
            };
        }

        public class SaintJohnsonPlInfo
        {
            public string NumberAddress { get; set; }
            public string Address { get; set; }
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
                NumberAddress = "9997",
                Address = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingName = "Building Name",
                LlcName = "LLC Name",
            };
        }
    }
}
