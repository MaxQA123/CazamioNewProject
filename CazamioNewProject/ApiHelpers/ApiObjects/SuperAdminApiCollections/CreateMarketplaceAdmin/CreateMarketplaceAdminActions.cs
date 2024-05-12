using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin
{
    public partial class MarketplaceAdminCreation
    {
        public static RequestCreateMarketplaceAdmin RequestBody(string firstNameMarkAdm, string lastNameMarkAdm, string emailMarkAdm, string passwordMarkAdm, string subdomainMarkAdm)
        {
            var payload = new RequestCreateMarketplaceAdmin();
            payload.FirstName = firstNameMarkAdm;
            payload.LastName = lastNameMarkAdm;
            payload.Email = emailMarkAdm;
            payload.Password = passwordMarkAdm;
            payload.SubDomain = subdomainMarkAdm;

            return payload;
        }

        public static void CreateMarketplaceAdmin(string token, string firstNameMarkAdm, string lastNameMarkAdm, string emailMarkAdm, string passwordMarkAdm, string subdomainMarkAdm)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/registerMarketplaceAdmin", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(RequestBody(firstNameMarkAdm, lastNameMarkAdm, emailMarkAdm, passwordMarkAdm, subdomainMarkAdm));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
        }
    }
}
