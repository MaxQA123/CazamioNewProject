using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker
{
    public partial class LogInApiBroker
    {
        public static RequestLogInApiBroker RequestBody(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var payload = new RequestLogInApiBroker();
            payload.Email = email;
            payload.Password = password;
            payload.DeviceFingerprint = deviceFingerprint;
            payload.RememberMe = rememberMe;

            return payload;
        }

        public static ResponseLogInApiBroker ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
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

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogInApiBroker>(content);

            return dtoObject;
        }
    }
}
