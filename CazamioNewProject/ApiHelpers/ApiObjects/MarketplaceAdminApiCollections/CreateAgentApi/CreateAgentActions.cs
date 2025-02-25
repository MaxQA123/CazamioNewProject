using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateAgentApi
{
    public partial class AgentCreation
    {
        public static RequestCreateAgent RequestBodyCreateAgent()
        {
            Agent agent = Agent.Generate();

            var payload = new RequestCreateAgent();
            payload.FirstName = agent.AgentName.FirstNameRandom;
            payload.LastName = agent.AgentName.LastNameRandom;
            payload.Email = agent.AgentEmail.FullEmailRandom;
            payload.PhoneNumber = agent.PhoneNumber.BasicFirst;
            payload.BrokerCommission = agent.CommissionPercentage.BrokerCommissionApi;
            payload.AgentCommission = agent.CommissionPercentage.AgentCommissionApi;
            payload.Cell = agent.PhoneNumber.CellFirst;

            return payload;
        }

        public static RestResponse CreateAgent(string token, RequestCreateAgent bodyRequestCreateAgent)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/agents/registerAgent", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            // Логируем тело запроса
            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(bodyRequestCreateAgent, Formatting.Indented));

            restRequest.AddJsonBody(bodyRequestCreateAgent);

            var response = restClient.Execute(restRequest);

            // Логируем статус код, заголовки и содержимое ответа
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
