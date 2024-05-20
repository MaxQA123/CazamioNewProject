using Newtonsoft.Json;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateOwnerApi
{
    public partial class RequestCreateOwnerRequiredFieldsManagements
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
        public Management[] Managements { get; set; }

        [JsonProperty("commissionStructures")]
        public object[] CommissionStructures { get; set; }
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
        public long PhoneNumber { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }
}
