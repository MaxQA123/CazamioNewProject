using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateAgentApi
{
    public partial class AgentCreation
    {
        public static RequestCreateAgent RequestBody(string firstNameAgent, string lastNameAgent, string emailAgent, string phoneNumberAgent, long brokerCommissionAgent, long agentCommissionAgent, string cellAgent)
        {
            var payload = new RequestCreateAgent();
            payload.FirstName = firstNameAgent;
            payload.LastName = lastNameAgent;
            payload.Email = emailAgent;
            payload.PhoneNumber = phoneNumberAgent;
            payload.BrokerCommission = brokerCommissionAgent;
            payload.AgentCommission = agentCommissionAgent;
            payload.Cell = cellAgent;

            return payload;
        }

        public static void CreateAgent(string token, string firstNameAgent, string lastNameAgent, string emailAgent, string phoneNumberAgent, long brokerCommissionAgent, long agentCommissionAgent, string cellAgent)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/brokers/registerBroker", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(RequestBody(firstNameAgent, lastNameAgent, emailAgent, phoneNumberAgent, brokerCommissionAgent, agentCommissionAgent, cellAgent));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
        }
    }
}
