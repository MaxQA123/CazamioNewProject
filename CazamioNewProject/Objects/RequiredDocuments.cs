
namespace CazamioNewProject.Objects
{
    public class RequiredDocuments
    {
        public string TwoRecentPaystubs { get; set; }
        public string SocialSecurityCard { get; set; }
        public string EmploymentVerificationLetter { get; set; }
        public string WTwoFromPreviousYear { get; set; }
        public string OtherPertinentDocuments { get; set; }
        public string GovIssuedId { get; set; }
        public string SecondaryPhotoId { get; set; }
        public string StudentVerification { get; set; }
        public string MostRecentBankStatement { get; set; }
        public string TwoMostRecentBankStatements { get; set; }
        public string LandlordReference { get; set; }
        public string ProofOfLastThreeRentPayments { get; set; }
        public string ProofOfLastTwelveRentPayments { get; set; }
        public string MostRecentWTwoOrOneThousandNine { get; set; }
        public string MostRecentCheckingAccountStatement { get; set; }
        public string MostRecentSavingsAccountStatement { get; set; }
        public string CpaLetterSelfEmployed { get; set; }
        public string PaidInvoicesSelfEmployed { get; set; }
        public string ProofOfCreditOrCollectionDisputeIfApplicable { get; set; }
        public string AnyAdditionalFinancialAssets { get; set; }
        public string ThreeMostRecentRentPayments { get; set; }
        public string MostRecentTaxReturn { get; set; }
        public string ThreeRecentPaystubs { get; set; }
        public string SixMostRecentRentPayments { get; set; }

        public RequiredDocuments Generate()
        {
            string itemTwoRecentPaystubs = "2 Recent paystubs";
            string itemSocialSecurityCard = "Social Security Card";
            string itemEmploymentVerificationLetter = "Employment Verification Letter";
            string itemWTwoFromPreviousYear = "W-2 From previous year";
            string itemOtherPertinentDocuments = "Other pertinent documents";
            string itemGovIssuedId = "Gov issued ID";
            string itemSecondaryPhotoId = "Secondary photo ID";
            string itemStudentVerification = "Student verification";
            string itemMostRecentBankStatement = "Most recent bank statement";
            string itemTwoMostRecentBankStatements = "2 Most recent bank statements";
            string itemLandlordReference = "Landlord Reference";
            string itemProofOfLastThreeRentPayments = "Proof of last 3 rent payments";
            string itemProofOfLastTwelveRentPayments = "Proof of last 12 rent payments";
            string itemMostRecentWTwoOrOneThousandNine = "Most recent W-2 or 1099";
            string itemMostRecentCheckingAccountStatement = "Most Recent checking account statement";
            string itemMostRecentSavingsAccountStatement = "Most Recent savings account statement";
            string itemCpaLetterSelfEmployed = "CPA letter (self-employed)";
            string itemPaidInvoicesSelfEmployed = "Paid invoices (self-employed)";
            string itemProofOfCreditOrCollectionDisputeIfApplicable = "Proof of credit or collection dispute (If Applicable)";
            string itemAnyAdditionalFinancialAssets = "Any additional financial assets";
            string itemThreeMostRecentRentPayments = "3 most recent rent payments";
            string itemMostRecentTaxReturn = "Most recent tax return";
            string itemThreeRecentPaystubs = "3 recent paystubs";
            string itemSixMostRecentRentPayments = "6 most recent rent payments";

            var requiredDocuments = new RequiredDocuments()
            {
                TwoRecentPaystubs = itemTwoRecentPaystubs,
                SocialSecurityCard = itemSocialSecurityCard,
                EmploymentVerificationLetter = itemEmploymentVerificationLetter,
                WTwoFromPreviousYear = itemWTwoFromPreviousYear,
                OtherPertinentDocuments = itemOtherPertinentDocuments,
                GovIssuedId = itemGovIssuedId,
                SecondaryPhotoId = itemSecondaryPhotoId,
                StudentVerification = itemStudentVerification,
                MostRecentBankStatement = itemMostRecentBankStatement,
                TwoMostRecentBankStatements = itemTwoMostRecentBankStatements,
                LandlordReference = itemLandlordReference,
                ProofOfLastThreeRentPayments = itemProofOfLastThreeRentPayments,
                ProofOfLastTwelveRentPayments = itemProofOfLastTwelveRentPayments,
                MostRecentWTwoOrOneThousandNine = itemMostRecentWTwoOrOneThousandNine,
                MostRecentCheckingAccountStatement = itemMostRecentCheckingAccountStatement,
                MostRecentSavingsAccountStatement = itemMostRecentSavingsAccountStatement,
                CpaLetterSelfEmployed = itemCpaLetterSelfEmployed,
                PaidInvoicesSelfEmployed = itemPaidInvoicesSelfEmployed,
                ProofOfCreditOrCollectionDisputeIfApplicable = itemProofOfCreditOrCollectionDisputeIfApplicable,
                AnyAdditionalFinancialAssets = itemAnyAdditionalFinancialAssets,
                ThreeMostRecentRentPayments = itemThreeMostRecentRentPayments,
                MostRecentTaxReturn = itemMostRecentTaxReturn,
                ThreeRecentPaystubs = itemThreeRecentPaystubs,
                SixMostRecentRentPayments = itemSixMostRecentRentPayments
            };
            return requiredDocuments;
        }
    }
}
