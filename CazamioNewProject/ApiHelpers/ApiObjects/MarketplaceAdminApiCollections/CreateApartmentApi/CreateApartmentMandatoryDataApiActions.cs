using CazamioNewProject.ApiHelpers;
using CazamioNewProject.DbHelpers.BuildingsTable;
using CazamioNewProject.GuiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.CreateApartmentMandatoryDataApi
{
    public partial class ApartmentCreation
    {
        public static RequestCreateApartmentMandatoryData RequestBodyCreateApartmentMandatoryData()
        {
            //9998 Saint Johnson Place
            // Get BuildingId from BD
            var buildingIdResult = BuildingsDbRequests.Buildings.GetBuildingIdNineNineNineEightSaintJohnsonPlace();
            long buildingId = buildingIdResult.AddressId;

            var payload = new RequestCreateApartmentMandatoryData
            {
                Apartments = new Apartment[]
                {
                    new Apartment
                    {
                        Unit = GenerateRandomData.RandomNumberWithoutZero(4),
                        LeasePrice = 850,
                        PaidMonths = 1,
                        DepositPrice = 850,
                        BrokerFeeRequired = false,
                        BedroomQuantity = 3,
                        BathroomQuantity = 2,
                        SquareFeet = 0,
                        PriceDateFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                        PriceDateTo = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"),
                        Description = "",
                        InternalNotes = "",
                        AvailableFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                        ApartmentType = "MultiFamily",
                        Status = "Vacant",
                        StaffId = null,
                        LeaseDurations = "12 months",
                        Amenities = new object[0],
                        IncludedInMonthlyRentAmenities = new object[0],
                        Images = new object[0],
                        ThreeDPhotos = new object[0],
                        Videos = new object[0],
                        VisitingHours = new VisitingHour[]
                        {
                            new VisitingHour { DayOfWeek = "Sunday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Monday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Tuesday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Wednesday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Thursday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Friday", OpenTime = null, CloseTime = null },
                            new VisitingHour { DayOfWeek = "Saturday", OpenTime = null, CloseTime = null }
                        },
                        RequiredDocumentsIds = new long[] { 1, 3, 6, 10, 21, 22 },
                        Floor = null,
                        FreeStuff = new object[0],
                        Concessions = new object[0],
                        HoldingDeposit = new HoldingDeposit
                        {
                            Amount = 500,
                            AllowedPaymentMethods = new string[] { "CreditCard" }
                        },
                        SelfTourStatus = false,
                        Locks = new Locks
                        {
                            BluetoothLocks = new object[0],
                            WifiLocks = new object[0],
                            PinCodeLocks = new object[0],
                            NoteLocks = new object[0],
                            CabLocks = new object[0],
                            ExistingOccupantLocks = new object[0]
                        }
                    }
                },
                BuildingId = buildingId
            };

            return payload;
        }

        public static RestResponse CreateApartmentMandatoryData(string token, RequestCreateApartmentMandatoryData apartmentRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);
            var restRequest = new RestRequest("api/apartments/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(apartmentRequestBody, Formatting.Indented));

            restRequest.AddJsonBody(apartmentRequestBody);
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
