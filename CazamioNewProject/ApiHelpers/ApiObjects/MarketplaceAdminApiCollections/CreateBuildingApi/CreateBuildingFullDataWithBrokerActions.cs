using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi
{
    //With full data +
    //With broker +
    public partial class BuildingCreation
    {
        public static RequestCreateBuildingFullDataWithBroker RequestBodyCreateBuildingFullDataBroker()
        {
            BuildingApi buildingApi = new BuildingApi().Generate();
            Building building = Building.Generate();
            PaymentOptions paymentOptions = new PaymentOptions().Generate();
            PaymentOptionsApi paymentOptionsApi = new PaymentOptionsApi().Generate();
            PaymentSettingsApi paymentSettingsApi = new PaymentSettingsApi().Generate();
            PaymentSettingsApiKey paymentSettingsApiKey = new PaymentSettingsApiKey().Generate();
            BuildingAmenitiesApiModel buildingAmenitiesApiModel = new BuildingAmenitiesApiModel().Generate();
            AccessLocksApi accessLocksApi = new AccessLocksApi().Generate();
            Broker broker = new Broker().Generate();
            Owner owner = new Owner().Generate();
            DemoApi demoApi = DemoApi.Generate();

            var payload = new RequestCreateBuildingFullDataWithBroker();
            payload.Address = new Address
            {
                Id = demoApi.WashingtonSquare.addressIdApi,
                Country = demoApi.WashingtonSquare.CountryApi,
                Street = demoApi.WashingtonSquare.NumberRandomNameAddressStatic,
                State = demoApi.WashingtonSquare.State,
                City = demoApi.WashingtonSquare.City,
                ZipCode = demoApi.WashingtonSquare.Zip,
                Neighborhood = demoApi.WashingtonSquare.Neighborhood
            }; 
            payload.PetPolicies = new string[]
            {
                buildingApi.PetPoliciesApi.CaseByCase,
                buildingApi.PetPoliciesApi.PetFee,
                buildingApi.PetPoliciesApi.AllPetsAllowed,
                buildingApi.PetPoliciesApi.SmallPetsAllowed,
                buildingApi.PetPoliciesApi.CatsOnly,
                buildingApi.PetPoliciesApi.NoPets
            };
            payload.OwnerId = owner.OwnerId.OwnerAndTenantPaysCommission;
            payload.BuildingId = buildingApi.BuildingId.ForCreationBuilding;
            payload.BuildingName = buildingApi.BuildingNameApi.BuldingNameStreetApiMarkAdmAssignedRoleBrkr;
            payload.LlcName = buildingApi.LlcNameApi.LlcNameStreetApiMarkAdmAssignedRoleBrkr;
            payload.Description = building.DescriptionsInternalNotes.DescriptionLong;
            payload.InternalNotes = building.DescriptionsInternalNotes.InternalNotesLong;
            payload.ScreeningFee = new ScreeningFee
            {
                Amount = buildingApi.AmountApi.CreditScreeningFeeByDefaultMySpace,
                DeliverCheckNote = paymentOptions.DeliverCheckNote.ForBuildingScreening,
                VenmoQrCode = paymentOptionsApi.VenmoQrCode.ScreeningFee,
                ZelleAddress = paymentOptions.Zelle.ForBuildingScreening,
                AllowedPaymentMethods = new string[]
                {
                    paymentOptionsApi.AllowedPaymentMethods.CreditCard,
                    paymentOptionsApi.AllowedPaymentMethods.Ach,
                    paymentOptionsApi.AllowedPaymentMethods.DeliverCheck,
                    paymentOptionsApi.AllowedPaymentMethods.Zelle,
                    paymentOptionsApi.AllowedPaymentMethods.Venmo
                }
            };
            payload.HoldDeposit = new HoldDeposit
            {
                Amount = buildingApi.AmountApi.HoldDepositByDefaultMySpace,
                DeliverCheckNote = paymentOptions.DeliverCheckNote.ForBuildingHold,
                VenmoQrCode = paymentOptionsApi.VenmoQrCode.HoldDepositBuilding,
                ZelleAddress = paymentOptions.Zelle.ForBuildingHold,
                AllowedPaymentMethods = new string[]
                {
                    paymentOptionsApi.AllowedPaymentMethods.CreditCard,
                    paymentOptionsApi.AllowedPaymentMethods.Ach,
                    paymentOptionsApi.AllowedPaymentMethods.DeliverCheck,
                    paymentOptionsApi.AllowedPaymentMethods.Zelle,
                    paymentOptionsApi.AllowedPaymentMethods.Venmo
                }
            };
            payload.ApiKey = new ApiKey
            {
                Id = paymentSettingsApi.Id.CardknoxByDefaultMySpace,
                IsAchInclude = ApiRequestData.TRUE,
                IsDefault = ApiRequestData.TRUE,
                Key = paymentSettingsApiKey.ApiKey.DefaultCardknoxMySpace,
                AuthorizeNetApiLoginId = ApiRequestData.NULL,
                PaymentSystem = paymentSettingsApi.PaymentSystem.CardknoxType
            };
            payload.Amenities = new Amenity[]
            {
                    new Amenity 
                    { 
                        Id = buildingAmenitiesApiModel.Id.IdLaundryInBuilding, 
                        Name = buildingAmenitiesApiModel.BuildingAmenites.LaundryInBuildingName,
                        AmenityType = buildingAmenitiesApiModel.AmenityType.Building
                    },
                    new Amenity
                    {
                        Id = buildingAmenitiesApiModel.Id.IdGym,
                        Name = buildingAmenitiesApiModel.BuildingAmenites.GymName,
                        AmenityType = buildingAmenitiesApiModel.AmenityType.Building
                    },
            };
            payload.Locks = new Locks
            {
                BluetoothLocks = new object[0],
                WifiLocks = new object[0],
                CabLocks = new object[0],
                PinCodeLocks = new ELock[]
                {
                    new ELock
                    {
                        Location = accessLocksApi.Location.FirstByDefault,
                        TimeRestrictionEnabled = ApiRequestData.FALSE,
                        CustomNote = building.AccessLocks.PinCodeTextLorem,
                        NoteImage = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534506736861274.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r"),
                        ShowOrder = buildingApi.ShowOrderApi.OrderPinCode,
                        ConnectionType = buildingApi.ConnectionTypeApi.PinCode,
                        Name = buildingApi.Name,
                        PinCode = buildingApi.PinCode
                    }
                },
                NoteLocks = new ELock[]
                {
                    new ELock
                    {
                        //CustomNote = Name
                        Location = accessLocksApi.Location.SecondByDefault,
                        TimeRestrictionEnabled = ApiRequestData.FALSE,
                        CustomNote = building.AccessLocks.NoteTextLorem,
                        NoteImage = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534506950505619.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r"),
                        ShowOrder = buildingApi.ShowOrderApi.OrderNote,
                        ConnectionType = buildingApi.ConnectionTypeApi.Note,
                        Name = building.AccessLocks.NoteTextLorem,
                    },
                },
                BrokerId = broker.BrokerIdApi,
                IsAgent = ApiRequestData.FALSE
            };
            payload.Concessions = new Concession[]
            {
                   new Concession
                   {
                        SpecialOfferId = buildingApi.SpecialOfferId,
                        MonthsFree = buildingApi.MonthsFree.OneMonth,
                        LeaseTerms = buildingApi.LeaseTerms.TwelveMonths,
                        AdditionalInfo = building.SettingsConcessions.AdditionalInfoShort,
                        IsActive = ApiRequestData.TRUE,
                        Name = building.SettingsConcessions.NameFirst,
                        IsTimeBased = ApiRequestData.TRUE,
                        DateFrom = buildingApi.DateFrom.TodayDate,
                        DateTo = buildingApi.DateTo.TodayDate,
                        TriggerEvent = buildingApi.TriggerEvent.SubmittedApplication,
                        GeneratedId = Guid.NewGuid()
                   }
            };
            payload.FreeStuff = new Concession[]
            {
                  new Concession
                  {
                        SpecialOfferId = buildingApi.SpecialOfferId,
                        FreeStuff = buildingApi.FreeStuff.SelectItemsFreeNetflixGoogleSpeaker,
                        IsActive = ApiRequestData.TRUE,
                        Name = building.SettingsFreeStuff.NameFirst,
                        IsTimeBased = ApiRequestData.TRUE,
                        DateFrom = buildingApi.DateFrom.TodayDate,
                        DateTo = buildingApi.DateTo.TodayDate,
                        TriggerEvent = buildingApi.TriggerEvent.LeaseSigned,
                        GeneratedId = Guid.NewGuid()
                  }
            };
            payload.Images = new Image[]
            {
                new Image
                {
                    Id = buildingApi.ImageId.ForCreationBuilding,
                    BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507763564461.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
                },
                new Image
                {
                    Id = buildingApi.ImageId.ForCreationBuilding,
                    BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507928267196.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
                },
                new Image
                {
                    Id = buildingApi.ImageId.ForCreationBuilding,
                    BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507945382415.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
                },
                new Image
                {
                    Id = buildingApi.ImageId.ForCreationBuilding,
                    BlobUrl = new Uri("https://cazamiostorage.blob.core.windows.net/staging-building-images-container-2024-06/103_638534507949273305.png?sv=2019-07-07&sr=c&sig=aIzYjCy%2BjHcegqNIQW3kBJcHarRcl%2Fwa5g7Y2gtGjTg%3D&se=9997-12-31T23%3A59%3A59Z&sp=r")
                },
            };
            return payload;
        }

        public static void CreateOwnerWithBrokerFullData(string token, RequestCreateBuildingFullDataWithBroker buildingBody)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/buildings/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(buildingBody);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
        }
    }
}
