using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Apartment
    {
        public UnitBasicDataInfo UnitBasicData { get; set; }
        public ApartmentStatusInfo ApartmentStatus { get; set; }
        public ApartmentTypeInfo ApartmentType { get; set; }
        public DescriptionsInternalNotesInfo DescriptionsInternalNotes { get; set; }
        public MySpaceAmountPaymentsInfo MySpaceAmountPayments { get; set; }
        public AccessLocksInfo AccessLocks { get; set; }
        public SettingsConcessionsInfo SettingsConcessions { get; set; }
        public SettingsFreeStuffInfo SettingsFreeStuff { get; set; }
        public LinksForVideoInfo LinksForVideo { get; set; }

        public static Apartment Generate()
        {
            return new Apartment
            {
                UnitBasicData = CreateUnitBasicDataInfo(),
                ApartmentStatus = CreateApartmentStatusInfo(),
                ApartmentType = CreateApartmentTypeInfo(),
                DescriptionsInternalNotes = CreateDescriptionsInternalNotesInfo(),
                MySpaceAmountPayments = CreateMySpaceAmountPaymentsInfo(),
                AccessLocks = CreateAccessLocksInfo(),
                SettingsConcessions = CreateSettingsConcessionsInfo(),
                SettingsFreeStuff = CreateSettingsFreeStuffInfo(),
                LinksForVideo = CreateLinksForVideoInfo(),
            };
        }

        public class UnitBasicDataInfo
        {
            public string UnitNumberOneNumberRandom { get; set; }
            public string UnitNumberOneNumberStatic { get; set; }
            public string UnitNumberTwoNumberLetterRandom { get; set; }
            public string UnitNumberTwoNumbersStatic { get; set; }
            public string UnitNumberFourNumbersRandom { get; set; }
            public string UnitNumberThreeNumbersAlphabetStatic { get; set; }
            public string UnitNumberThreeNumbersAlphabetRandom { get; set; }
            public string UnitNumberFourNumbersStatic { get; set; }
            public string UnitNumberMaxNumbersAlphabetRandom { get; set; }
            public string UnitNumberMaxNumbersAlphabetStatic { get; set; }
            public string UnitNumberFourAlphabetRandom { get; set; }
            public string UnitNumberFourAlphabetStatic { get; set; }
            public string BedroomsOneNumberRandom { get; set; }
            public string BedroomsTwoNumbersRandom { get; set; }
            public string BedroomsZeroNumberStatic { get; set; }
            public string BedroomsOneNumberStatic { get; set; }
            public string BedroomsTwoNumberStatic { get; set; }
            public string HalfBedroomsOneStatic { get; set; }
            public string HalfBedroomsTwoStatic { get; set; }
            public string BathroomsOneNumberRandom { get; set; }
            public string BathroomsTwoNumbersRandom { get; set; }
            public string BathroomsZeroNumberStatic { get; set; }
            public string BathroomsOneNumberStatic { get; set; }
            public string BathroomsTwoNumberStatic { get; set; }
            public string HalfBathroomsOneStatic { get; set; }
            public string HalfBathroomsTwoStatic { get; set; }
            public string SqFootOneNubmer { get; set; }
            public string SqFootTwoNubmers { get; set; }
            public string SqFootThreeNubmers { get; set; }
            public string SqFootFourNubmers { get; set; }
            public string SqFootZero { get; set; }
            public string LeasePriceOneNumberRandom { get; set; }
            public string LeasePriceTwoNumbersRandom { get; set; }
            public string LeasePriceThreeNumbersRandom { get; set; }
            public string LeasePriceFourNumbersRandom { get; set; }
            public string LeasePriceFiveNumbersRandom { get; set; }
            public string LeasePriceThreeNumbersStatic { get; set; }
            public string LeasePriceFirstStatic { get; set; }
            public string LeasePriceSecondStatic { get; set; }
            public string LeasePriceFiveNumbersStatic { get; set; }
            public string SecurityDepositOneNumber { get; set; }
            public string SecurityDepositTwoNumbers { get; set; }
            public string SecurityDepositThreeNumbers { get; set; }
            public string SecurityDepositFirsRandom { get; set; }
            public string SecurityDepositFirstStatic { get; set; }
            public string SecurityDepositSecondStatic { get; set; }
            public string SecurityDepositFiveNumbers { get; set; }
            public string SecurityDepositFiveNumbersStatic { get; set; }
            public string MonthlyRentsPrePaymentByDefault { get; set; }
            public string MonthlyRentsPrePaymentOne { get; set; }
            public string MonthlyRentsPrePaymentTwo { get; set; }
            public string MonthlyRentsPrePaymentZero { get; set; }
            public string FloorOneNumber { get; set; }
            public string FloorTwoNumbers { get; set; }
            public string FloorThreeNumbers { get; set; }
            public string FloorZero { get; set; }
            public string ApartmentHoldDepositStatic { get; set; }
            public string RentalTermsByDefault { get; set; }
            public string RentalTermsOneMonth { get; set; }
            public string RentalTermsSixMonths { get; set; }
            public string RentalTermsOneYear { get; set; }
            public string RentalTermsTenMonths { get; set; }
            public string RentalTermsEighteenMonths { get; set; }
        }

        public class ApartmentStatusInfo
        {
            public string OffMarket { get; set; }
            public string Occupied { get; set; }
            public string Vacant { get; set; }
            public string DepositReceived { get; set; }
            public string ApplicationSubmitted { get; set; }
            public string SignedLease { get; set; }
        }

        public class ApartmentTypeInfo
        {
            public string MultiFamily { get; set; }
            public string SingleFamily { get; set; }
            public string Duplex { get; set; }
            public string Plex { get; set; }
            public string Loft { get; set; }
        }

        public class DescriptionsInternalNotesInfo
        {
            public string DescriptionShort { get; set; }
            public string DescriptionLong { get; set; }
            public string InternalNotesShort { get; set; }
            public string InternalNotesLong { get; set; }
            public string TextLongLoremCommon { get; set; }
            public string TextShortLoremCommon { get; set; }
        }

        public class MySpaceAmountPaymentsInfo
        {
            public string HoldDepositByDefault { get; set; }
            public string HoldDepositRandom { get; set; }
            public string HoldDepositOneStatic { get; set; }
        }

        public class AccessLocksInfo
        {
            public string MainEntranceByDefaultFirstNameLock { get; set; }
            public string ApartmentByDefaultSecondNameLock { get; set; }
            public string ExistingOccupantLongText { get; set; }
            public string ExistingOccupantShortText { get; set; }
            public string PincodeLongText { get; set; }
            public string NoteLongText { get; set; }
            public string PincodeShortText { get; set; }
            public string NoteShortText { get; set; }
        }

        public class SettingsConcessionsInfo
        {
            public string NameFirst { get; set; }
            public string RandomMonthsFree { get; set; }
            public string OneMonthYearFree { get; set; }
            public string TwoMonthsFree { get; set; }
            public string RandomLeaseTerms { get; set; }
            public string TwelveMonthsLeaseTerms { get; set; }
            public string OneYearLeaseTerms { get; set; }
            public string AdditionalInfoShort { get; set; }
            public string AdditionalInfoLong { get; set; }
        }

        public class SettingsFreeStuffInfo
        {
            public string NameFirst { get; set; }
        }

        public class LinksForVideoInfo
        {
            public string LinkYouTube { get; set; }
            public string LinkVimeo { get; set; }
            public string LinkDailymotion { get; set; }
        }

        private static UnitBasicDataInfo CreateUnitBasicDataInfo()
        {
            return new UnitBasicDataInfo
            {
                UnitNumberOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                UnitNumberOneNumberStatic = "1",
                UnitNumberTwoNumberLetterRandom = GenerateRandomData.RandomNumberWithoutZero(1) + GenerateRandomData.RandomAlphabetUpperCase(1),
                UnitNumberTwoNumbersStatic = "11",
                UnitNumberThreeNumbersAlphabetRandom = GenerateRandomData.RandomNumberWithoutZero(1) + GenerateRandomData.RandomAlphabetUpperCase(1) + GenerateRandomData.RandomNumberWithoutZero(1),
                UnitNumberThreeNumbersAlphabetStatic = "1AB",
                UnitNumberFourNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(4),
                UnitNumberFourNumbersStatic = "9999",
                UnitNumberMaxNumbersAlphabetRandom = GenerateRandomData.RandomNumberWithoutZero(1) + GenerateRandomData.RandomAlphabetUpperCase(1) + GenerateRandomData.RandomNumberWithoutZero(1) + GenerateRandomData.RandomAlphabetUpperCase(1),
                UnitNumberMaxNumbersAlphabetStatic = "1ABC",
                UnitNumberFourAlphabetRandom = GenerateRandomData.RandomAlphabetUpperCase(4),
                UnitNumberFourAlphabetStatic = "ABCD",
                BedroomsZeroNumberStatic = "0",
                BedroomsOneNumberStatic = "1",
                BedroomsTwoNumberStatic = "2",
                BedroomsOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                BedroomsTwoNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                HalfBedroomsOneStatic = "1",
                HalfBedroomsTwoStatic = "2",
                BathroomsOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                BathroomsTwoNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                BathroomsZeroNumberStatic = "0",
                BathroomsOneNumberStatic = "1",
                BathroomsTwoNumberStatic = "2",
                HalfBathroomsOneStatic = "1",
                HalfBathroomsTwoStatic = "2",
                SqFootOneNubmer = GenerateRandomData.RandomNumberWithoutZero(1),
                SqFootTwoNubmers = GenerateRandomData.RandomNumberWithoutZero(2),
                SqFootThreeNubmers = GenerateRandomData.RandomNumberWithoutZero(3),
                SqFootFourNubmers = GenerateRandomData.RandomNumberWithoutZero(4),
                SqFootZero = "0",
                LeasePriceOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                LeasePriceTwoNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                LeasePriceThreeNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(3),
                LeasePriceFourNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(4),
                LeasePriceFiveNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(5),
                LeasePriceThreeNumbersStatic = "850",
                LeasePriceFirstStatic = "1555",
                LeasePriceSecondStatic = "2500",
                LeasePriceFiveNumbersStatic = "10333",
                SecurityDepositOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                SecurityDepositTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                SecurityDepositThreeNumbers = GenerateRandomData.RandomNumberWithoutZero(3),
                SecurityDepositFirsRandom = GenerateRandomData.RandomNumberWithoutZero(4),
                SecurityDepositFiveNumbers = GenerateRandomData.RandomNumberWithoutZero(5),
                SecurityDepositFirstStatic = "2333",
                SecurityDepositSecondStatic = "5000",
                SecurityDepositFiveNumbersStatic = "15000",
                MonthlyRentsPrePaymentByDefault = "1",
                MonthlyRentsPrePaymentOne = "1",
                MonthlyRentsPrePaymentTwo = "2",
                MonthlyRentsPrePaymentZero = "0",
                FloorOneNumber = GenerateRandomData.RandomNumberWithoutZero(1),
                FloorTwoNumbers = GenerateRandomData.RandomNumberWithoutZero(2),
                FloorThreeNumbers = GenerateRandomData.RandomNumberWithoutZero(3),
                FloorZero = "0",
                ApartmentHoldDepositStatic = "399",
                RentalTermsByDefault = "12 months",
                RentalTermsOneYear = "1 year",
                RentalTermsTenMonths = "10 months",
                RentalTermsEighteenMonths = "18 months",
                RentalTermsOneMonth = "1 month",
                RentalTermsSixMonths = "6 months",
            };
        }

        private static ApartmentStatusInfo CreateApartmentStatusInfo()
        {
            return new ApartmentStatusInfo
            {
                OffMarket = "Off market",
                Occupied = "Occupied",
                Vacant = "Vacant",
                DepositReceived = "Deposit received",
                ApplicationSubmitted = "Application submitted",
                SignedLease = "Signed lease",
            };
        }

        private static ApartmentTypeInfo CreateApartmentTypeInfo()
        {
            return new ApartmentTypeInfo
            {
                MultiFamily = "MultiFamily",
                SingleFamily = "SingleFamily",
                Duplex = "Duplex",
                Plex = "Plex",
                Loft = "Loft",
            };
        }

        private static DescriptionsInternalNotesInfo CreateDescriptionsInternalNotesInfo()
        {
            return new DescriptionsInternalNotesInfo
            {
                DescriptionShort = "DESCRIPTION for APARTMENT (12345) (09876) (&%$#@!)",
                DescriptionLong = "DESCRIPTION for APARTMENT (12345) (09876) (&%$#@!) Lorem APARTMENT ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
                InternalNotesShort = "INTERNAL NOTES for APARTMENT (12345) (09876) (&%$#@!)",
                InternalNotesLong = "INTERNAL NOTES for APARTMENT (12345) (09876) (&%$#@!) Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
                TextLongLoremCommon = "Lorem APARTMENT ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
                TextShortLoremCommon = "Lorem APARTMENT ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing",
            };
        }

        private static MySpaceAmountPaymentsInfo CreateMySpaceAmountPaymentsInfo()
        {
            return new MySpaceAmountPaymentsInfo
            {
                HoldDepositByDefault = "500",
                HoldDepositRandom = GenerateRandomData.RandomNumberWithoutZero(3),
                HoldDepositOneStatic = "1",
            };
        }

        private static AccessLocksInfo CreateAccessLocksInfo()
        {
            return new AccessLocksInfo
            {
                MainEntranceByDefaultFirstNameLock = "Main entrance",
                ApartmentByDefaultSecondNameLock = "Apartment",
                ExistingOccupantLongText = "Lorem ExistingOccupant APARTMENT 12345 (09876) *&^% $#@!. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                ExistingOccupantShortText = "Lorem ExistingOccupant APARTMENT 12345 (09876) *&^% $#@!",
                PincodeLongText = "Lorem PinCode Apartment (12345) (&%$#@!). Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                PincodeShortText = "Lorem PinCode Apartment (12345) (&%$#@!)",
                NoteLongText = "Lorem NOTE Apartment (12345) (&%$#@!). Lorem ipsum dolor sit amet, consectetuer adipiscing elit.",
                NoteShortText = "Lorem NOTE Apartment (12345) (&%$#@!)",
            };
        }

        private static SettingsConcessionsInfo CreateSettingsConcessionsInfo()
        {
            return new SettingsConcessionsInfo
            {
                NameFirst = "Conces Apartment 1",
                RandomMonthsFree = GenerateRandomData.RandomNumberWithoutZero(1),
                OneMonthYearFree = "1",
                TwoMonthsFree = "2",
                RandomLeaseTerms = GenerateRandomData.RandomNumberWithoutZero(1),
                TwelveMonthsLeaseTerms = "12",
                OneYearLeaseTerms = "1",
                AdditionalInfoShort = "Lorem ADDITIONAL INFO APARTMENT 12345 (09876) (*&%$#@!)",
                AdditionalInfoLong = "Lorem ADDITIONAL INFO APARTMENT 12345 (09876) Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
            };
        }

        private static SettingsFreeStuffInfo CreateSettingsFreeStuffInfo()
        {
            return new SettingsFreeStuffInfo
            {
                NameFirst = "Free Stuff Apartment 1",
            };
        }

        private static LinksForVideoInfo CreateLinksForVideoInfo()
        {
            return new LinksForVideoInfo
            {
                LinkYouTube = "https://www.youtube.com/watch?v=0mh5d2a8wp0",
                LinkVimeo = "https://vimeo.com/988164102",
                LinkDailymotion = "",
            };
        }
    }
}
