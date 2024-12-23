using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi;
using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateOwnerApi
{
    //None
    //OwnerPays
    //TenantPays +
    //OwnerAndTenantPays
    //With required data and phone numbers +
    public partial class OwnerCreation
    {
        //public static RequestCreateOwnerRequiredFieldsPhone RequestCreateOwnerWithTenantPays()
        //{
        //    Owner owner = Owner.Generate();

        //    var payload = new RequestCreateOwnerRequiredFieldsPhone();
        //    payload.CompanyName = owner.CompanyName;
        //    payload.OwnerEmail = owner.EmailAddress;
        //    payload.OwnerName = owner.FullName;
        //    payload.PhoneNumbers = new PhoneNumberModel[]
        //    {
        //    new PhoneNumberModel { Id = 0, PhoneNumber = owner.PhoneNumber, Extension = owner.ExtensionNumberApi },
        //    };
        //    payload.Managements = new Management[0];
        //    payload.CommissionStructures = new CommissionStructure[]
        //    {
        //    new CommissionStructure { Id = 0, PayType = owner.TypesCommissionStructure.TenantPays, TenantNumberOfMonths = owner.TenantNumberOfMonthsApi, TakeOff = owner.TakeOffApi },
        //    };

        //    return payload;
        //}

        //public static void CreateOwnerWithTenantPays(string token, RequestCreateOwnerRequiredFieldsPhone ownerBody)
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
