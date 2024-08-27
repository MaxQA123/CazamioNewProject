using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Demo
    {
        public UnitBasicDataInfo UnitBasicData { get; set; }

        public static Demo Generate()
        {
            return new Demo
            {
                UnitBasicData = CreateUnitBasicDataInfo(),
            };
        }

        public class UnitBasicDataInfo
        {
            public string UnitNumberOneNumber { get; set; }
            public string UnitNumberTwoNumbers { get; set; }
            public string UnitNumberFourNumbers { get; set; }
            public string UnitNumberMaxNumbersAlphabet { get; set; }
            public string UnitNumberFourAlphabet { get; set; }
            public string BedroomsOneNumber { get; set; }
            public string BedroomsTwoNumbers { get; set; }
            public string HalfBedrooms { get; set; }
            public string BathroomsOneNumber { get; set; }
            public string BathroomsOneNumbers { get; set; }
            public string HalfBathrooms { get; set; }
            public string SqFootOneNubmer { get; set; }
            public string SqFootTwoNubmers { get; set; }
            public string SqFootThreeNubmers { get; set; }
            public string SqFootFourNubmers { get; set; }
            public string LeasePriceOneNumber { get; set; }
            public string LeasePriceTwoNumbers { get; set; }
            public string LeasePriceThreeNumbers { get; set; }
            public string LeasePriceFourNumbers { get; set; }
            public string LeasePriceFiveNumbers { get; set; }
            public string SecurityDepositOneNumber { get; set; }
            public string SecurityDepositTwoNumbers { get; set; }
            public string SecurityDepositThreeNumbers { get; set; }
            public string SecurityDepositFourNumbers { get; set; }
            public string SecurityDepositFiveNumbers { get; set; }
            public string MonthlyRentsPrePaymentByDefault { get; set; }
            public string MonthlyRentsPrePaymentOneNumber { get; set; }
            public string FloorOneNumber { get; set; }
            public string FloorTwoNumbers { get; set; }
            public string ApartmentHoldDepositStatic { get; set; }
        }

        private static UnitBasicDataInfo CreateUnitBasicDataInfo()
        {
            return new UnitBasicDataInfo
            {
                UnitNumberOneNumber = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Saint Johnson Place" ,
                UnitNumberTwoNumbers = "9996 Saint Johnson Place",
                UnitNumberFourNumbers = "9996",
                UnitNumberMaxNumbersAlphabet = "Saint Johnson Place",
                UnitNumberFourAlphabet = "Brooklyn",
                BedroomsOneNumber = "NY",
                BedroomsTwoNumbers = "11213",
                HalfBedrooms = "Crown Heights",
                BathroomsOneNumber = "9996 Saint Johnson Place AGENT QA-Building Name (12345) (*&^%)",
                BathroomsOneNumbers = "LLC Name QA Agent (12345) (09876) (*&^%)",
                HalfBathrooms = "Brooklyn",
                SqFootOneNubmer = "NY",
                SqFootTwoNubmers = "11213",
                SqFootThreeNubmers = "Crown Heights",
                SqFootFourNubmers = "9996 Saint Johnson Place AGENT QA-Building Name (12345) (*&^%)",
                LeasePriceOneNumber = "LLC Name QA Agent (12345) (09876) (*&^%)",
                LeasePriceTwoNumbers = "Brooklyn",
                LeasePriceThreeNumbers = "NY",
                LeasePriceFourNumbers = "11213",
                LeasePriceFiveNumbers = "Crown Heights",
                SecurityDepositOneNumber = "9996 Saint Johnson Place AGENT QA-Building Name (12345) (*&^%)",
                SecurityDepositTwoNumbers = "LLC Name QA Agent (12345) (09876) (*&^%)",
                SecurityDepositThreeNumbers = "NY",
                SecurityDepositFourNumbers = "11213",
                SecurityDepositFiveNumbers = "Crown Heights",
                MonthlyRentsPrePaymentByDefault = "9996 Saint Johnson Place AGENT QA-Building Name (12345) (*&^%)",
                MonthlyRentsPrePaymentOneNumber = "LLC Name QA Agent (12345) (09876) (*&^%)",
                FloorOneNumber = "Brooklyn",
                FloorTwoNumbers = "NY",
                ApartmentHoldDepositStatic = "11213",
            };
        }
    }
}
