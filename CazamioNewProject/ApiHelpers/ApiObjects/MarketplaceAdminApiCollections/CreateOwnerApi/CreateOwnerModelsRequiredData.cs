using Newtonsoft.Json;


namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    public partial class RequestCreateOwnerRequiredData
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("officeLocation")]
        public object OfficeLocation { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("phoneNumbers")]
        public object[] PhoneNumbers { get; set; }

        [JsonProperty("managements")]
        public object[] Managements { get; set; }

        [JsonProperty("commissionStructures")]
        public CommissionStructureOwnerPays[] CommissionStructures { get; set; }

        [JsonProperty("brokerId")]
        public long BrokerId { get; set; }

        [JsonProperty("isAgent")]
        public bool IsAgent { get; set; }
    }

    public partial class CommissionStructureOwnerPays
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("ownerNumberOfMonths")]
        public long OwnerNumberOfMonths { get; set; }

        [JsonProperty("tenantNumberOfMonths")]
        public object TenantNumberOfMonths { get; set; }

        [JsonProperty("ownerPercentage")]
        public object OwnerPercentage { get; set; }

        [JsonProperty("tenantPercentage")]
        public object TenantPercentage { get; set; }

        [JsonProperty("takeOff")]
        public long TakeOff { get; set; }
    }
}
