using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin
{
    public partial class CreateMarketplaceAdmin
    {
        public static RequestCreateMarketplaceAdmin RequestBody(string firstName, string lastName, string email, string password, string subDomain)
        {
            var payload = new RequestCreateMarketplaceAdmin();
            payload.FirstName = firstName;
            payload.LastName = lastName;
            payload.Email = email;
            payload.Password = password;
            payload.SubDomain = subDomain;

            return payload;
        }

        //public static ResponseLogInSuperAdmin ExecuteLogIn(string email, string password, string deviceFingerprint, bool rememberMe)
        //{
        //    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

        //    var restRequest = new RestRequest("/api/identity/loginLandlord", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersAdmins());

        //    restRequest.AddJsonBody(RequestBody(email, password, deviceFingerprint, rememberMe));

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusDescription == "Bad Request")
        //    {
        //        Console.WriteLine(response.Content);
        //    }

        //    var dtoObject = JsonConvert.DeserializeObject<ResponseLogInSuperAdmin>(content);

        //    return dtoObject;
        //}
    }
}
