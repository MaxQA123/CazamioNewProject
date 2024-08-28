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
                UnitNumberOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                UnitNumberTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                UnitNumberFourNumbers = GenerateRandomData.RandomNumberWithoutZero(4),
                UnitNumberMaxNumbersAlphabet = GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1) + " " + GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1),
                UnitNumberFourAlphabet = GenerateRandomData.RandomAlphabet(4),
                BedroomsOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                BedroomsTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                HalfBedrooms = GenerateRandomData.RandomNumberWithoutZero(1),
                BathroomsOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                BathroomsOneNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                HalfBathrooms = GenerateRandomData.RandomNumberWithoutZero(1),
                SqFootOneNubmer = GenerateRandomData.RandomNumberWithoutZero(1),
                SqFootTwoNubmers = GenerateRandomData.RandomNumberWithoutZero(2),
                SqFootThreeNubmers = GenerateRandomData.RandomNumberWithoutZero(3),
                SqFootFourNubmers = GenerateRandomData.RandomNumberWithoutZero(4),
                LeasePriceOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                LeasePriceTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                LeasePriceThreeNumbers = GenerateRandomData.RandomNumberWithoutZero(3),
                LeasePriceFourNumbers = GenerateRandomData.RandomNumberWithoutZero(4),
                LeasePriceFiveNumbers = GenerateRandomData.RandomNumberWithoutZero(5),
                SecurityDepositOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                SecurityDepositTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                SecurityDepositThreeNumbers = GenerateRandomData.RandomNumberWithoutZero(3),
                SecurityDepositFourNumbers = GenerateRandomData.RandomNumberWithoutZero(4),
                SecurityDepositFiveNumbers = GenerateRandomData.RandomNumberWithoutZero(5),
                MonthlyRentsPrePaymentByDefault = "1",
                MonthlyRentsPrePaymentOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                FloorOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                FloorTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                ApartmentHoldDepositStatic = "399",
            };
        }
    }
}
