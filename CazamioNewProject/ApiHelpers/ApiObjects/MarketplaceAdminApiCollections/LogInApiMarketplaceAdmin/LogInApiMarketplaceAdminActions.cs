using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin
{
    public partial class LogInApiMarketplaceAdmin
    {
        public static RequestLogInApiMarketplaceAdmin RequestBody(string email, string password, string deviceFingerprint, bool rememberMe)
        {
            var payload = new RequestLogInApiMarketplaceAdmin();
            payload.Email = email;
            payload.Password = password;
            payload.DeviceFingerprint = deviceFingerprint;
            payload.RememberMe = rememberMe;

            return payload;
        }

        public static ResponseLogInApiMarketplaceAdmin ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
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

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogInApiMarketplaceAdmin>(content);

            return dtoObject;
        }
    }
}
