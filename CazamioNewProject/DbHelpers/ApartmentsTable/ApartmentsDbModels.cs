using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.DbHelpers.ApartmentsTable
{
    public class ApartmentsDbModels
    {
        public long Id { get; set; }
        public object? BuildingId { get; set; }
        public object? ApartmentType { get; set; }
        public object? Unit { get; set; }
        public object? BrokerFeeRequired { get; set; }
        public object? BedroomQuantity { get; set; }
        public object? SquareFeet { get; set; }
        public object? BathroomQuantity { get; set; }
        public object? Description { get; set; }
        public object? DaysListed { get; set; }
        public object? AvailableFrom { get; set; }
        public object? NumberOfViews { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? Status { get; set; }
        public object? TemplateId { get; set; }
        public object? LeaseDuration { get; set; }
        public object? ClosedDateToNotify { get; set; }
        public object? Floor { get; set; }
        public object? MarketplaceId { get; set; }
        public object? AvailableFromUtc { get; set; }
        public object? OwnerId { get; set; }
        public long BrokerIdOld { get; set; }
        public object? Tags { get; set; }
        public object? SelfTourStatus { get; set; }
        public long TotalRoomCount { get; set; }
        public object? InternalNotes { get; set; }
        public object? SquareFeetInfo { get; set; }
        public long PayType { get; set; }
        public object? TenantNumberOfMonths { get; set; }
        public object? OwnerPercentage { get; set; }
        public long TenantPercentage { get; set; }
        public object? TakeOff { get; set; }
        public object? OwnerNumberOfMonths { get; set; }
        public object? RentRegulation { get; set; }
        public object? FromExternalTable { get; set; }
        public long AddedToStreetEasy { get; set; }
        public object? AddedToStreetEasyBy { get; set; }
        public object? StaffId { get; set; }
    }
}
