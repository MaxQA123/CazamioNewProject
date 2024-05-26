using CazamioNewProject.ApiHelpers.ApiObjects.ModlesApiObjects;
using CazamioNewProject.Objects;
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
            payload.Address.Id = buildingApi.AddressIdApi;
            payload.Address.Country = buildingApi.CountryApi;
            payload.Address.Street = buildingApi.StreetApi.MarkAdmAssignedRoleBrkr;
            payload.Address.State = buildingApi.StateApi;
            payload.Address.City = buildingApi.CityApi.NewYork;
            payload.Address.ZipCode = buildingApi.ZipCode.ZipBuildingMarkAdmAssignedRoleBrkr;
            payload.Address.Neighborhood = buildingApi.NeighborhoodApi.BuildingMarkAdmAssignedRoleBrkr;
            
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
