using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    public partial class OwnerCreation
    {
        public static RequestCreateOwnerNoCommissionAg RequestBodyOwnerNoCommissionAg()
        {
            Owner owner = Owner.Generate();
            AgentBroker agentBroker = AgentBroker.Generate();

            var payload = new RequestCreateOwnerNoCommissionAg
            {
                CompanyName = owner.CompanyName.AssignedAgentMaxSymbols,
                OwnerEmail = owner.OwnerEmail.putsbox,
                OwnerName = owner.OwnerName.FirstLastNameRandom,
                OfficeLocation = null,
                Note = null,
                PhoneNumbers = new object[0],
                Managements = new object[0],
                CommissionStructures = new object[0],
                AssignedUserId = Guid.Parse(agentBroker.CreatedAgentMySpace.AssignedUserId) // или динамически генерируйте Guid
            };

            return payload;
        }

        public static RestResponse CreateOwnerNoCommissionAg(string token, RequestCreateOwnerNoCommissionAg ownerBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(ownerBody, Formatting.Indented));

            restRequest.AddJsonBody(ownerBody);

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
