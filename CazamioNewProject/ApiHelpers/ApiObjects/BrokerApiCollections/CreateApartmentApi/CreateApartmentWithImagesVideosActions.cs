using CazamioNewProject.ApiHelpers;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BuildingsTable;
using CazamioNewProject.GuiHelpers;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.CreateApartmentMandatoryDataApi
{
    public partial class ApartmentCreation
    {
        public static RequestCreateApartmentMandatoryData RequestBodyCreateApartmentWithImagesVideos()
        {
            //30-39 Crown St
            // Get BuildingId from BD
            var buildingIdResult = BuildingsDbRequests.Buildings.GetBuildingIdThirtyDashTrirtyNineCrownSt();
            long buildingId = buildingIdResult.AddressId;
            var agentIdResult = AspNetUsersDbRequests.AspNetUsers.GetAgentIdByEmailAndMarketplaceId();
            string agentId = agentIdResult.Id;

            var payload = new RequestCreateApartmentMandatoryData
            {
                Apartments = new Apartment[]
                {
            new Apartment
            {
                Unit = GenerateRandomData.RandomAlphabetUpperCase(1) + GenerateRandomData.RandomAlphabetUpperCase(1) + GenerateRandomData.RandomAlphabetUpperCase(1) + GenerateRandomData.RandomAlphabetUpperCase(1),
                LeasePrice = 3333,
                PaidMonths = 2,
                DepositPrice = 7000,
                BrokerFeeRequired = false,
                BedroomQuantity = 2,
                BathroomQuantity = 1,
                SquareFeet = 0,
                PriceDateFrom = DateTime.Now.ToString("yyyy-MM-dd"),
                PriceDateTo = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd"),
                Description = "",
                InternalNotes = "",
                AvailableFrom = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
                ApartmentType = "MultiFamily",
                Status = "ApplicationSubmitted",
                StaffId = agentId,
                LeaseDurations = "10 months",
                Amenities = new object[0],
                IncludedInMonthlyRentAmenities = new object[0],
                Images = new object[]
                {
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-images-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832591416052657.jpeg?sv=2025-05-05&se=2027-05-19T13%3A45%3A41Z&sr=b&sp=r&sig=LxzyrkrssRnO9ypbMqQxgVMSpu%2BSzVFQWYajqg0NX8g%3D",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-images-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832591425838924.jpeg?sv=2025-05-05&se=2027-05-19T13%3A45%3A42Z&sr=b&sp=r&sig=qo0Icwd1wq3DLN3DNTJMN%2F8YVvvXS4UZGG4LGthP8Qg%3D",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-images-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832591418934732.jpeg?sv=2025-05-05&se=2027-05-19T13%3A45%3A42Z&sr=b&sp=r&sig=3qBHIhyczrNfgdgBoZDrbvwBM4S7su9dos7pdyY68kc%3D",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-images-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832591418934732.jpeg?sv=2025-05-05&se=2027-05-19T13%3A45%3A42Z&sr=b&sp=r&sig=3qBHIhyczrNfgdgBoZDrbvwBM4S7su9dos7pdyY68kc%3D",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-images-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832591418934732.jpeg?sv=2025-05-05&se=2027-05-19T13%3A45%3A42Z&sr=b&sp=r&sig=3qBHIhyczrNfgdgBoZDrbvwBM4S7su9dos7pdyY68kc%3D",
                        isVertical = false
                    }
                },
                ThreeDPhotos = new object[0],
                Videos = new object[]
                {
                    new
                    {
                        id = 0,
                        blobUrl = "https://www.youtube.com/embed/0mh5d2a8wp0?enablejsapi=1",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://player.vimeo.com/video/988164102",
                        isVertical = false
                    },
                    new
                    {
                        id = 0,
                        blobUrl = "https://cazamiostorage.blob.core.windows.net/staging-apartment-videos-container-2025-05/807d61ec-8d36-4748-9a1d-fd5fa755accd_638832592070371120.mp4?sv=2025-05-05&se=2027-05-19T13%3A46%3A47Z&sr=b&sp=r&sig=2MECLieUtXDk6fIHqfmncXXoMGGVdNVOhsN%2BFyOUHnw%3D",
                        isVertical = false
                    }
                },
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

        public static RestResponse CreateApartmentWithImagesVideos(string token, RequestCreateApartmentMandatoryData apartmentRequestBody)
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
