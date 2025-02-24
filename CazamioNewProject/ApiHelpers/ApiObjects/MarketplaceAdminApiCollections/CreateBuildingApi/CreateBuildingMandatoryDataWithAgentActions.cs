using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData
{
    public partial class BuildingCreationMandatoryData
    {
        public static RequestCreateBuildingMandatoryDataWithAgent RequestBodyCreateBuildingMandatoryDataWithAgent()
        {
            Building building = Building.Generate();

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
                    Neighborhood = "" 
                },
                PetPolicies = new object[0],
                OwnerId = 1,
                BuildingId = 0,
                BuildingName = "",
                LlcName = "",
                Description = "",
                InternalNotes = "",
                ScreeningFee = new HoldDeposit
                {
                    Amount = 20,
                    AllowedPaymentMethods = new string[] { "CreditCard" }
                },
                HoldDeposit = new HoldDeposit
                {
                    Amount = 500, 
                    AllowedPaymentMethods = new string[] { "CreditCard" }
                },
                ApiKey = new ApiKey
                {
                    Id = 2,
                    IsAchInclude = true,
                    IsDefault = true,
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

        public static void CreateBuildingMandatoryDataWithAgent(string token, RequestCreateBuildingMandatoryDataWithAgent buildingBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/buildings/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

            // Логируем тело запроса
            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(buildingBody, Formatting.Indented));

            restRequest.AddJsonBody(buildingBody);

            var response = restClient.Execute(restRequest);

            // Логируем статус код, заголовки и содержимое ответа
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
        }
    }
}
