using Newtonsoft.Json;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateAgentApi
{
    public partial class RequestCreateAgent
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("brokerCommission")]
        public long BrokerCommission { get; set; }

        [JsonProperty("agentCommission")]
        public long AgentCommission { get; set; }

        [JsonProperty("cell")]
        public string Cell { get; set; }
    }
}
