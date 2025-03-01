using Newtonsoft.Json;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    public partial class RequestCreateOwnerOwnerAndTenantPaysBr
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
        public PhoneNumbers[] PhoneNumbers { get; set; }

        [JsonProperty("managements")]
        public Management[] Managements { get; set; }

        [JsonProperty("commissionStructures")]
        public CommissionStructure[] CommissionStructures { get; set; }

        [JsonProperty("assignedUserId")]
        public Guid AssignedUserId { get; set; }
    }

    public partial class CommissionStructure
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("payType")]
        public string PayType { get; set; }

        [JsonProperty("ownerNumberOfMonths")]
        public long OwnerNumberOfMonths { get; set; }

        [JsonProperty("tenantNumberOfMonths")]
        public long TenantNumberOfMonths { get; set; }

        [JsonProperty("ownerPercentage")]
        public long OwnerPercentage { get; set; }

        [JsonProperty("tenantPercentage")]
        public long TenantPercentage { get; set; }

        [JsonProperty("takeOff")]
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

    public partial class PhoneNumbers
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber{ get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}
