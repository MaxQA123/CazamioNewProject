using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateApplicationApi
{
    public partial class ApplicationCreation
    {
        public static RequestCreateAppWithBasicData RequestBodyCreateFirstAppForOneTwoFiveSixSevenDeanStreet()
        {
            //9998 Saint Johnson Place
            // Get BuildingId from BD
            var buildingIdResult = BuildingsDbRequests.Buildings.GetBuildingIdNineNineNineEightSaintJohnsonPlace();
            long buildingId = buildingIdResult.AddressId;

            var payload = new RequestCreateAppWithBasicData
            {
                ApartmentId = /* You'll need to provide apartment ID here */,
                LeasePrice = 850,
                ReferralDetails = "", 
                MoveInDate = DateTimeOffset.Now, 
                OfferPrice = 850, 
                RentPrePayment = 850, 
                RentalTerms = "12 months", 
                RequestedWork = null, 
                SecurityDeposit = 850, //
                TenantEmail = "", 
                GeneratedLinkId = Guid.NewGuid()
            };

            return payload;
        }

        public static RestResponse CreateApartmentForAppNineNineNineEightSaintJohnsonPlaceActions(string token, RequestCreateAppWithBasicData applicationRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);
            var restRequest = new RestRequest("api/apartments/create", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(applicationRequestBody, Formatting.Indented));

            restRequest.AddJsonBody(applicationRequestBody);
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
