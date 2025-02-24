﻿using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin
{
    public partial class LogInApiMarketplaceAdmin
    {
        public static RequestLogInApiMarketplaceAdmin RequestBody()
        {
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var payload = new RequestLogInApiMarketplaceAdmin();
            payload.Email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            payload.Password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            payload.DeviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;
            payload.RememberMe = ApiRequestData.TRUE;

            return payload;
        }

        public static ResponseLogInApiMarketplaceAdmin ExecuteLogIn()
        {
            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("/api/identity/loginLandlord", Method.Post);
            restRequest.AddHeaders(Headers.HeadersForLogIn());

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

            var dtoObject = JsonConvert.DeserializeObject<ResponseLogInApiMarketplaceAdmin>(response.Content);

            return dtoObject;
        }
    }
}
