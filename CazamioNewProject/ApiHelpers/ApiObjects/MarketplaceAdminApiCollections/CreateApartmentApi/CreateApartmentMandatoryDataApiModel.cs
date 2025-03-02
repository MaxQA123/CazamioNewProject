using Newtonsoft.Json;
using System;

namespace CazamioNewProject.CreateApartmentMandatoryDataApi
{
    public partial class RequestCreateApartmentMandatoryData
    {
        [JsonProperty("apartments")]
        public Apartment[] Apartments { get; set; }

        [JsonProperty("buildingId")]
        public long BuildingId { get; set; }
    }

    public partial class Apartment
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("leasePrice")]
        public long LeasePrice { get; set; }

        [JsonProperty("paidMonths")]
        public long PaidMonths { get; set; }

        [JsonProperty("depositPrice")]
        public long DepositPrice { get; set; }

        [JsonProperty("brokerFeeRequired")]
        public bool BrokerFeeRequired { get; set; }

        [JsonProperty("bedroomQuantity")]
        public long BedroomQuantity { get; set; }

        [JsonProperty("bathroomQuantity")]
        public long BathroomQuantity { get; set; }

        [JsonProperty("squareFeet")]
        public long SquareFeet { get; set; }

        [JsonProperty("priceDateFrom")]
        public string PriceDateFrom { get; set; } // Изменено на string

        [JsonProperty("priceDateTo")]
        public string PriceDateTo { get; set; } // Изменено на string

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }

        [JsonProperty("availableFrom")]
        public string AvailableFrom { get; set; } // Изменено на string

        [JsonProperty("apartmentType")]
        public string ApartmentType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("staffId")]
        public object StaffId { get; set; }

        [JsonProperty("leaseDurations")]
        public string LeaseDurations { get; set; }

        [JsonProperty("amenities")]
        public object[] Amenities { get; set; }

        [JsonProperty("includedInMonthlyRentAmenities")]
        public object[] IncludedInMonthlyRentAmenities { get; set; }

        [JsonProperty("images")]
        public object[] Images { get; set; }

        [JsonProperty("threeDPhotos")]
        public object[] ThreeDPhotos { get; set; }

        [JsonProperty("videos")]
        public object[] Videos { get; set; }

        [JsonProperty("visitingHours")]
        public VisitingHour[] VisitingHours { get; set; }

        [JsonProperty("requiredDocumentsIds")]
        public long[] RequiredDocumentsIds { get; set; }

        [JsonProperty("floor")]
        public object Floor { get; set; }

        [JsonProperty("freeStuff")]
        public object[] FreeStuff { get; set; }

        [JsonProperty("concessions")]
        public object[] Concessions { get; set; }

        [JsonProperty("holdingDeposit")]
        public HoldingDeposit HoldingDeposit { get; set; }

        [JsonProperty("selfTourStatus")]
        public bool SelfTourStatus { get; set; }

        [JsonProperty("locks")]
        public Locks Locks { get; set; }
    }

    public partial class HoldingDeposit
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

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

        [JsonProperty("existingOccupantLocks")]
        public object[] ExistingOccupantLocks { get; set; }
    }

    public partial class VisitingHour
    {
        [JsonProperty("dayOfWeek")]
        public string DayOfWeek { get; set; }

        [JsonProperty("openTime")]
        public object OpenTime { get; set; }

        [JsonProperty("closeTime")]
        public object CloseTime { get; set; }
    }
}
