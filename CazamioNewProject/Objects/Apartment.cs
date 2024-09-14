using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Apartment
    {
        public BuildingShortAddressInfo BuildingShortAddress { get; set; }
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
                BuildingShortAddress = CreateBuildingShortAddressInfo(),
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

        public class BuildingShortAddressInfo
        {
            public string OneWashingtonSquare { get; set; }
            public string NineNineNineEightSaintJohnsonPlace { get; set; }
            public string ThirtyDashTrirtyNineCrownSt { get; set; }
            public string OneA1AAlbermaleRd { get; set; }
            public string OneOneOneAEastFiftyOneStStreetPedestrianCrossing { get; set; }
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
            public string RentalTermsByDefault { get; set; }
            public string RentalTermsOneYear { get; set; }
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
            public string HoldDepositStatic { get; set; }
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

        private static BuildingShortAddressInfo CreateBuildingShortAddressInfo()
        {
            return new BuildingShortAddressInfo
            {
                OneWashingtonSquare = "1 Washington Square",
                NineNineNineEightSaintJohnsonPlace = "9998 Saint Johnson Place",
                ThirtyDashTrirtyNineCrownSt = "30-39 Crown St",
                OneA1AAlbermaleRd = "1A Albermale Rd",
                OneOneOneAEastFiftyOneStStreetPedestrianCrossing = "111A East 51st Street Pedestrian Crossing",
            };
        }

        private static UnitBasicDataInfo CreateUnitBasicDataInfo()
        {
            return new UnitBasicDataInfo
            {
                UnitNumberOneNumberRandom = GenerateRandomData.RandomNumberWithoutZero(1),
                UnitNumberOneNumberStatic = "1",
                UnitNumberTwoNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                UnitNumberTwoNumbersStatic = "11",
                UnitNumberFourNumbersRandom = GenerateRandomData.RandomNumberWithoutZero(4),
                UnitNumberFourNumbersStatic = "9998",
                UnitNumberMaxNumbersAlphabetRandom = GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1) + " " + GenerateRandomData.RandomNumberWithoutZero(1) + " " + GenerateRandomData.RandomAlphabet(1),
                UnitNumberMaxNumbersAlphabetStatic = "11AA",
                UnitNumberFourAlphabetRandom = GenerateRandomData.RandomAlphabet(4),
                UnitNumberFourAlphabetStatic = "ABCD",
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
                RentalTermsByDefault = "12 months",
                RentalTermsOneYear = "1 year",
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
                HoldDepositStatic = "900",
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
