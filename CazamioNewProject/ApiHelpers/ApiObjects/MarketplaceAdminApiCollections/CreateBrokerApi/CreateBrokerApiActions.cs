using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBrokerApi
{
    public partial class BrokerCreation
    {
        public static RequestCreateBroker RequestBody(string firstNameBroker, string lastNameBroker, string emailBroker, string passwordBroker)
        {
            var payload = new RequestCreateBroker();
            payload.FirstName = firstNameBroker;
            payload.LastName = lastNameBroker;
            payload.Email = emailBroker;
            payload.Password = passwordBroker;

            return payload;
        }

        public static void CreateBroker(string token, string firstNameBroker, string lastNameBroker, string emailBroker, string passwordBroker)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/registerLandlord", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(RequestBody(firstNameBroker, lastNameBroker, emailBroker, passwordBroker));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
        }
    }
}
