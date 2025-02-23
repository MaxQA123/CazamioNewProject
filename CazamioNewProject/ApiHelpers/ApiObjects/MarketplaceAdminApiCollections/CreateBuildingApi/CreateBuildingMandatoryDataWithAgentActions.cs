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
                    Id = 0, // Указано в примере
                    Country = "United States", // Указано в примере
                    Street = "56789 Avenue A", // Указано в примере
                    State = "NY", // Указано в примере
                    City = "New York", // Указано в примере
                    ZipCode = 11234, // Указано в примере
                    Neighborhood = "" // Указано в примере
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
