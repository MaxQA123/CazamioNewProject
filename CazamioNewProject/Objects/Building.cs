using CazamioNewProject.GuiHelpers;

namespace CazamioNewProject.Objects
{
    public class Building
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }
        public WashingtonSquareInfo WashingtonSquare { get; set; }
        public CrownStInfo CrownSt { get; set; }
        public AlbermaleRdInfo AlbermaleRd { get; set; }
        public East51stStreetPedestrianCrossingInfo East51stStreetPedestrianCrossing { get; set; }
        public DeanStreetInfo DeanStreet { get; set; }
        public GatesAvenueInfo GatesAvenue { get; set; }
        public CommonApiDataInfo CommonApiData { get; set; }
        public DescriptionsInternalNotesInfo DescriptionsInternalNotes { get; set; }
        public MySpaceAmountPaymentsInfo MySpaceAmountPayments { get; set; }
        public PaymentSystemsInfo PaymentSystems { get; set; }
        public AccessLocksInfo AccessLocks { get; set; }
        public SettingsConcessionsInfo SettingsConcessions { get; set; }
        public SettingsFreeStuffInfo SettingsFreeStuff { get; set; }

        public static Building Generate()
        {
            return new Building
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
                WashingtonSquare = CreateWashingtonSquareInfo(),
                CrownSt = CreateCrownStInfo(),
                AlbermaleRd = CreateAlbermaleRdInfo(),
                East51stStreetPedestrianCrossing = CreateEast51stStreetPedestrianCrossingInfo(),
                DeanStreet = CreateDeanStreetInfo(),
                GatesAvenue = CreateGatesAvenueInfo(),
                CommonApiData = CreateCommonApiDataInfo(),
                DescriptionsInternalNotes = CreateDescriptionsInternalNotesInfo(),
                MySpaceAmountPayments = CreateMySpaceAmountPaymentsInfo(),
                PaymentSystems = CreatePaymentSystemsInfo(),
                AccessLocks = CreateAccessLocksInfo(),
                SettingsConcessions = CreateSettingsConcessionsInfo(),
                SettingsFreeStuff = CreateSettingsFreeStuffInfo(),
            };
        }

        public class SaintJohnsonPlInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressRandom { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingNameStatic { get; set; }
            public string BuildingNameRandom { get; set; }
            public string LlcName { get; set; }
            public string LongBuildingAddress { get; set; }
        }

        public class WashingtonSquareInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressRandom { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingNameStatic { get; set; }
            public string BuildingNameRandom { get; set; }
            public string LlcNameStatic { get; set; }
            public string LlcNameRandom { get; set; }
        }

        public class CrownStInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressRandom { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingNameStatic { get; set; }
            public string BuildingNameRandom { get; set; }
            public string LlcNameStatic { get; set; }
            public string LlcNameRandom { get; set; }
        }

        public class AlbermaleRdInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressRandom { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingNameStatic { get; set; }
            public string BuildingNameRandom { get; set; }
            public string LlcNameStatic { get; set; }
            public string LlcNameRandom { get; set; }
        }

        public class East51stStreetPedestrianCrossingInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressRandom { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingNameStatic { get; set; }
            public string BuildingNameRandom { get; set; }
            public string LlcNameStatic { get; set; }
            public string LlcNameRandom { get; set; }
        }

        public class DeanStreetInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressStaticForDb { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class GatesAvenueInfo
        {
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberNameAddressStaticForSearch { get; set; }
            public string NumberNameAddress { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class CommonApiDataInfo
        {
            public long BuildingId { get; set; }
            public string CountryUnitedStates { get; set; }
            public string StreetRandom { get; set; }
            public string CityNewYork { get; set; }
            public string CityBrooklyn { get; set; }
            public string StateNy { get; set; }
            public string ZipCode { get; set; }
            public string EmptyString { get; set; }
            public long ScreeningFeeByDefaultMySpace { get; set; }
            public long HoldDepositByDefaultMySpace { get; set; }
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
            public string CreditScreeningFeeByDefault { get; set; }
            public string CreditScreeningFeeRandom { get; set; }
            public string CreditScreeningOne { get; set; }
            public string HoldDepositByDefault { get; set; }
            public string HoldDepositRandom { get; set; }
            public string HoldDepositStatic { get; set; }
        }

        public class PaymentSystemsInfo
        {
            public string Cardknox { get; set; }
            public string ApiKeyCardknox { get; set; }
            public string AuthorizeNet { get; set; }
            public string ApiKeyAuthorizeNet { get; set; }
        }

        public class AccessLocksInfo
        {
            public string MainEntranceByDefaultFirstNameLock { get; set; }
            public string ApartmentByDefaultSecondNameLock { get; set; }
            public string PinCodeTextLorem { get; set; }
            public string NoteTextLorem { get; set; }
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

        private static SaintJohnsonPlInfo CreateSaintJohnsonPlInfo()
        {
            return new SaintJohnsonPlInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Saint Johnson Place",
                NumberNameAddressStaticForSearch = "9998 Saint Johnson Place",
                NumberNameAddressStatic = "9998 Saint Johnson Place",
                NumberNameAddressRandom = GenerateRandomData.RandomNumberWithoutZero(4) + " " + "Saint Johnson Place",
                NumberNameAddress = "9998 Saint Johnson Place",
                NumberAddress = "9998",
                AddressName = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = "11213",
                Neighborhood = "Crown Heights",
                BuildingNameStatic = "AGENT QA-Building Name 9998 Saint Johnson Place (12345) (*&^%)",
                BuildingNameRandom = "AGENT QA-Building Name Random Saint Johnson Place (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
                LongBuildingAddress = "9998 Saint Johnson Place, Brooklyn, NY",
            };
        }

        private static WashingtonSquareInfo CreateWashingtonSquareInfo()
        {
            return new WashingtonSquareInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(4) + " " + "Washington Square",
                NumberNameAddressStaticForSearch = "1 Washington Square",
                NumberNameAddressStatic = "1 Washington Square",
                NumberNameAddressRandom = GenerateRandomData.RandomNumberWithoutZero(1) + GenerateRandomData.RandomAlphabetUpperCase(1) + " " + "Washington Square",
                NumberNameAddress = "1 Washington Square",
                NumberAddress = "1",
                AddressName = "Washington Square",
                City = "New York",
                State = "NY",
                Zip = "10012",
                Neighborhood = "Manhattan",
                BuildingNameStatic = "Broker QA-Building Name 1 Washington Square (12345) (09876) (*&^%)",
                BuildingNameRandom = "Broker QA-Building Name Random Washington Square (12345) (09876) (*&^%)",
                LlcNameStatic = "LLC Name QA Broker (12345) (09876) (*&^%)",
                LlcNameRandom = "LLC Random Name QA Broker (12345) (09876) (*&^%)",
            };
        }

        private static CrownStInfo CreateCrownStInfo()
        {
            return new CrownStInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(3) + " " + "Crown St",
                NumberNameAddressStaticForSearch = "30-39 Crown St",
                NumberNameAddressStatic = "30-39 Crown St",
                NumberNameAddressRandom = GenerateRandomData.RandomNumberWithoutZero(2) + "-" + GenerateRandomData.RandomNumberWithoutZero(2) + " " + "Crown St",
                NumberNameAddress = "30-39 Crown St",
                NumberAddress = "30-39",
                AddressName = "Crown St",
                City = "Brooklyn",
                State = "NY",
                Zip = "11225",
                Neighborhood = "Crown Heights",
                BuildingNameStatic = " Broker QA-Building Name 30-39 Crown St (12345) (09876) (*&^%)",
                BuildingNameRandom = " Broker QA-Building Name Random Crown St (12345) (09876) (*&^%)",
                LlcNameStatic = "LLC Name QA Broker (12345) (09876) (*&^%)",
                LlcNameRandom = "LLC Random Name QA Broker (12345) (09876) (*&^%)",
            };
        }

        private static AlbermaleRdInfo CreateAlbermaleRdInfo()
        {
            return new AlbermaleRdInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(2) + " " + "Albermale Rd",
                NumberNameAddressStaticForSearch = "9A Albermale Rd",
                NumberNameAddressStatic = "9A Albermale Rd",
                NumberNameAddressRandom = GenerateRandomData.RandomNumberWithoutZero(2) + GenerateRandomData.RandomAlphabetUpperCase(1) + " " + "Albermale Rd",
                NumberNameAddress = "9A Albermale Rd",
                NumberAddress = "9A",
                AddressName = "Albermale Rd",
                City = "Brooklyn",
                State = "NY",
                Zip = "11226",
                Neighborhood = "East Flatbush",
                BuildingNameStatic = "AGENT QA-Building Name 9A Albermale Rd (12345) (*&^%)",
                BuildingNameRandom = "AGENT QA-Building Name Random Albermale Rd (12345) (*&^%)",
                LlcNameStatic = "LLC Name QA Agent (12345) (09876) (*&^%)",
                LlcNameRandom = "LLC Random Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static East51stStreetPedestrianCrossingInfo CreateEast51stStreetPedestrianCrossingInfo()
        {
            return new East51stStreetPedestrianCrossingInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(1) + " " + "East 51st Street Pedestrian Crossing",
                NumberNameAddressStatic = "111A East 51st Street Pedestrian Crossing",
                NumberNameAddressStaticForSearch = "111A East 51st Street Pedestrian Crossing",
                NumberNameAddressRandom = GenerateRandomData.RandomNumberWithoutZero(3) + GenerateRandomData.RandomAlphabetUpperCase(1) + " " + "East 51st Street Pedestrian Crossing",
                NumberNameAddress = "111A East 51st Street Pedestrian Crossing",
                NumberAddress = "111A",
                AddressName = "East 51st Street Pedestrian Crossing",
                City = "New York",
                State = "NY",
                Zip = "10022",
                Neighborhood = "Manhattan",
                BuildingNameStatic = "QA-Building Name AGENT 111A East 51st Street Pedestrian Crossing (12345) (*&^%)",
                BuildingNameRandom = "QA-Building Name AGENT Random East 51st Street Pedestrian Crossing (12345) (*&^%)",
                LlcNameStatic = "LLC Name QA Agent (12345) (09876) (*&^%)",
                LlcNameRandom = "LLC Name Random QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static DeanStreetInfo CreateDeanStreetInfo()
        {
            return new DeanStreetInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(1) + " " + "Dean Street",
                NumberNameAddressStaticForDb = "12567 Dean Street",
                NumberNameAddressStaticForSearch = "12567 Dean Street",
                NumberNameAddressStatic = "12567 Dean Street",
                //NumberNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(2) + GenerateRandomData.RandomAlphabetUpperCase(1) + " " + "Dean Street",
                NumberNameAddress = "12567 Dean Street",
                NumberAddress = "12567",
                //NumberAddress = GenerateRandomData.RandomNumberWithoutZero(5),
                AddressName = "Dean Street",
                City = "Brooklyn",
                State = "NY",
                Zip = "11238",
                Neighborhood = "Prospect Heights",
                BuildingName = "QA-Building Name AGENT 12567 Dean Street (12345) (*&^%)",
                //BuildingName = "QA-Building Name AGENT Random Dean Street (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static GatesAvenueInfo CreateGatesAvenueInfo()
        {
            return new GatesAvenueInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(1) + " " + "Gates Avenue",
                NumberNameAddressStaticForSearch = "12867 Gates Avenue",
                NumberNameAddressStatic = "12867 Gates Avenue",
                //NumberNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Gates Avenue",
                NumberNameAddress = "12867 Gates Avenue",
                NumberAddress = "12867",
                //NumberAddress = GenerateRandomData.RandomNumberWithoutZero(5),
                AddressName = "Gates Avenue",
                City = "Brooklyn",
                State = "NY",
                Zip = "11221",
                Neighborhood = "Stuyvesant Heights",
                BuildingName = "QA-Building Name AGENT 12867 Gates Avenue (12345) (*&^%)",
                //BuildingName = "QA-Building Name AGENT Random Gates Avenue (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static CommonApiDataInfo CreateCommonApiDataInfo()
        {
            return new CommonApiDataInfo
            {
                BuildingId = 0,
                CountryUnitedStates = "United States",
                StreetRandom = GenerateRandomData.RandomNumberWithoutZero(4) + " " + GenerateRandomData.GetRandomStreet(),
                CityNewYork = "New York",
                CityBrooklyn = "Brooklyn",
                StateNy = "NY",
                ZipCode = "10022",
                EmptyString = "",
                ScreeningFeeByDefaultMySpace = 20,
                HoldDepositByDefaultMySpace = 500,
            };
        }

        private static DescriptionsInternalNotesInfo CreateDescriptionsInternalNotesInfo()
        {
            return new DescriptionsInternalNotesInfo
            {
                DescriptionShort = "DESCRIPTION for BUILDING (12345) (09876) (&%$#@!)",
                DescriptionLong = "DESCRIPTION for BUILDING (12345) (09876) (&%$#@!) Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus.",
                InternalNotesShort = "INTERNAL NOTES for BUILDING (12345) (09876) (&%$#@!)",
                InternalNotesLong = "INTERNAL NOTES for BUILDING (12345) (09876) (&%$#@!) Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante.",
                TextLongLoremCommon = "Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
                TextShortLoremCommon = "Lorem BUILDING ipsum dolor sit amet, 12345 67890 !@# $%^ &*() adipiscing",
            };
        }

        private static MySpaceAmountPaymentsInfo CreateMySpaceAmountPaymentsInfo()
        {
            return new MySpaceAmountPaymentsInfo
            {
                CreditScreeningFeeByDefault = "20",
                CreditScreeningFeeRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                CreditScreeningOne = "1",
                HoldDepositByDefault = "500",
                HoldDepositRandom = GenerateRandomData.RandomNumberWithoutZero(3),
                HoldDepositStatic = "900",
            };
        }

        private static PaymentSystemsInfo CreatePaymentSystemsInfo()
        {
            return new PaymentSystemsInfo
            {
                Cardknox = "Cardknox",
                ApiKeyCardknox = "czmodev359376936c0543b58126c97f9ff55c68",
                AuthorizeNet = "AuthorizeNet",
                ApiKeyAuthorizeNet = "2L7uB4UzeA9gf366",
            };
        }

        private static AccessLocksInfo CreateAccessLocksInfo()
        {
            return new AccessLocksInfo
            {
                MainEntranceByDefaultFirstNameLock = "Main entrance",
                ApartmentByDefaultSecondNameLock = "Apartment",
                PinCodeTextLorem = "Lorem PinCode Building (12345) (&%$#@!)",
                NoteTextLorem = "Lorem NOTE Building (12345) (&%$#@!)",
            };
        }

        private static SettingsConcessionsInfo CreateSettingsConcessionsInfo()
        {
            return new SettingsConcessionsInfo
            {
                NameFirst = "Conces Building 1",
                RandomMonthsFree = GenerateRandomData.RandomNumberWithoutZero(1),
                OneMonthYearFree = "1",
                TwoMonthsFree = "2",
                RandomLeaseTerms = GenerateRandomData.RandomNumberWithoutZero(1),
                TwelveMonthsLeaseTerms = "12",
                OneYearLeaseTerms = "1",
                AdditionalInfoShort = "Lorem ADDITIONAL INFO BUILDING 12345 (09876) (*&%$#@!)",
                AdditionalInfoLong = "Lorem ADDITIONAL INFO BUILDING 12345 (09876) Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc,",
            };
        }

        private static SettingsFreeStuffInfo CreateSettingsFreeStuffInfo()
        {
            return new SettingsFreeStuffInfo
            {
                NameFirst = "Free Stuff Building 1",
            };
        }
    }
}
