using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerWithBrokerApi
{
    public partial class OwnerWithBrokerCreation
    {
        public static RequestCreateOwnerWithBroker RequestBody(string companyName, string ownerEmail, string ownerName, string officeLocation, string note, PhoneNumber[] phoneNumbers, Management[] managements, CommissionStructure[] commissionStructures, long brokerId, bool isAgent)
        {
            var payload = new RequestCreateOwnerWithBroker();
            payload.CompanyName = companyName;
            payload.OwnerEmail = ownerEmail;
            payload.OwnerName = ownerName;
            payload.OfficeLocation = officeLocation;
            payload.Note = note;
            payload.PhoneNumbers = phoneNumbers;
            payload.Managements = managements;
            payload.CommissionStructures = commissionStructures;
            payload.BrokerId = brokerId;
            payload.IsAgent = isAgent;

            return payload;
        }

        public static void CreateOwnerWithBrokerFullData(string token)
        {
            // Создание PhoneNumber[]
            PhoneNumber[] phoneNumbers = new PhoneNumber[]
            {
            new PhoneNumber { Id = 1, PhoneNumberPhoneNumber = 1234567890, Extension = "123" },
            new PhoneNumber { Id = 2, PhoneNumberPhoneNumber = 9876543210, Extension = "456" }
            };

            // Создание Management[]
            Management[] managements = new Management[]
            {
            new Management { Id = 1, Name = "John Doe", Email = "john@example.com", OfficeLocation = "Location 1", PhoneNumber = "123456789", Extension = "123" },
            new Management { Id = 2, Name = "Jane Smith", Email = "jane@example.com", OfficeLocation = "Location 2", PhoneNumber = "987654321", Extension = "456" }
            };

            // Создание CommissionStructure[]
            CommissionStructure[] commissionStructures = new CommissionStructure[]
            {
            new CommissionStructure { Id = 1, PayType = "Type 1", OwnerNumberOfMonths = 12, TenantNumberOfMonths = 6, OwnerPercentage = 50, TenantPercentage = 50, TakeOff = 100 },
            new CommissionStructure { Id = 2, PayType = "Type 2", OwnerNumberOfMonths = 6, TenantNumberOfMonths = 3, OwnerPercentage = 60, TenantPercentage = 40, TakeOff = 50 }
            };

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            // Используйте созданные данные в методе RequestBody
            restRequest.AddJsonBody(RequestBody("Company", "owner@example.com", "Owner Name", "Office", "Note", phoneNumbers, managements, commissionStructures, 123456789, true));

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine(response.Content);
            }
        }
    }
    //public partial class OwnerWithBrokerCreation
    //{
    //    public static RequestCreateOwnerWithBroker RequestBody(string companyName, string ownerEmail, string ownerName, string officeLocation, string note, PhoneNumber[] phoneNumbers, Management[] managements, CommissionStructure[] commissionStructures, long brokerId, bool isAgent)
    //    {
    //        var payload = new RequestCreateOwnerWithBroker();
    //        payload.CompanyName = companyName;
    //        payload.OwnerEmail = ownerEmail;
    //        payload.OwnerName = ownerName;
    //        payload.OfficeLocation = officeLocation;
    //        payload.Note = note;
    //        payload.PhoneNumbers = phoneNumbers;
    //        payload.Managements = managements;
    //        payload.CommissionStructures = commissionStructures;
    //        payload.BrokerId = brokerId;
    //        payload.IsAgent = isAgent;

    //        return payload;
    //    }

    //    public static void CreateOwnerWithBrokerFullData(string token, string companyName, string ownerEmail, string ownerName, string officeLocation, string note, PhoneNumber[] phoneNumbers, Management[] managements, CommissionStructure[] commissionStructures, long brokerId, bool isAgent)
    //    {

    //        var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

    //        var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
    //        restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

    //        restRequest.AddJsonBody(RequestBody(companyName, ownerEmail, ownerName, officeLocation, note, phoneNumbers, managements, commissionStructures, brokerId, isAgent));

    //        var response = restClient.Execute(restRequest);

    //        var content = response.Content;

    //        if (response.StatusCode != System.Net.HttpStatusCode.OK)
    //        {
    //            Console.WriteLine(response.Content);
    //        }
    //    }
    //}
}
