using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi
{
    //With full data +
    //With broker
    public partial class BuildingCreation
    {
        public static RequestCreateBuildingFullDataWithBroker RequestBodyCreateBuildingFullDataBroker()
        {
            BuildingApi buildingApi = new BuildingApi().Generate();

            var payload = new RequestCreateBuildingFullDataWithBroker();
            payload.Address = new Address
            {
                Id = buildingApi.AddressIdApi,
                Country = buildingApi.CountryApi,
                Street = buildingApi.StreetApi.MarkAdmAssignedRoleBrkr,
                State = buildingApi.StateApi,
                City = buildingApi.CityApi.NewYork,
                ZipCode = buildingApi.ZipCode.ZipBuildingMarkAdmAssignedRoleBrkr,
                Neighborhood = buildingApi.NeighborhoodApi.BuildingMarkAdmAssignedRoleBrkr
            };
            
            payload.PetPolicies = new string[]
            {
                buildingApi.PetPoliciesApi.CaseByCase,
                buildingApi.PetPoliciesApi.PetFee,
                buildingApi.PetPoliciesApi.AllPetsAllowed,
                buildingApi.PetPoliciesApi.SmallPetsAllowed,
                buildingApi.PetPoliciesApi.CatsOnly,
                buildingApi.PetPoliciesApi.NoPets
            };

            //payload.BrokerId = broker.BrokerIdApi;
            //payload.IsAgent = ApiRequestData.FALSE;

            return payload;
        }

        public static void CreateOwnerWithBrokerFullData(string token, RequestCreateBuildingFullDataWithBroker buildingBody)
        {

            var restClient = new RestClient(BaseStartPointsApi.API_HOST_WEBSITE_LANDLORD);

            var restRequest = new RestRequest("api/owners/createOwner", Method.Post);
            restRequest.AddHeaders(Headers.HeadersSuperAdmin(token));

            restRequest.AddJsonBody(buildingBody);

            var response = restClient.Execute(restRequest);

            var content = response.Content;

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.Content);
            }
        }
    }
}
