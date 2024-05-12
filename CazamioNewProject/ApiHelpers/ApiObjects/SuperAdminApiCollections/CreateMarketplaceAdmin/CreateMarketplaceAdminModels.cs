using Newtonsoft.Json;

namespace CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin
{
    public partial class RequestCreateMarketplaceAdmin
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("subDomain")]
        public string SubDomain { get; set; }
    }
}
