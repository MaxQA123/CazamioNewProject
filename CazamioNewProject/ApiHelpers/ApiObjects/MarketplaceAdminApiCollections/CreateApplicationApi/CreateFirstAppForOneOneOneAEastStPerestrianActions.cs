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
        public static RequestCreateAppWithBasicData RequestBodyCreateFirstAppForOneOneOneAEastStPerestrian()
        {
            TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
            Application application = Application.Generate();
            //111A East 51st Street Pedestrian Crossing
            //Get ApartmentId from BD
            var apartmentIdResult = ApartmentsDbRequests.ApartmentsDbTable.GetLastApartmentIdForOneOneOneAEastStPerestrian();
            long apartmentId = apartmentIdResult.Id;

            var payload = new RequestCreateAppWithBasicData
            {
                ApartmentId = apartmentId,
                LeasePrice = 850,
                ReferralDetails = application.ReferralDetails.ShortTextEastStreet,
                MoveInDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                OfferPrice = 850,
                RentPrePayment = 850,
                RentalTerms = "12 months",
                RequestedWork = application.RequestedWork.ShortTextEastStreet,
                SecurityDeposit = 850, //
                TenantEmail = tenantCreatorMySpace.CreatedWithCreditReport.Email,
                GeneratedLinkId = Guid.NewGuid()
            };

            return payload;
        }

        public static RestResponse CreateFirstAppForOneOneOneAEastStPerestrian(string token, RequestCreateAppWithBasicData applicationRequestBody)
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
