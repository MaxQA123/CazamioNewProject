using System;

namespace CazamioNewProject.DbHelpers.Marketplaces
{
    public class MarketplacesDbModels
    {
        public object? Id { get; set; } // this might be another data type
        public object? Subdomain { get; set; }
        public object? CreationDate { get; set; }
        public object? ModifyDate { get; set; }
        public object? IsDeleted { get; set; }
        public object? FacebookUrl { get; set; }
        public object? TwitterUrl { get; set; }
        public object? YoutubeUrl { get; set; }
        public object? LinkedinUrl { get; set; }
        public object? InstagramUrl { get; set; }
        public object? TermsAndConditionsUrl { get; set; }
        public object? PrivacyPolicyUrl { get; set; }
        public object? ExternalDomain { get; set; }
        public object? Brand { get; set; }
        public object? Logo { get; set; }
        public object? ApplicationValidationSettings { get; set; }
        public object? DefaultHoldingDeposit { get; set; }
        public object? DefaultPaymentKeyId { get; set; }
        public object? CreditScreeningProvider { get; set; }
        public object? FullName { get; set; }
        public object? OwnerName { get; set; }
        public object? PhoneNumber { get; set; }
        public object? Address { get; set; }
        public object? ZelleAddress { get; set; }
        public object? VenmoQRCode { get; set; }
        public object? DeliverCheckNote { get; set; }
    }
}
