using Newtonsoft.Json;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateOwnerApi
{
    public partial class RequestCreateOwnerRequiredFieldsPhone
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
        public PhoneNumberModel[] PhoneNumbers { get; set; }

        [JsonProperty("managements")]
        public object[] Managements { get; set; }

        [JsonProperty("commissionStructures")]
        public CommissionStructure[] CommissionStructures { get; set; }
    }

    public partial class CommissionStructure
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("ownerNumberOfMonths")]
        public object OwnerNumberOfMonths { get; set; }

        [JsonProperty("tenantNumberOfMonths")]
        public long TenantNumberOfMonths { get; set; }

        [JsonProperty("ownerPercentage")]
        public object OwnerPercentage { get; set; }

        [JsonProperty("tenantPercentage")]
        public object TenantPercentage { get; set; }

        [JsonProperty("takeOff")]
        public long TakeOff { get; set; }
    }

    public partial class PhoneNumberModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("extension")]
        public long Extension { get; set; }
    }
}
