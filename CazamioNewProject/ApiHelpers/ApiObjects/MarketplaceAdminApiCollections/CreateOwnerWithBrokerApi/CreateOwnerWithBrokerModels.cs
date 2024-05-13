using Newtonsoft.Json;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerWithBrokerApi
{
    public partial class RequestCreateOwnerWithBroker
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("ownerEmail")]
        public string OwnerEmail { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("phoneNumbers")]
        public PhoneNumber[] PhoneNumbers { get; set; }

        [JsonProperty("managements")]
        public Management[] Managements { get; set; }

        [JsonProperty("commissionStructures")]
        public CommissionStructure[] CommissionStructures { get; set; }

        [JsonProperty("brokerId")]
        public long BrokerId { get; set; }

        [JsonProperty("isAgent")]
        public bool IsAgent { get; set; }
    }

    public partial class CommissionStructure
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("ownerNumberOfMonths")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long OwnerNumberOfMonths { get; set; }

        [JsonProperty("tenantNumberOfMonths")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long TenantNumberOfMonths { get; set; }

        [JsonProperty("ownerPercentage")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long OwnerPercentage { get; set; }

        [JsonProperty("tenantPercentage")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long TenantPercentage { get; set; }

        [JsonProperty("takeOff")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long TakeOff { get; set; }
    }

    public partial class Management
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public partial class PhoneNumber
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("phoneNumber")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long PhoneNumberPhoneNumber { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}
