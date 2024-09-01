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
            public string UnitNumberOneNumberRandom { get; set; }
            public string UnitNumberOneNumberStatic { get; set; }
            public string UnitNumberTwoNumbersRandom { get; set; }
            public string UnitNumberTwoNumbersStatic { get; set; }
            public string UnitNumberFourNumbersRandom { get; set; }
            public string UnitNumberFourNumbersStatic { get; set; }
            public string UnitNumberMaxNumbersAlphabetRandom { get; set; }
            public string UnitNumberMaxNumbersAlphabetStatic { get; set; }
            public string UnitNumberFourAlphabetRandom { get; set; }
            public string UnitNumberFourAlphabetStatic { get; set; }
            public string BedroomsOneNumber { get; set; }
            public string BedroomsTwoNumbers { get; set; }
            public string HalfBedroomsOne { get; set; }
            public string HalfBedroomsTwo { get; set; }
            public string BathroomsOneNumber { get; set; }
            public string BathroomsTwoNumbers { get; set; }
            public string HalfBathroomsOne { get; set; }
            public string HalfBathroomsTwo { get; set; }
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
            public string MonthlyRentsPrePaymentOne { get; set; }
            public string MonthlyRentsPrePaymentTwo { get; set; }
            public string FloorOneNumber { get; set; }
            public string FloorTwoNumbers { get; set; }
            public string ApartmentHoldDepositStatic { get; set; }
        }

        private static UnitBasicDataInfo CreateUnitBasicDataInfo()
        {
            return new UnitBasicDataInfo
            {
                UnitNumberOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                UnitNumberOneNumberStatic = "",
                UnitNumberTwoNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                UnitNumberTwoNumbersStatic = "",
                UnitNumberFourNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(4),
                UnitNumberFourNumbersStatic = "",
                UnitNumberMaxNumbersAlphabetRandom = GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1) + " " + GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1),
                UnitNumberMaxNumbersAlphabetStatic = "",
                UnitNumberFourAlphabetRandom = GenerateRandomData.RandomAlphabet(4),
                UnitNumberFourAlphabetStatic = "",
                BedroomsOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                BedroomsTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                HalfBedroomsOne = "1",
                HalfBedroomsTwo = "2",
                BathroomsOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                BathroomsTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                HalfBathroomsOne = "1",
                HalfBathroomsTwo = "2",
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
                MonthlyRentsPrePaymentOne = "1",
                MonthlyRentsPrePaymentTwo = "2",
                FloorOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                FloorTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                ApartmentHoldDepositStatic = "399",
            };
        }
    }
}
