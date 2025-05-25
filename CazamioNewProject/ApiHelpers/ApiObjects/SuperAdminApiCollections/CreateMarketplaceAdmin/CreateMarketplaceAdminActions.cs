using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin
{
    public partial class MarketplaceAdminCreation
    {
        public static RequestCreateMarketplaceAdmin RequestBodyCreateMarketplaceAdmin()
        {
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
            BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

            var payload = new RequestCreateMarketplaceAdmin();
            payload.FirstName = marketplaceAdmin.MarkAdmName.FirstNameRandom;
            payload.LastName = marketplaceAdmin.MarkAdmName.LastNameRandom;
            payload.Email = marketplaceAdmin.MarkAdmEmail.FullEmailRandom;
            payload.Password = basicDataForProject.Passwords.BasicStaticFirst;
            payload.SubDomain = basicDataForProject.SubdomainMarketplace.MySpace;

            return payload;
        }

        public static RestResponse CreateMarketplaceAdmin(string token, RequestCreateMarketplaceAdmin marketplaceAdminRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/registerMarketplaceAdmin", Method.Post);
            restRequest.AddHeaders(Headers.HeadersMarketplaceAdmin(token));

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(marketplaceAdminRequestBody, Formatting.Indented));

            restRequest.AddJsonBody(marketplaceAdminRequestBody);

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
