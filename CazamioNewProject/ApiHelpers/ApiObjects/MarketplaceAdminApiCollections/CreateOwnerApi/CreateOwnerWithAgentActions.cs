using CazamioNewProject.Objects;
using RestSharp;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    //None
    //OwnerPays +
    //TenantPays
    //OwnerAndTenantPays
    //With required data +
    public partial class OwnerCreation
    {
        public static RequestCreateOwnerRequiredData RequestBodyAgentRequiredData()
        {
            Owner owner = Owner.Generate();
            Agent agent = new Agent().Generate();

            var payload = new RequestCreateOwnerRequiredData();
            payload.CompanyName = owner.CompanyName.AssignedAgentMaxSymbols;
            payload.OwnerEmail = owner.OwnerEmail.putsbox;
            payload.OwnerName = owner.OwnerName.FirstLastNameRandom;
            payload.PhoneNumbers = new PhoneNumberModel[0];
            payload.Managements = new Management[0];
            payload.CommissionStructures = new CommissionStructureOwnerPays[]
            {
            new CommissionStructureOwnerPays { Id = 0, /*PayType = owner.CommissionStructure.OwnerPaysComissionIdApi*/, OwnerNumberOfMonths = owner.CommissionStructure.OwnerNumberOfMonthsApi, /*TakeOff = owner.TakeOffApi*/ },
            };
            payload.BrokerId = agent.AgentIdApi;
            payload.IsAgent = ApiRequestData.TRUE;

            return payload;
        }

        public static void CreateOwnerWithAgentRequiredData(string token, RequestCreateOwnerRequiredData ownerBody)
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
