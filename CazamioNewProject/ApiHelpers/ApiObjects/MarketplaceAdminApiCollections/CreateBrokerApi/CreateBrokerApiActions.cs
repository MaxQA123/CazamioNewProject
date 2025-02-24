using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBrokerApi
{
    public partial class BrokerCreation
    {
        public static RequestCreateBroker RequestBody()
        {
            Broker broker = Broker.Generate();

            var payload = new RequestCreateBroker();
            payload.FirstName = broker.BrokerName.FirstNameRandom;
            payload.LastName = broker.BrokerName.LastNameRandom;
            payload.Email = broker.BrokerEmail.FullEmail;
            payload.Password = "";

            return payload;
        }

        //public static RequestCreateBroker RequestBody(string firstNameBroker, string lastNameBroker, string emailBroker, string passwordBroker)
        //{
        //    var payload = new RequestCreateBroker();
        //    payload.FirstName = firstNameBroker;
        //    payload.LastName = lastNameBroker;
        //    payload.Email = emailBroker;
        //    payload.Password = passwordBroker;

        //    return payload;
        //}

        public static void CreateBroker(string token)
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/registerLandlord", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            // Логируем тело запроса
            var requestBody = RequestBody();
            Console.WriteLine("Request Body:");
            Console.WriteLine(JsonConvert.SerializeObject(requestBody, Formatting.Indented));

            restRequest.AddJsonBody(requestBody);

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
        }

        //public static void CreateBroker(string token, string firstNameBroker, string lastNameBroker, string emailBroker, string passwordBroker)
        //{
        //    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

        //    var restRequest = new RestRequest("/api/identity/registerLandlord", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

        //    restRequest.AddJsonBody(RequestBody(firstNameBroker, lastNameBroker, emailBroker, passwordBroker));

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusCode != System.Net.HttpStatusCode.OK)
        //    {
        //        throw new Exception(response.Content);
        //    }
        //}
    }
}
