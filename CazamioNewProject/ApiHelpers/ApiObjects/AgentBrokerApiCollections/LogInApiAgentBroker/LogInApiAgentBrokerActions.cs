using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.AgentBrokerApiCollections.LogInApiAgentBroker
{
    public partial class LogInApiAgentBroker
    {
        public static RequestLogInAgentBroker RequestBody(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var payload = new RequestLogInAgentBroker();
            payload.Email = email;
            payload.Password = password;
            payload.DeviceFingerprint = deviceFingerprint;
            payload.RememberMe = rememberMe;

            return payload;
        }

        public static ResponseLogInAgentBroker ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/loginLandlord", Method.Post);
            restRequest.AddHeaders(Headers.HeadersForLogIn());

            restRequest.AddJsonBody(RequestBody(email, password, deviceFingerprint, rememberMe));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogInAgentBroker>(content);

            return dtoObject;
        }
    }
}
