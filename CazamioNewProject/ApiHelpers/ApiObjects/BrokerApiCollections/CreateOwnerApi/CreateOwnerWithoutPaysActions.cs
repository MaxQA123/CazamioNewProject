using CazamioNewProject.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateOwnerApi
{
    //None
    //OwnerPays
    //TenantPays
    //OwnerAndTenantPays +
    //With full data +
    public partial class OwnerCreation
    {
        public static RequestCreateOwnerRequiredFieldsManagements RequestBodyRequiredFieldsManagements()
        {
            Owner owner = new Owner().Generate();

            var payload = new RequestCreateOwnerRequiredFieldsManagements();
            payload.CompanyName = owner.CompanyName;
            payload.OwnerEmail = owner.EmailAddress;
            payload.OwnerName = owner.FullName;
            payload.PhoneNumbers = new PhoneNumberModel[0];
            payload.Managements = new Management[]
            {
            new Management { Id = 0, Name = owner.FullName, Email = owner.EmailAddress, OfficeLocation = owner.OfficeLocation, PhoneNumber = owner.PhoneNumberApi, Extension = owner.ExtensionNumber },
            };
            payload.CommissionStructures = new CommissionStructure[0];

            return payload;
        }

        public static void CreateOwnerRequiredFieldsManagements(string token, RequestCreateOwnerRequiredFieldsManagements ownerBody)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(ownerBody);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
        }
    }
}
