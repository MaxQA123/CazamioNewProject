using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    //None
    //OwnerPays
    //TenantPays
    //OwnerAndTenantPays +
    //With full data +
    public partial class OwnerCreation
    {
        //public static RequestCreateOwnerFullData RequestBodyBrokerFullData()
        //{
        //    Owner owner = Owner.Generate();
        //    Broker broker = new Broker().Generate();

        //    var payload = new RequestCreateOwnerFullData();
        //    payload.CompanyName = owner.CompanyNameWithBroker;
        //    payload.OwnerEmail = owner.EmailAddress;
        //    payload.OwnerName = owner.FullName;
        //    payload.OfficeLocation = owner.OfficeLocation;
        //    payload.Note = owner.InternalNotes;
        //    payload.PhoneNumbers = new PhoneNumberModel[]
        //    {
        //    new PhoneNumberModel { Id = 0, PhoneNumber = owner.PhoneNumber, Extension = owner.ExtensionNumber },
        //    };
        //    payload.Managements = new Management[]
        //    {
        //    new Management { Id = 0, Name = owner.FullName, Email = owner.EmailAddress, OfficeLocation = owner.OfficeLocation, PhoneNumber = owner.PhoneNumber, Extension = owner.ExtensionNumber },
        //    };
        //    payload.CommissionStructures = new CommissionStructure[]
        //    {
        //    new CommissionStructure { Id = 0, PayType = owner.TypesCommissionStructure.OwnerAndTenantPays, OwnerNumberOfMonths = owner.OwnerNumberOfMonthsApi, TenantNumberOfMonths = owner.TenantNumberOfMonthsApi, OwnerPercentage = owner.OwnerPercentageApi, TenantPercentage = owner.TenantPercentageApi, TakeOff = owner.TakeOffApi },
        //    };
        //    payload.BrokerId = broker.BrokerIdApi;
        //    payload.IsAgent = ApiRequestData.FALSE;

        //    return payload;
        //}

        //public static void CreateOwnerWithBrokerFullData(string token, RequestCreateOwnerFullData ownerBody)
        //{

        //    var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

        //    var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
        //    restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

        //    restRequest.AddJsonBody(ownerBody);

        //    var response = restClient.Execute(restRequest);

        //    var content = response.Content;

        //    if (response.StatusCode != System.Net.HttpStatusCode.OK)
        //    {
        //        throw new Exception(response.Content);
        //    }
        //}
    }
}
