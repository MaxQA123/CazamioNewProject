using CazamioNewProject.GuiHelpers;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects
{
    public class DemoApi
    {
        public SaintJohnsonPlInfo SaintJohnsonPl { get; set; }
        public WashingtonSquareInfo WashingtonSquare { get; set; }
        public CrownStInfo CrownSt { get; set; }
        public AlbermaleRdInfo AlbermaleRd { get; set; }
        public East51stStreetPedestrianCrossingInfo East51stStreetPedestrianCrossing { get; set; }
        public PetPoliciesApiInfo PetPoliciesApi { get; set; }
        public AmountApiInfo AmountApi { get; set; }
        public ShowOrderApiInfo ShowOrderApi { get; set; }
        public ConnectionTypeApiInfo ConnectionTypeApi { get; set; }
        public MySpaceAmountPaymentsInfo MySpaceAmountPayments { get; set; }
        public AccessLocksInfo AccessLocks { get; set; }
        public SettingsConcessionsInfo SettingsConcessions { get; set; }
        public SettingsFreeStuffInfo SettingsFreeStuff { get; set; }

        public static DemoApi Generate()
        {
            return new DemoApi
            {
                SaintJohnsonPl = CreateSaintJohnsonPlInfo(),
                WashingtonSquare = CreateWashingtonSquareInfo(),
                CrownSt = CreateCrownStInfo(),
                AlbermaleRd = CreateAlbermaleRdInfo(),
                East51stStreetPedestrianCrossing = CreateEast51stStreetPedestrianCrossingInfo(),
                PetPoliciesApi = CreatePetPoliciesApiInfo(),
                AmountApi = CreateAmountApiInfo(),
                ShowOrderApi = CreateShowOrderApiInfo(),
                ConnectionTypeApi = CreateConnectionTypeApiInfo(),
                MySpaceAmountPayments = CreateMySpaceAmountPaymentsInfo(),
                AccessLocks = CreateAccessLocksInfo(),
                SettingsConcessions = CreateSettingsConcessionsInfo(),
                SettingsFreeStuff = CreateSettingsFreeStuffInfo(),
            };
        }

        public class SaintJohnsonPlInfo
        {
            public long addressIdApi { get; set; }//0
            public string CountryApi { get; set; }
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
            public long BuildingIdForCreationBuilding { get; set; }
            public long ImagesForCreationBuilding { get; set; }
        }

        public class WashingtonSquareInfo
        {
            public long addressIdApi { get; set; }//0
            public string CountryApi { get; set; }
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
            public long BuildingIdForCreationBuilding { get; set; }
            public long ImagesForCreationBuilding { get; set; }
        }

        public class CrownStInfo
        {
            public long addressIdApi { get; set; }//0
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class AlbermaleRdInfo
        {
            public long addressIdApi { get; set; }//0
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class East51stStreetPedestrianCrossingInfo
        {
            public long addressIdApi { get; set; }//0
            public string NumberRandomNameAddressStatic { get; set; }
            public string NumberNameAddressStatic { get; set; }
            public string NumberAddress { get; set; }
            public string AddressName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public long Zip { get; set; }
            public string Neighborhood { get; set; }
            public string BuildingName { get; set; }
            public string LlcName { get; set; }
        }

        public class PetPoliciesApiInfo
        {
            public string CaseByCase { get; set; }
            public string PetFee { get; set; }
            public string AllPetsAllowed { get; set; }
            public string SmallPetsAllowed { get; set; }
            public string CatsOnly { get; set; }
            public string NoPets { get; set; }
        }

        public class AmountApiInfo
        {
            public long CreditScreeningFeeByDefaultMySpace { get; set; }
            public long CreditScreeningFeeByDefaultEvergreen { get; set; }
            public long CreditScreeningFeeByDefaultDoorway { get; set; }
            public long HoldDepositByDefaultMySpace { get; set; }
            public long HoldDepositByDefaultEvergreen { get; set; }
            public long HoldDepositByDefaultDoorway { get; set; }
            public long CreditScreeningFeeOneNumber { get; set; }
            public long CreditScreeningFeeTwoNumber { get; set; }
            public long CreditScreeningFeeThreeNumber { get; set; }
            public long HoldDepositOneNumber { get; set; }
            public long HoldDepositTwoNumber { get; set; }
            public long HoldDepositThreeNumber { get; set; }

        }

        public class ShowOrderApiInfo
        {
            public long OrderPinCode { get; set; }
            public long OrderNote { get; set; }
        }

        public class ConnectionTypeApiInfo
        {
            public long NamePinCode { get; set; }
            public long NameNote { get; set; }
        }

        public class MySpaceAmountPaymentsInfo
        {
            public string CreditScreeningFeeByDefault { get; set; }
            public string CreditScreeningFeeRandom { get; set; }
            public string CreditScreeningFeeStatic { get; set; }
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
            public string NamePinCode { get; set; }
            public string NumberPinCode { get; set; }
            public string PinCodeNoteImage { get; set; }
            public string NoteNoteImage { get; set; }
        }

        public class SettingsConcessionsInfo
        {
            public long SpecialOfferId { get; set; }
            public long OneMonthFree { get; set; }
            public long TwoMonthsFree { get; set; }
            public string TwelveMonths { get; set; }
            public string ElevenMonths { get; set; }
            public DateTimeOffset TodayDate { get; set; }
            public DateTimeOffset YesterdayDate { get; set; }
            public DateTimeOffset TomorrowDate { get; set; }
            public long SubmittedApplication { get; set; }
            public long LeaseSigned { get; set; }
            public long MoveIn { get; set; }
        }

        public class SettingsFreeStuffInfo
        {
            public long SpecialOfferId { get; set; }
            public string SelectItemsFreeNetflixGoogleSpeaker { get; set; }
            public string SelectItemFreeNetflix { get; set; }
            public string SelectItemGoogleSpeaker { get; set; }
            public DateTimeOffset TodayDate { get; set; }
            public DateTimeOffset YesterdayDate { get; set; }
            public DateTimeOffset TomorrowDate { get; set; }
            public long SubmittedApplication { get; set; }
            public long LeaseSigned { get; set; }
            public long MoveIn { get; set; }
        }

        private static SaintJohnsonPlInfo CreateSaintJohnsonPlInfo()
        {
            return new SaintJohnsonPlInfo
            {
                addressIdApi = 0,
                CountryApi = "United States",
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(5) + " " + "Saint Johnson Place",
                NumberNameAddressStatic = "9999 Saint Johnson Place",
                NumberAddress = "9999",
                AddressName = "Saint Johnson Place",
                City = "Brooklyn",
                State = "NY",
                Zip = 11213,
                Neighborhood = "Crown Heights",
                BuildingName = "AGENT QA-Building Name 9999 Saint Johnson Place (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
                BuildingIdForCreationBuilding = 0,
                ImagesForCreationBuilding = 0,

            };
        }

        private static WashingtonSquareInfo CreateWashingtonSquareInfo()
        {
            return new WashingtonSquareInfo
            {
                addressIdApi = 0,
                CountryApi = "United States",
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(4) + " " + "Washington Square",
                NumberNameAddressStatic = "1 Washington Square",
                AddressName = "Washington Square",
                City = "New York",
                State = "NY",
                Zip = 10012,
                Neighborhood = "Manhattan",
                BuildingName = "Broker QA-Building Name 1 Washington Square (12345) (09876) (*&^%)",
                LlcName = "LLC Name QA Broker (12345) (09876) (*&^%)",
                BuildingIdForCreationBuilding = 0,
                ImagesForCreationBuilding = 0,
            };
        }

        private static CrownStInfo CreateCrownStInfo()
        {
            return new CrownStInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(3) + " " + "Crown St",
                NumberNameAddressStatic = "30-39 Crown St",
                NumberAddress = "30-39",
                AddressName = "Crown St",
                City = "Brooklyn",
                State = "NY",
                Zip = 11225,
                Neighborhood = "Crown Heights",
                BuildingName = " Broker QA-Building Name 30-39 Crown S (12345) (09876) (*&^%)",
                LlcName = "LLC Name QA Broker (12345) (09876) (*&^%)",
            };
        }

        private static AlbermaleRdInfo CreateAlbermaleRdInfo()
        {
            return new AlbermaleRdInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(2) + " " + "Albermale Rd",
                NumberNameAddressStatic = "1A Albermale Rd",
                NumberAddress = "1A",
                AddressName = "Albermale Rd",
                City = "Brooklyn",
                State = "NY",
                Zip = 11226,
                Neighborhood = "East Flatbush",
                BuildingName = "AGENT QA-Building Name 1A Albermale Rd (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static East51stStreetPedestrianCrossingInfo CreateEast51stStreetPedestrianCrossingInfo()
        {
            return new East51stStreetPedestrianCrossingInfo
            {
                NumberRandomNameAddressStatic = GenerateRandomData.RandomNumberWithoutZero(1) + " " + "East 51st Street Pedestrian Crossing",
                NumberNameAddressStatic = "111A East 51st Street Pedestrian Crossing",
                NumberAddress = "111A",
                AddressName = "East 51st Street Pedestrian Crossing",
                City = "New York",
                State = "NY",
                Zip = 10022,
                Neighborhood = "Manhattan",
                BuildingName = "QA-Building Name AGENT 111A East 51st Street Pedestrian Crossing (12345) (*&^%)",
                LlcName = "LLC Name QA Agent (12345) (09876) (*&^%)",
            };
        }

        private static PetPoliciesApiInfo CreatePetPoliciesApiInfo()
        {
            return new PetPoliciesApiInfo
            {
                CaseByCase = "CaseByCase",
                PetFee = "PetFee",
                AllPetsAllowed = "AllPetsAllowed",
                SmallPetsAllowed = "SmallPetsAllowed",
                CatsOnly = "CatsOnly",
                NoPets = "NoPets",
            };
        }

        private static AmountApiInfo CreateAmountApiInfo()
        {
            return new AmountApiInfo
            {
                CreditScreeningFeeByDefaultMySpace = 20,
                CreditScreeningFeeByDefaultEvergreen = 20,
                CreditScreeningFeeByDefaultDoorway = 20,
                HoldDepositByDefaultMySpace = 500,
                HoldDepositByDefaultEvergreen = 1000,
                HoldDepositByDefaultDoorway = 500,
                CreditScreeningFeeOneNumber= 1,
                CreditScreeningFeeTwoNumber = 11,
                CreditScreeningFeeThreeNumber = 299,
                HoldDepositOneNumber = 2,
                HoldDepositTwoNumber = 19,
                HoldDepositThreeNumber = 699
             };
        }

        private static ShowOrderApiInfo CreateShowOrderApiInfo()
        {
            return new ShowOrderApiInfo
            {
                OrderPinCode = 0,
                OrderNote = 1,
            };
        }

        private static ConnectionTypeApiInfo CreateConnectionTypeApiInfo()
        {
            return new ConnectionTypeApiInfo
            {
                NamePinCode = 2,
                NameNote = 3,
            };
        }

        private static MySpaceAmountPaymentsInfo CreateMySpaceAmountPaymentsInfo()
        {
            return new MySpaceAmountPaymentsInfo
            {
                CreditScreeningFeeByDefault = "20",
                CreditScreeningFeeRandom = GenerateRandomData.RandomNumberWithoutZero(2),
                CreditScreeningFeeStatic = "15",
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
                NamePinCode = "1 2 3 4 5",
                NumberPinCode = "1 2 3 4 5",
                PinCodeNoteImage = "https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-09/103_638625153411898967.jpeg?sv=2019-07-07&sr=c&sig=KDsQ7Qeq9PcO1P3nZZCm5joeII9wWM4qxgjQxDUr5aw%3D&se=9997-12-31T23%3A59%3A59Z&sp=r",
                NoteNoteImage = "",
            };
        }

        private static SettingsConcessionsInfo CreateSettingsConcessionsInfo()
        {
            return new SettingsConcessionsInfo
            {
                SpecialOfferId = 0,
                OneMonthFree = 1,
                TwoMonthsFree = 2,
                TwelveMonths = "12",
                ElevenMonths = "11",
                //DateTimeOffset dateFromTodayDate = DateTimeOffset.Parse("2024-06-08T04:00:00.000Z");
                TodayDate = DateTimeOffset.UtcNow,
                YesterdayDate = DateTimeOffset.UtcNow.AddDays(-1),
                TomorrowDate = DateTimeOffset.Parse("2024-09-30T20:59:59.999Z"),
                SubmittedApplication = 0,
                LeaseSigned = 1,
                MoveIn = 2,
            };
        }

        private static SettingsFreeStuffInfo CreateSettingsFreeStuffInfo()
        {
            //DateTime utcNow = DateTime.UtcNow;

            //string formattedDate = utcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            return new SettingsFreeStuffInfo
            {
                SpecialOfferId = 0,
                SelectItemFreeNetflix = "Free Netflix@@Google Speaker",
                SelectItemGoogleSpeaker = "",
                SelectItemsFreeNetflixGoogleSpeaker = "",
                //DateTimeOffset dateFromTodayDate = DateTimeOffset.Parse("2024-06-08T04:00:00.000Z");
                TodayDate = DateTimeOffset.UtcNow,
                YesterdayDate = DateTimeOffset.UtcNow.AddDays(-1),
                TomorrowDate = DateTimeOffset.Parse("2024-09-30T20:59:59.999Z"),
                SubmittedApplication = 0,
                LeaseSigned = 1,
                MoveIn = 2,
            };
        }
    }
}
