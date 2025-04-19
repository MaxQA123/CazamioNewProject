using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi;
using CazamioNewProject.CreateApartmentMandatoryDataApi;
using CazamioNewProject.DbHelpers.BuildingsTable;
using CazamioNewProject.GuiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;
using Locks = CazamioNewProject.CreateApartmentMandatoryDataApi.Locks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateApartmentApi
{
    //CreateApartmentForAppNineNineNineEightSaintJohnsonPlaceActions
    public partial class ApartmentCreation
    {
        public static RequestCreateApartmentMandatoryData RequestBodyCreateApartmentForAppNineNineNineEightSaintJohnsonPlace()
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
                SquareFeet = 1200,
                PriceDateFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                PriceDateTo = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"),
                Description = "Newly renovated apartment with modern amenities",
                InternalNotes = "Ready for immediate occupancy",
                AvailableFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                ApartmentType = "MultiFamily",
                Status = "Vacant",
                StaffId = null,
                LeaseDurations = "12 months",
                Amenities = Array.Empty<object>(),
                IncludedInMonthlyRentAmenities = Array.Empty<object>(),
                Images = Array.Empty<object>(),
                ThreeDPhotos = Array.Empty<object>(),
                Videos = Array.Empty<object>(),
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
                Concessions = new Concession[]
                {
                    new Concession
                    {
                        SpecialOfferId = 1,
                        MonthsFree = 1,
                        LeaseTerms = "12 months lease",
                        AdditionalInfo = "First month free on annual lease",
                        IsTimeBased = true,
                        Name = "First Month Free",
                        IsActive = true
                    }
                },
                HoldingDeposit = new HoldingDeposit
                {
                    Amount = 500,
                    AllowedPaymentMethods = new string[] { "CreditCard", "BankTransfer" }
                },
                SelfTourStatus = false,
                Locks = new Locks
                {
                    BluetoothLocks = Array.Empty<object>(),
                    WifiLocks = Array.Empty<object>(),
                    PinCodeLocks = Array.Empty<object>(),
                    NoteLocks = Array.Empty<object>(),
                    CabLocks = Array.Empty<object>(),
                    ExistingOccupantLocks = Array.Empty<object>()
                },
            }
        },
                BuildingId = buildingId
            };

            return payload;
        }

        public static RestResponse CreateApartmentForAppNineNineNineEightSaintJohnsonPlace(string token, RequestCreateApartmentMandatoryData apartmentRequestBody)
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
