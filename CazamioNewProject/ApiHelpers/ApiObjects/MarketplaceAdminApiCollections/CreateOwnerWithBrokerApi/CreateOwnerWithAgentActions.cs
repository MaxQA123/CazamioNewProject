using CazamioNewProject.Objects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerWithBrokerApi
{
    //None
    //OwnerPays +
    //TenantPays
    //OwnerAndTenantPays
    //With full data +
    public partial class OwnerCreation
    {
        public static RequestCreateOwnerWithBroker RequestBodyAgentRequiredData()
        {
            Owner owner = new Owner().Generate();
            Agent agent = new Agent().Generate();

            var payload = new RequestCreateOwnerWithBroker();
            payload.CompanyName = owner.AlreadyCreatedCompanyNameWithBroker;
            payload.OwnerEmail = owner.EmailAddress;
            payload.OwnerName = owner.FullName;
            payload.PhoneNumbers = new PhoneNumberModel[]
            {
            new PhoneNumberModel { Id = 0, PhoneNumber = owner.PhoneNumber, Extension = owner.ExtensionNumber },
            };
            payload.Managements = new Management[]
            {
            new Management { Id = 0, Name = owner.FullName, Email = owner.EmailAddress, OfficeLocation = owner.OfficeLocation, PhoneNumber = owner.PhoneNumber, Extension = owner.ExtensionNumber },
            };
            payload.CommissionStructures = new CommissionStructure[]
            {
            new CommissionStructure { Id = 0, PayType = owner.TypesCommissionStructure.OwnerPays, OwnerNumberOfMonths = owner.OwnerNumberOfMonthsApi, OwnerPercentage = owner.OwnerPercentageApi, TakeOff = owner.TakeOffApi },
            };
            payload.BrokerId = agent.AgentIdApi;
            payload.IsAgent = ApiRequestData.TRUE;

            return payload;
        }

        public static void CreateOwnerWithAgentRequiredData(string token)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(RequestBodyAgentRequiredData());

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
        }
    }
}
