using Newtonsoft.Json;
using System;

namespace CazamioNewProject.CreateApplicationApi
{
    public partial class RequestCreateAppWithBasicData
    {
        [JsonProperty("apartmentId")]
        public long ApartmentId { get; set; }

        [JsonProperty("leasePrice")]
        public long LeasePrice { get; set; }

        [JsonProperty("referralDetails")]
        public string ReferralDetails { get; set; }

        [JsonProperty("moveInDate")]
        public string MoveInDate { get; set; }

        [JsonProperty("offerPrice")]
        public long OfferPrice { get; set; }

        [JsonProperty("rentPrePayment")]
        public long RentPrePayment { get; set; }

        [JsonProperty("rentalTerms")]
        public string RentalTerms { get; set; }

        [JsonProperty("requestedWork")]
        public object RequestedWork { get; set; }

        [JsonProperty("securityDeposit")]
        public long SecurityDeposit { get; set; }

        [JsonProperty("tenantEmail")]
        public string TenantEmail { get; set; }

        [JsonProperty("generatedLinkId")]
        public Guid GeneratedLinkId { get; set; }
    }
}
