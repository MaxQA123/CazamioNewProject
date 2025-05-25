using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net.Http;
using System.Text;

namespace CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.LogInApiSuperAdmin
{
    public partial class LogInApiSuperAdmin
    {
        public static RequestLogInSuperAdmin RequestBodyLogInSuperAdmin()
        {

            SuperAdmin superAdmin = SuperAdmin.Generate();
            BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

            var payload = new RequestLogInSuperAdmin();
            payload.Email = superAdmin.EmailAddressStatic.General;
            payload.Password = basicDataForProject.Passwords.BasicStaticFirst;
            payload.DeviceFingerprint = superAdmin.ApiData.DeviceFingerprint;
            payload.RememberMe = superAdmin.ApiData.True;

            return payload;
        }

        public static RestResponse<ResponseLogInSuperAdmin> LogInSuperAdmin(RequestLogInSuperAdmin logInSuperAdminRequestBody)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/loginLandlord", Method.Post);
            restRequest.AddHeaders(Headers.HeadersForLogIn());
            restRequest.AddJsonBody(logInSuperAdminRequestBody);

            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(logInSuperAdminRequestBody, Formatting.Indented));

            var response = restClient.Execute<ResponseLogInSuperAdmin>(restRequest);

            Console.WriteLine("Response Status Code: " + response.StatusCode);
            Console.WriteLine("Response Content: " + response.Content);

            if (!response.IsSuccessful)
            {
                var errorMessage = new StringBuilder();
                errorMessage.AppendLine($"Request failed with status code: {response.StatusCode}");

                if (response.ErrorException != null)
                {
                    errorMessage.AppendLine($"Exception: {response.ErrorException.Message}");
                    errorMessage.AppendLine($"Stack Trace: {response.ErrorException.StackTrace}");
                }

                if (!string.IsNullOrEmpty(response.ErrorMessage))
                {
                    errorMessage.AppendLine($"Error Message: {response.ErrorMessage}");
                }

                if (!string.IsNullOrEmpty(response.Content))
                {
                    try
                    {
                        var errorResponse = JsonConvert.DeserializeObject<dynamic>(response.Content);
                        errorMessage.AppendLine($"Server Error: {errorResponse}");
                    }
                    catch
                    {
                        errorMessage.AppendLine($"Raw Error Content: {response.Content}");
                    }
                }

                throw new HttpRequestException(errorMessage.ToString(), response.ErrorException);
            }

            return response;
        }
    }
}

//public static ResponseLogInSuperAdmin ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
//{
//    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

//    var restRequest = new RestRequest("/api/identity/loginLandlord", Method.Post);
//    restRequest.AddHeaders(Headers.HeadersForLogIn());

//    restRequest.AddJsonBody(RequestBody(email, password, deviceFingerprint, rememberMe));

//    var response = restClient.Execute(restRequest);

//    var content = response.Content;

//    if (response.StatusCode != System.Net.HttpStatusCode.OK)
//    {
//        throw new Exception(response.Content);
//    }

//    var dtoObject = JsonConvert.DeserializeObject<ResponseLogInSuperAdmin>(content);

//    return dtoObject;
//}
