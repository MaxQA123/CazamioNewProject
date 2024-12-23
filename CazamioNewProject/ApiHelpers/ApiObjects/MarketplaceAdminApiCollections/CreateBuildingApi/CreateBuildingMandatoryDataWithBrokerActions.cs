using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData
{
    public partial class BuildingCreationMandatoryData
    {
        //public static RequestCreateBuildingMandatoryDataWithAgent RequestBodyCreateBuildingMandatoryDataWithAgent()
        //{
        //    BuildingApi buildingApi = new BuildingApi().Generate();
        //    Building building = Building.Generate();
        //    PaymentOptions paymentOptions = new PaymentOptions().Generate();
        //    PaymentOptionsApi paymentOptionsApi = new PaymentOptionsApi().Generate();
        //    PaymentSettingsApi paymentSettingsApi = new PaymentSettingsApi().Generate();
        //    PaymentSettingsApiKey paymentSettingsApiKey = new PaymentSettingsApiKey().Generate();
        //    BuildingAmenitiesApiModel buildingAmenitiesApiModel = new BuildingAmenitiesApiModel().Generate();
        //    AccessLocksApi accessLocksApi = new AccessLocksApi().Generate();
        //    Broker broker = new Broker().Generate();
        //    Owner owner = Owner.Generate();
        //    DemoApi demoApi = DemoApi.Generate();

        //    var payload = new RequestCreateBuildingMandatoryDataWithAgent();
        //    payload.Address = new Address
        //    {
        //        Id = demoApi.WashingtonSquare.addressIdApi,
        //        Country = demoApi.WashingtonSquare.CountryApi,
        //        Street = demoApi.WashingtonSquare.NumberRandomNameAddressStatic,
        //        State = demoApi.WashingtonSquare.State,
        //        City = demoApi.WashingtonSquare.City,
        //        ZipCode = demoApi.WashingtonSquare.Zip,
        //        Neighborhood = demoApi.WashingtonSquare.Neighborhood
        //    };
        //    payload.PetPolicies = new string[]
        //    {
        //        demoApi.PetPoliciesApi.CaseByCase,
        //        demoApi.PetPoliciesApi.PetFee,
        //        demoApi.PetPoliciesApi.AllPetsAllowed,
        //        demoApi.PetPoliciesApi.SmallPetsAllowed,
        //        demoApi.PetPoliciesApi.CatsOnly,
        //        demoApi.PetPoliciesApi.NoPets
        //    };
        //    payload.OwnerId = owner.OwnerId.WithBroker;
        //    payload.BuildingId = demoApi.WashingtonSquare.BuildingIdForCreationBuilding;
        //    payload.BuildingName = "";
        //    payload.LlcName = "";
        //    payload.Description = "";
        //    payload.InternalNotes = "";
        //    payload.ScreeningFee = new HoldDeposit
        //    {
        //        Amount = demoApi.AmountApi.CreditScreeningFeeTwoNumber,
        //        DeliverCheckNote = paymentOptions.DeliverCheckNote.ForBuildingScreening,
        //        VenmoQrCode = paymentOptionsApi.VenmoQrCode.ScreeningFee,
        //        ZelleAddress = paymentOptions.Zelle.ForBuildingScreening,
        //        AllowedPaymentMethods = new string[]
        //        {
        //            paymentOptionsApi.AllowedPaymentMethods.CreditCard,
        //            paymentOptionsApi.AllowedPaymentMethods.Ach,
        //            paymentOptionsApi.AllowedPaymentMethods.DeliverCheck,
        //            paymentOptionsApi.AllowedPaymentMethods.Zelle,
        //            paymentOptionsApi.AllowedPaymentMethods.Venmo
        //        }
        //    };
        //    payload.HoldDeposit = new HoldDeposit
        //    {
        //        Amount = demoApi.AmountApi.HoldDepositThreeNumber,
        //        DeliverCheckNote = paymentOptions.DeliverCheckNote.ForBuildingHold,
        //        VenmoQrCode = paymentOptionsApi.VenmoQrCode.HoldDepositBuilding,
        //        ZelleAddress = paymentOptions.Zelle.ForBuildingHold,
        //        AllowedPaymentMethods = new string[]
        //        {
        //            paymentOptionsApi.AllowedPaymentMethods.CreditCard,
        //            paymentOptionsApi.AllowedPaymentMethods.Ach,
        //            paymentOptionsApi.AllowedPaymentMethods.DeliverCheck,
        //            paymentOptionsApi.AllowedPaymentMethods.Zelle,
        //            paymentOptionsApi.AllowedPaymentMethods.Venmo
        //        }
        //    };
        //    payload.ApiKey = new ApiKey
        //    {
        //        Id = paymentSettingsApi.Id.CardknoxByDefaultMySpace,
        //        IsAchInclude = ApiRequestData.TRUE,
        //        IsDefault = ApiRequestData.TRUE,
        //        Key = paymentSettingsApiKey.ApiKey.DefaultCardknoxMySpace,
        //        AuthorizeNetApiLoginId = ApiRequestData.NULL,
        //        PaymentSystem = paymentSettingsApi.PaymentSystem.CardknoxType
        //    };
        //    //payload.Amenities = new Amenity[]
        //    //{
        //    //        new Amenity
        //    //        {
        //    //            Id = buildingAmenitiesApiModel.Id.IdLaundryInBuilding,
        //    //            Name = buildingAmenitiesApiModel.BuildingAmenites.LaundryInBuildingName,
        //    //            AmenityType = buildingAmenitiesApiModel.AmenityType.Building
        //    //        },
        //    //        new Amenity
        //    //        {
        //    //            Id = buildingAmenitiesApiModel.Id.IdGym,
        //    //            Name = buildingAmenitiesApiModel.BuildingAmenites.GymName,
        //    //            AmenityType = buildingAmenitiesApiModel.AmenityType.Building
        //    //        },
        //    //};
        //    payload.Locks = new Locks
        //    {
        //        BluetoothLocks = new object[0],
        //        WifiLocks = new object[0],
        //        CabLocks = new object[0],
        //        PinCodeLocks = new object[0],
        //        NoteLocks = new object[0],

        //    };
        //    //payload.Concessions = new Concession[]
        //    //{
        //    //       new Concession
        //    //       {
        //    //            SpecialOfferId = demoApi.SettingsConcessions.SpecialOfferId,
        //    //            MonthsFree = demoApi.SettingsConcessions.OneMonthFree,
        //    //            LeaseTerms = demoApi.SettingsConcessions.TwelveMonths,
        //    //            AdditionalInfo = building.SettingsConcessions.AdditionalInfoShort,
        //    //            IsActive = ApiRequestData.TRUE,
        //    //            Name = building.SettingsConcessions.NameFirst,
        //    //            IsTimeBased = ApiRequestData.TRUE,
        //    //            DateFrom = demoApi.SettingsConcessions.TodayDate,
        //    //            DateTo = demoApi.SettingsConcessions.TodayDate,
        //    //            TriggerEvent = demoApi.SettingsConcessions.SubmittedApplication,
        //    //            GeneratedId = Guid.NewGuid()
        //    //       }
        //    //};
        //    //payload.FreeStuff = new FreeStuff[]
        //    //{
        //    //      new FreeStuff
        //    //      {
        //    //            SpecialOfferId = demoApi.SettingsFreeStuff.SpecialOfferId,
        //    //            FreeStuffFreeStuff = demoApi.SettingsFreeStuff.SelectItemsFreeNetflixGoogleSpeaker,
        //    //            IsActive = ApiRequestData.TRUE,
        //    //            Name = building.SettingsFreeStuff.NameFirst,
        //    //            IsTimeBased = ApiRequestData.TRUE,
        //    //            DateFrom = demoApi.SettingsFreeStuff.TodayDate,
        //    //            DateTo = demoApi.SettingsFreeStuff.TodayDate,
        //    //            TriggerEvent = demoApi.SettingsFreeStuff.LeaseSigned,
        //    //            GeneratedId = Guid.NewGuid()
        //    //      }
        //    //};
        //    //payload.Images = new Image[]
        //    //{
        //    //    new Image
        //    //    {
        //    //        Id = demoApi.WashingtonSquare.ImagesForCreationBuilding,
        //    //        BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507763564461.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
        //    //    },
        //    //    new Image
        //    //    {
        //    //        Id = demoApi.WashingtonSquare.ImagesForCreationBuilding,
        //    //        BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507928267196.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
        //    //    },
        //    //    new Image
        //    //    {
        //    //        Id = demoApi.WashingtonSquare.ImagesForCreationBuilding,
        //    //        BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507945382415.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
        //    //    },
        //    //    new Image
        //    //    {
        //    //        Id = demoApi.WashingtonSquare.ImagesForCreationBuilding,
        //    //        BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507949273305.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
        //    //    },
        //    //};
        //    return payload;
        //}

        //public static void CreateBuildingMandatoryDataWithAgent(string token, RequestCreateBuildingMandatoryDataWithAgent buildingBody)
        //{

        //    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

        //    var restRequest = new RestRequest("api/buildings/create", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

        //    restRequest.AddJsonBody(buildingBody);

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusCode != System.Net.HttpStatusCode.OK)
        //    {
        //        throw new Exception(response.Content);
        //    }
        //}
    }
}
