using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerWithBrokerApi
{
    public partial class OwnerWithBrokerCreation
    {
        public static RequestCreateOwnerWithBroker RequestBody()
        {
            Owner owner = new Owner().Generate();

            var payload = new RequestCreateOwnerWithBroker();
            payload.CompanyName = owner.CompanyName;
            payload.OwnerEmail = owner.EmailAddress;
            payload.OwnerName = owner.FullName;
            payload.OfficeLocation = owner.OfficeLocation;
            payload.Note = owner.InternalNotes;
            payload.PhoneNumbers = new PhoneNumber[]
            {
            new PhoneNumber { Id = 0, PhoneNumberPhoneNumber = "1234567890", Extension = "123" },
            new PhoneNumber { Id = 0, PhoneNumberPhoneNumber = "1234567890", Extension = "456" }
            };
            payload.Managements = new Management[]
            {
            new Management { Id = 0, Name = "John Doe", Email = "john@example.com", OfficeLocation = "Location 1", PhoneNumber = "123456789", Extension = "123" },
            new Management { Id = 0, Name = "Jane Smith", Email = "jane@example.com", OfficeLocation = "Location 2", PhoneNumber = "987654321", Extension = "456" }
            };
            payload.CommissionStructures = new CommissionStructure[]
            {
            new CommissionStructure { Id = 0, PayType = "Type 1", OwnerNumberOfMonths = 12, TenantNumberOfMonths = 6, OwnerPercentage = 50, TenantPercentage = 50, TakeOff = 100 },
            new CommissionStructure { Id = 0, PayType = "Type 2", OwnerNumberOfMonths = 6, TenantNumberOfMonths = 3, OwnerPercentage = 60, TenantPercentage = 40, TakeOff = 50 }
            };
            payload.BrokerId = 103;
            payload.IsAgent = false;

            return payload;
        }

        public static void CreateOwnerWithBrokerFullData(string token)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            // Используйте созданные данные в методе RequestBody
            restRequest.AddJsonBody(RequestBody());

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
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
