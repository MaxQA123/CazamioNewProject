using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using CazamioNewProject.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData
{
    public partial class BuildingCreation
    {
        public static RequestCreateBuildingMandatoryDataWithAgent RequestBodyCreateBuildingFullDataBroker()
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

            var payload = new RequestCreateBuildingMandatoryDataWithAgent();
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
                demoApi.PetPoliciesApi.CaseByCase,
                demoApi.PetPoliciesApi.PetFee,
                demoApi.PetPoliciesApi.AllPetsAllowed,
                demoApi.PetPoliciesApi.SmallPetsAllowed,
                demoApi.PetPoliciesApi.CatsOnly,
                demoApi.PetPoliciesApi.NoPets
            };
            payload.OwnerId = owner.OwnerId.OwnerAndTenantPaysCommission;
            payload.BuildingId = demoApi.WashingtonSquare.BuildingIdForCreationBuilding;
            payload.BuildingName = demoApi.WashingtonSquare.BuildingName;
            payload.LlcName = demoApi.WashingtonSquare.LlcName;
            payload.Description = building.DescriptionsInternalNotes.DescriptionLong;
            payload.InternalNotes = building.DescriptionsInternalNotes.InternalNotesLong;
            payload.ScreeningFee = new HoldDeposit
            {
                Amount = demoApi.AmountApi.CreditScreeningFeeTwoNumber,
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
                Amount = demoApi.AmountApi.HoldDepositThreeNumber,
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
            payload.Locks = new Locks
            {
                BluetoothLocks = new object[0],
                WifiLocks = new object[0],
                CabLocks = new object[0],
                //BrokerId = broker.BrokerIdApi,
                //IsAgent = ApiRequestData.FALSE
            };
            return payload;
        }

        public static void CreateOwnerWithBrokerFullData(string token, RequestCreateBuildingMandatoryDataWithAgent buildingBody)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/buildings/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

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
