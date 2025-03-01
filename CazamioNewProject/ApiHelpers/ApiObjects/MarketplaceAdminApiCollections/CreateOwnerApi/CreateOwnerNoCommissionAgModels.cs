using Newtonsoft.Json;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi
{
    public partial class RequestCreateOwnerNoCommissionAg
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
        public object[] CommissionStructures { get; set; }

        [JsonProperty("assignedUserId")]
        public Guid AssignedUserId { get; set; }
    }
}
