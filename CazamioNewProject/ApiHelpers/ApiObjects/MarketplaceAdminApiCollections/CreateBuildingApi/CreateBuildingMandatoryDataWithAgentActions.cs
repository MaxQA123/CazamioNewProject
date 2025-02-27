using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData
{
    public partial class BuildingCreationMandatoryData
    {
        //Id = building.CommonApiData.BuildingId, always = 0
        //BuildingId = 0, always = 0
        public static RequestCreateBuildingMandatoryDataWithAgent RequestBodyCreateBuildingMandatoryDataWithAgent()
        {
            Building building = Building.Generate();
            Owner owner = Owner.Generate();
            PaymentOptions paymentOptions = PaymentOptions.Generate();

            var payload = new RequestCreateBuildingMandatoryDataWithAgent
            {
                Address = new Address
                {
                    Id = building.CommonApiData.BuildingId, 
                    Country = building.CommonApiData.CountryUnitedStates, 
                    Street = building.CommonApiData.StreetRandom, 
                    State = building.CommonApiData.StateNy, 
                    City = building.CommonApiData.CityNewYork, 
                    ZipCode = building.CommonApiData.ZipCode, 
                    Neighborhood = building.CommonApiData.EmptyString
                },
                PetPolicies = new object[0],
                OwnerId = owner.CreatedOwnerNoCommissioMySpace.OwnerIdApi,
                BuildingId = building.CommonApiData.BuildingId,
                BuildingName = building.CommonApiData.EmptyString,
                LlcName = building.CommonApiData.EmptyString,
                Description = building.CommonApiData.EmptyString,
                InternalNotes = building.CommonApiData.EmptyString,
                ScreeningFee = new HoldDeposit
                {
                    Amount = building.CommonApiData.ScreeningFeeByDefaultMySpace,
                    AllowedPaymentMethods = new string[] { paymentOptions.PaymentMethodsName.CreditCard }
                },
                HoldDeposit = new HoldDeposit
                {
                    Amount = building.CommonApiData.HoldDepositByDefaultMySpace, 
                    AllowedPaymentMethods = new string[] { paymentOptions.PaymentMethodsName.CreditCard }
                },
                ApiKey = new ApiKey
                {
                    Id = 2,
                    IsAchInclude = CommonApiData.TRUE,
                    IsDefault = CommonApiData.TRUE,
                    Key = "czmodev359376936c0543b58126c97f9ff55c68",
                    AuthorizeNetApiLoginId = null,
                    PaymentSystem = 1
                },
                Amenities = new object[0],
                Locks = new Locks
                {
                    BluetoothLocks = new object[0],
                    WifiLocks = new object[0],
                    PinCodeLocks = new object[0],
                    NoteLocks = new object[0],
                    CabLocks = new object[0]
                },
                Concessions = new object[0],
                FreeStuff = new object[0],
                Images = new object[0],
                Latitude = 40.726596,
                Longitude = -73.9834084
            };

            return payload;
        }

        public static RestResponse CreateBuildingMandatoryDataWithAgent(string token, RequestCreateBuildingMandatoryDataWithAgent buildingRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/buildings/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(buildingRequestBody, Formatting.Indented));

            restRequest.AddJsonBody(buildingRequestBody);

            var response = restClient.Execute(restRequest);

            Console.WriteLine("Response Status Code: " + response.StatusCode);
            Console.WriteLine("Response Headers: " + string.Join(", ", response.Headers));
            Console.WriteLine("Response Content: " + response.Content);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                string errorMessage = $"Request failed with status code: {response.StatusCode}";

                if (response.ErrorException != null)
                {
                    errorMessage += $"\nException: {response.ErrorException.Message}";
                }

                if (!string.IsNullOrEmpty(response.Content))
                {
                    errorMessage += $"\nResponse Content: {response.Content}";
                }
                else
                {
                    errorMessage += "\nNo additional error information provided by the server.";
                }

                throw new Exception(errorMessage); 
            }

            return response; 
        }
    }
}
