using CazamioNewProject.Objects;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    public partial class OwnerCreation
    {
        public static RequestCreateOwnerOwnerAndTenantPaysBr RequestBodyCreateOwnerOwnerAndTenantPaysBr()
        {
            Owner owner = Owner.Generate();
            Broker broker = Broker.Generate();

            var payload = new RequestCreateOwnerOwnerAndTenantPaysBr
            {
                CompanyName = owner.CompanyName.AssignedBrokerMaxSymbols,
                OwnerEmail = owner.OwnerEmail.xitroo,
                OwnerName = owner.OwnerName.FirstNameRandom,
                OfficeLocation = owner.OfficeLocation.NewYork,
                Note = owner.InternalNotes.Long,
                PhoneNumbers = new PhoneNumbers[]
                {
            new PhoneNumbers
            {
                Id = owner.PhoneNumber.FirstBoxApi,
                PhoneNumber = owner.PhoneNumber.BasicFirst,
                Extension = owner.PhoneNumber.ExtensionFirst
            }
                },
                Managements = new Management[]
                {
            new Management
            {
                Id = 0,
                Name = owner.OwnerName.FirstLastNameRandom, 
                Email = owner.OwnerEmail.gmail, 
                OfficeLocation = owner.OfficeLocation.Dallas, 
                PhoneNumber = owner.PhoneNumber.BasicFirst, 
                Extension = owner.PhoneNumber.ExtensionFirst 
            }
                },
                CommissionStructures = new CommissionStructure[]
                {
            new CommissionStructure
            {
                Id = owner.CommissionStructure.IdOwnerAndTenantPaysComissionIdApi, 
                PayType = owner.CommissionStructure.OwnerAndTenantPaysName,
                OwnerNumberOfMonths = owner.CommissionStructure.OwnerNumberOfMonthsApi, 
                TenantNumberOfMonths = owner.CommissionStructure.TenantNumberOfMonthsApi, 
                OwnerPercentage = owner.CommissionStructure.OwnerPercentageApi, 
                TenantPercentage = owner.CommissionStructure.TenantPercentageApi, 
                TakeOff = owner.CommissionStructure.TakeOffStaticApi 
            }
                },
                AssignedUserId = Guid.Parse(broker.CreatedBrokerMySpace.AssignedUserId)
            };

            return payload;
        }

        public static RestResponse CreateOwnerOwnerAndTenantPaysBr(string token, RequestCreateOwnerOwnerAndTenantPaysBr ownerBody)
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
