﻿using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi
{
    //With full data +
    //With broker
    public partial class BuildingCreation
    {
        public static RequestCreateBuildingFullDataWithBroker RequestBodyCreateBuildingFullDataBroker()
        {
            BuildingApi buildingApi = new BuildingApi().Generate();
            Building building = new Building().Generate();
            PaymentOptions paymentOptions = new PaymentOptions().Generate();
            PaymentOptionsApi paymentOptionsApi = new PaymentOptionsApi().Generate();
            PaymentSettingsApi paymentSettingsApi = new PaymentSettingsApi().Generate();
            PaymentSettingsApiKey paymentSettingsApiKey = new PaymentSettingsApiKey().Generate();
            BuildingAmenitiesApiModel buildingAmenitiesApiModel = new BuildingAmenitiesApiModel().Generate();
            AccessLocksApi accessLocksApi = new AccessLocksApi().Generate();

            var payload = new RequestCreateBuildingFullDataWithBroker();
            payload.Address = new Address
            {
                Id = buildingApi.AddressIdApi,
                Country = buildingApi.CountryApi,
                Street = buildingApi.StreetApi.MarkAdmAssignedRoleBrkr,
                State = buildingApi.StateApi,
                City = buildingApi.CityApi.NewYork,
                ZipCode = buildingApi.ZipCode.ZipBuildingMarkAdmAssignedRoleBrkr,
                Neighborhood = buildingApi.NeighborhoodApi.BuildingMarkAdmAssignedRoleBrkr
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
            payload.BuildingName = buildingApi.BuildingNameApi.BuldingNameStreetApiMarkAdmAssignedRoleBrkr;
            payload.LlcName = buildingApi.LlcNameApi.LlcNameStreetApiMarkAdmAssignedRoleBrkr;
            payload.Description = building.DescriptionLong;
            payload.InternalNotes = building.InternalNotesLong;
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
                        Location = accessLocksApi.Location.FirstByDefault
                    }
                }
            };

            //payload.BrokerId = broker.BrokerIdApi;
            //payload.IsAgent = ApiRequestData.FALSE;

            return payload;
        }

        //public static void CreateOwnerWithBrokerFullData(string token, RequestCreateBuildingFullDataWithBroker buildingBody)
        //{

        //    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

        //    var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

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
