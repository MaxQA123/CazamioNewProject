using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
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
            // Генерация данных
            Building building = Building.Generate();

            // Создание payload
            var payload = new RequestCreateBuildingMandatoryDataWithAgent
            {
                Address = new Address
                {
                    Id = building.CommonApiData.BuildingId, // Указано в примере
                    Country = building.CommonApiData.CountryUnitedStates, // Указано в примере
                    Street = building.CommonApiData.StreetRandom, // Указано в примере
                    State = building.CommonApiData.StateNy, // Указано в примере
                    City = building.CommonApiData.CityNewYork, // Указано в примере
                    ZipCode = 11234, // Указано в примере
                    Neighborhood = building.CommonApiData.NeighborhoodEmpty // Указано в примере
                },
                PetPolicies = new object[0], // Пустой массив, как в примере
                OwnerId = 1, // Указано в примере
                BuildingId = 0, // Указано в примере
                BuildingName = "", // Указано в примере
                LlcName = "", // Указано в примере
                Description = "", // Указано в примере
                InternalNotes = "", // Указано в примере
                ScreeningFee = new HoldDeposit
                {
                    Amount = 20, // Указано в примере
                    AllowedPaymentMethods = new string[] { "CreditCard" } // Указано в примере
                },
                HoldDeposit = new HoldDeposit
                {
                    Amount = 500, // Указано в примере
                    AllowedPaymentMethods = new string[] { "CreditCard" } // Указано в примере
                },
                ApiKey = new ApiKey
                {
                    Id = 2, // Указано в примере
                    IsAchInclude = true, // Указано в примере
                    IsDefault = true, // Указано в примере
                    Key = "czmodev359376936c0543b58126c97f9ff55c68", // Указано в примере
                    AuthorizeNetApiLoginId = null, // Указано в примере
                    PaymentSystem = 1 // Указано в примере
                },
                Amenities = new object[0], // Пустой массив, как в примере
                Locks = new Locks
                {
                    BluetoothLocks = new object[0], // Пустой массив, как в примере
                    WifiLocks = new object[0], // Пустой массив, как в примере
                    PinCodeLocks = new object[0], // Пустой массив, как в примере
                    NoteLocks = new object[0], // Пустой массив, как в примере
                    CabLocks = new object[0] // Пустой массив, как в примере
                },
                Concessions = new object[0], // Пустой массив, как в примере
                FreeStuff = new object[0], // Пустой массив, как в примере
                Images = new object[0], // Пустой массив, как в примере
                Latitude = 40.726596, // Указано в примере
                Longitude = -73.9834084 // Указано в примере
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

            // Логируем статус код и содержимое ответа
            Console.WriteLine("Response Status Code: " + response.StatusCode);
            Console.WriteLine("Response Content: " + response.Content);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                // Если содержимое ответа пустое, добавляем больше информации
                string errorMessage = string.IsNullOrEmpty(response.Content)
                    ? $"Request failed with status code: {response.StatusCode}"
                    : response.Content;

                throw new Exception(errorMessage);
            }
        }

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
