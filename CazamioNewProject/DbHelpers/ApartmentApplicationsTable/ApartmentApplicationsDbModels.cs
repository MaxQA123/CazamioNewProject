using System;

namespace CazamioNewProject.DbHelpers.ApartmentApplicationsTable
{
    public class ApartmentApplicationsDbModels
    {
        public long Id { get; set; }
        public object? TenantId { get; set; }
        public long ApartmentId { get; set; }
        public object? MoveInDate { get; set; }
        public object? Status { get; set; }
        public object? EnvelopeId { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? OwnerSubmitted { get; set; }
        public object? EnvelopeFields { get; set; }
        public object? ChatId { get; set; }
        public object? BrokerIdOld { get; set; }
        public object? StaffBlocked { get; set; }
        public object? ApplicationValidationSettings { get; set; }
        public object? DeclineReason { get; set; }
        public object? IsOnceApproved { get; set; }
        public object? PayType { get; set; }
        public object? TenantNumberOfMonths { get; set; }
        public object? OwnerPercentage { get; set; }
        public object? TenantPercentage { get; set; }
        public object? TakeOff { get; set; }
        public object? BrokerCommission { get; set; }
        public object? AgentCommission { get; set; }
        public object? OwnerNumberOfMonths { get; set; }
        public long IsDraftNotificationSent { get; set; }
        public object? ReferralDetails { get; set; }
        public object? CloseReason { get; set; }
        public long RentalTerm { get; set; }
        public object? RequestedRepairs { get; set; }
        public object? IsApplicationDraftComesSent { get; set; }
        public long GeneratedLinkId { get; set; }
        public object? DepositSignatureData { get; set; }
        public object? StaffId { get; set; }
        public long MergedData { get; set; }
        public object? ApprovalEmailTemplate { get; set; }
    }
}
