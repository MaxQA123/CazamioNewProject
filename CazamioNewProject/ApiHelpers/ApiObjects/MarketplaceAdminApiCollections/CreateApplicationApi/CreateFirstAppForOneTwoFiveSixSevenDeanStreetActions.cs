using CazamioNewProject.ApiHelpers;
using CazamioNewProject.DbHelpers.ApartmentsTable;
using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.CreateApplicationApi
{
    public partial class ApplicationCreation
    {
        public static RequestCreateAppWithBasicData RequestBodyCreateFirstAppForOneTwoFiveSixSevenDeanStreet()
        {
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            //12567 Dean Street
            //Get ApartmentId from BD
            var apartmentIdResult = ApartmentsDbRequests.ApartmentsDbTable.GetLastApartmentId();
            long apartmentId = apartmentIdResult.Id;

            var payload = new RequestCreateAppWithBasicData
            {
                ApartmentId = apartmentId,
                LeasePrice = 850,
                ReferralDetails = "",
                MoveInDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                OfferPrice = 850,
                RentPrePayment = 850,
                RentalTerms = "12 months",
                RequestedWork = null,
                SecurityDeposit = 850, //
                TenantEmail = tenantCreatorMySpace.Emails.RandomMainApplicantEmail,
                GeneratedLinkId = Guid.NewGuid()
            };

            return payload;
        }

        public static RestResponse CreateFirstAppForOneTwoFiveSixSevenDeanStreet(string token, RequestCreateAppWithBasicData applicationRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);
            var restRequest = new RestRequest("api/apartmentApplications/prepareApplication?isBarebones=false", Method.Post);
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
