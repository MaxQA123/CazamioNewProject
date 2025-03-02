using System;

namespace CazamioNewProject.DbHelpers.BuildingsTable
{
    public class BuildingsDbModels
    {
        public long AddressId { get; set; }
        public object? BuildingName { get; set; }
        public object? Title { get; set; }
        public object? Description { get; set; }
        public object? WalkScoreJsonCache { get; set; }
        public object? Latitude { get; set; }
        public object? Longitude { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? LandlordPaymentKeyId { get; set; }
        public object? LLCName { get; set; }
        public object? OwnerId { get; set; }
        public object? InternalNotes { get; set; }
        public object? MarketplaceId { get; set; }
        public object? PetPolicies { get; set; }
        public object? PayType { get; set; }
        public object? TenantNumberOfMonths { get; set; }
        public object? OwnerPercentage { get; set; }
        public object? TenantPercentage { get; set; }
        public object? TakeOff { get; set; }
        public object? OwnerNumberOfMonths { get; set; }
    }
}
