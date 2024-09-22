using Newtonsoft.Json;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData
{
    public partial class RequestCreateBuildingMandatoryDataWithAgent
    {
        [JsonProperty("locks")]
        public Locks Locks { get; set; }

        [JsonProperty("screeningFee")]
        public HoldDeposit ScreeningFee { get; set; }

        [JsonProperty("amenities")]
        public object[] Amenities { get; set; }

        [JsonProperty("images")]
        public object[] Images { get; set; }

        [JsonProperty("apiKey")]
        public ApiKey ApiKey { get; set; }

        [JsonProperty("freeStuff")]
        public object[] FreeStuff { get; set; }

        [JsonProperty("concessions")]
        public object[] Concessions { get; set; }

        [JsonProperty("petPolicies")]
        public object[] PetPolicies { get; set; }

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("buildingId")]
        public long BuildingId { get; set; }

        [JsonProperty("llcName")]
        public string LlcName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }

        [JsonProperty("buildingName")]
        public string BuildingName { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("holdDeposit")]
        public HoldDeposit HoldDeposit { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public long ZipCode { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }
    }

    public partial class ApiKey
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("isACHInclude")]
        public bool IsAchInclude { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("authorizeNetApiLoginId")]
        public object AuthorizeNetApiLoginId { get; set; }

        [JsonProperty("paymentSystem")]
        public long PaymentSystem { get; set; }
    }

    public partial class HoldDeposit
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("deliverCheckNote")]
        public object DeliverCheckNote { get; set; }

        [JsonProperty("venmoQRCode")]
        public object VenmoQrCode { get; set; }

        [JsonProperty("zelleAddress")]
        public object ZelleAddress { get; set; }

        [JsonProperty("allowedPaymentMethods")]
        public string[] AllowedPaymentMethods { get; set; }
    }

    public partial class Locks
    {
        [JsonProperty("bluetoothLocks")]
        public object[] BluetoothLocks { get; set; }

        [JsonProperty("wifiLocks")]
        public object[] WifiLocks { get; set; }

        [JsonProperty("pinCodeLocks")]
        public object[] PinCodeLocks { get; set; }

        [JsonProperty("noteLocks")]
        public object[] NoteLocks { get; set; }

        [JsonProperty("CABLocks")]
        public object[] CabLocks { get; set; }
    }
}
