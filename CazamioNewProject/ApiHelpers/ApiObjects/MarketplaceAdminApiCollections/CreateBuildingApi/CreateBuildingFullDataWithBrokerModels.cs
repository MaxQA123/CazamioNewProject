using Newtonsoft.Json;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi
{
    public partial class RequestCreateBuildingFullDataWithBroker
    {
        [JsonProperty("locks")]
        public Locks Locks { get; set; }

        [JsonProperty("screeningFee")]
        public ScreeningFee ScreeningFee { get; set; }//

        [JsonProperty("amenities")]
        public Amenity[] Amenities { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("apiKey")]
        public ApiKey ApiKey { get; set; }//

        [JsonProperty("freeStuff")]
        public Concession[] FreeStuff { get; set; }

        [JsonProperty("concessions")]
        public Concession[] Concessions { get; set; }

        [JsonProperty("petPolicies")]
        public string[] PetPolicies { get; set; }//

        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }

        [JsonProperty("buildingId")]
        public long BuildingId { get; set; }

        [JsonProperty("llcName")]
        public string LlcName { get; set; }//

        [JsonProperty("description")]
        public string Description { get; set; }//

        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }//

        [JsonProperty("buildingName")]
        public string BuildingName { get; set; }//

        [JsonProperty("address")]
        public Address Address { get; set; }//

        [JsonProperty("holdDeposit")]
        public HoldDeposit HoldDeposit { get; set; }//
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

    public partial class Amenity
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amenityType")]
        public string AmenityType { get; set; }
    }

    public partial class ApiKey
    {
        [JsonProperty("id")]
        public long Id { get; set; }//

        [JsonProperty("isACHInclude")]
        public bool IsAchInclude { get; set; }//

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }//

        [JsonProperty("key")]
        public string Key { get; set; }//

        [JsonProperty("authorizeNetApiLoginId")]
        public object AuthorizeNetApiLoginId { get; set; }//

        [JsonProperty("paymentSystem")]
        public long PaymentSystem { get; set; }//
    }

    public partial class Concession
    {
        [JsonProperty("specialOfferId")]
        public long SpecialOfferId { get; set; }

        [JsonProperty("monthsFree", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonthsFree { get; set; }

        [JsonProperty("leaseTerms", NullValueHandling = NullValueHandling.Ignore)]
        public string LeaseTerms { get; set; }

        [JsonProperty("isTimeBased")]
        public bool IsTimeBased { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("dateFrom")]
        public DateTimeOffset DateFrom { get; set; }

        [JsonProperty("dateTo")]
        public DateTimeOffset DateTo { get; set; }

        [JsonProperty("triggerEvent")]
        public long TriggerEvent { get; set; }

        [JsonProperty("generatedId")]
        public Guid GeneratedId { get; set; }

        [JsonProperty("freeStuff", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeStuff { get; set; }
    }

    public partial class ScreeningFee
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }//

        [JsonProperty("deliverCheckNote")]
        public string DeliverCheckNote { get; set; }//

        [JsonProperty("venmoQRCode")]
        public string VenmoQrCode { get; set; }//

        [JsonProperty("zelleAddress")]
        public string ZelleAddress { get; set; }//

        [JsonProperty("allowedPaymentMethods")]
        public string[] AllowedPaymentMethods { get; set; }//
    }

    public partial class HoldDeposit
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }//

        [JsonProperty("deliverCheckNote")]
        public string DeliverCheckNote { get; set; }//

        [JsonProperty("venmoQRCode")]
        public string VenmoQrCode { get; set; }//

        [JsonProperty("zelleAddress")]
        public string ZelleAddress { get; set; }//

        [JsonProperty("allowedPaymentMethods")]
        public string[] AllowedPaymentMethods { get; set; }//
    }

    public partial class Image
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("blobUrl")]
        public Uri BlobUrl { get; set; }
    }

    public partial class Locks
    {
        [JsonProperty("bluetoothLocks")]
        public object[] BluetoothLocks { get; set; }

        [JsonProperty("wifiLocks")]
        public object[] WifiLocks { get; set; }

        [JsonProperty("pinCodeLocks")]
        public ELock[] PinCodeLocks { get; set; }

        [JsonProperty("noteLocks")]
        public ELock[] NoteLocks { get; set; }

        [JsonProperty("CABLocks")]
        public object[] CabLocks { get; set; }

        [JsonProperty("brokerId")]
        public long BrokerId { get; set; }

        [JsonProperty("isAgent")]
        public bool IsAgent { get; set; }
    }

    public partial class ELock
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("timeRestrictionEnabled")]
        public bool TimeRestrictionEnabled { get; set; }

        [JsonProperty("customNote")]
        public string CustomNote { get; set; }

        [JsonProperty("noteImage")]
        public Uri NoteImage { get; set; }

        [JsonProperty("showOrder")]
        public long ShowOrder { get; set; }

        [JsonProperty("connectionType")]
        public string ConnectionType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pinCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PinCode { get; set; }
    }
}
