using CazamioNewProject.ApiHelpers;
using CazamioNewProject.DbHelpers.ApartmentsTable;
using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.AddApplicantsApi
{
    public partial class AddApplicants
    {
        public static RequestAddApplicants RequestBodyAddOccupantAppForOneOneOneAEastStPerestrian()
        {
            TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();
            //111A East 51st Street Pedestrian Crossing
            //Get ApartmentApplicationId from BD
            var apartmentApplicationIdResult = ApartmentApplicationsDbRequests.ApartmentApplicationsDbTable.GetLastApartmentApplicationIdForOneOneOneAEastStPerestrian();
            long apartmentApplicationId = apartmentApplicationIdResult.Id;

            var payload = new RequestAddApplicants
            {
                ApplicationId = apartmentApplicationId, 
                Applicants = new Applicant[]
                {
            new Applicant
            {
                Suggestions = Array.Empty<object>(), 
                Email = tenantOccupantMySpace.CreatedWithCreditReport.Email, 
                IsGuarantor = false 
            },
                }
            };

            return payload;
        }

        public static RestResponse AddOccupantAppForOneOneOneAEastStPerestrian(string token, RequestAddApplicants applicationRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);
            var restRequest = new RestRequest("api/apartmentApplications/addApplicants", Method.Post);
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
