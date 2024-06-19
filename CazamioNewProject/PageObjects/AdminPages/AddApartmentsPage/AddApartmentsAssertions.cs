using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.AddApartmentsPage
{
    public partial class AddApartments
    {
        [AllureStep("VerifyTitleAddApartmentsPage")]
        public AddApartments VerifyTitleAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(TitleAddApartmentsPage);
            Assert.IsTrue(Successfully.IsVisible(TitleAddApartmentsPage));

            return this;
        }

        [AllureStep("VerifyBuildingNameAddApartmentsPage")]
        public AddApartments VerifyBuildingNameAddApartmentsPage(string getBuildingNameFromBuildingView, string getBuildingNameFromAddApartments)
        {
            WaitUntil.WaitSomeInterval(3000);
            Assert.AreEqual(getBuildingNameFromBuildingView, getBuildingNameFromAddApartments);
            Console.WriteLine($"{getBuildingNameFromBuildingView} = {getBuildingNameFromAddApartments}");

            return this;
        }

        [AllureStep("GetMonthlyRentsPrePayment")]
        public string GetMonthlyRentsPrePayment()
        {
            WaitUntil.CustomElementIsVisible(FieldInputMonthlyRentsPrePayment);
            string getMonthlyRentsPrePayment = FieldInputMonthlyRentsPrePayment.GetAttribute("value");
            string getMonthlyRentsPrePaymentActual = getMonthlyRentsPrePayment.ToString();

            return getMonthlyRentsPrePaymentActual;
        }

        [AllureStep("VerifyMonthlyRentsPrePayment")]
        public AddApartments VerifyMonthlyRentsPrePayment(string getMonthlyRentsPrePayment)
        {
            Assert.AreEqual(getMonthlyRentsPrePayment, apartment.MonthlyRentsPrePayment.OneNumber);

            Console.WriteLine($"MonthlyRentsPrePayment AR: {getMonthlyRentsPrePayment} = {apartment.MonthlyRentsPrePayment.OneNumber} :ER MonthlyRentsPrePayment");

            return this;
        }

        //[AllureStep("GetApartmentTypeAddApartmentsPage")]
        //public string GetApartmentTypeAddApartmentsPage()
        //{
        //    WaitUntil.CustomElementIsVisible(ItemApartmentTypeMultiFamily);
        //    string getApartmentType = ItemApartmentTypeMultiFamily.Text;
        //    string getApartmentTypeActual = getApartmentType.ToString();

        //    return getApartmentTypeActual;
        //}

        [AllureStep("VerifyApartmentTypeAddApartmentsPage")]
        public AddApartments VerifyApartmentTypeAddApartmentsPage(string getApartmentType)
        {
            Assert.AreEqual(getApartmentType, apartment.ApartmentType.MultiFamily);

            Console.WriteLine($"Apartment Type AR: {getApartmentType} = {apartment.ApartmentType.MultiFamily} :ER Apartment Type");

            return this;
        }

        [AllureStep("GetApartmentHoldDepositAddApartmentsPage")]
        public string GetApartmentHoldDepositAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            string getApartmentHoldDeposit = FieldInputApartmentHoldDeposit.GetAttribute("value");
            string getApartmentHoldDepositActual = getApartmentHoldDeposit.ToString();

            return getApartmentHoldDepositActual;
        }

        [AllureStep("VerifyApartmentHoldDepositAddApartmentsPage")]
        public AddApartments VerifyApartmentHoldDepositAddApartmentsPage(string getApartmentHoldDeposit)
        {
            Assert.AreEqual(getApartmentHoldDeposit, building.HoldDeposit.ByDefaultMySpace);

            Console.WriteLine($"Apartment Hold Deposit AR: {getApartmentHoldDeposit} = {building.HoldDeposit.ByDefaultMySpace} :ER Apartment Hold Deposit");

            return this;
        }

        [AllureStep("GetRentalTermsAddApartmentsPage")]
        public string GetRentalTermsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemTwelveMonthsRentalTerms);
            string getRentalTerms = ItemTwelveMonthsRentalTerms.Text;
            string getRentalTermsActual = getRentalTerms.ToString();

            return getRentalTermsActual;
        }

        [AllureStep("VerifyRentalTermsAddApartmentsPage")]
        public AddApartments VerifyRentalTermsAddApartmentsPage(string getRentalTerms)
        {
            Assert.AreEqual(getRentalTerms, apartment.RentalTerms.DefaultRentalTerms);

            Console.WriteLine($"Rental Terms AR: {getRentalTerms} = {apartment.RentalTerms.DefaultRentalTerms} :ER Rental Terms");

            return this;
        }

        #region RequiredDocuments

        [AllureStep("GetRequiredDocumentsThreeRecentPaystubsAddApartmentsPage")]
        public string GetRequiredDocumentsThreeRecentPaystubsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemThreeRecentPaystubs);
            string getThreeRecentPaystubs = ItemThreeRecentPaystubs.Text;
            string getThreeRecentPaystubsActual = getThreeRecentPaystubs.ToString();

            return getThreeRecentPaystubsActual;
        }

        [AllureStep("GetRequiredDocumentsPhotoIdAddApartmentsPage")]
        public string GetRequiredDocumentsPhotoIdAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemPhotoIdPaystubs);
            string getPhotoId = ItemPhotoIdPaystubs.Text;
            string getPhotoIdActual = getPhotoId.ToString();

            return getPhotoIdActual;
        }

        [AllureStep("GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage")]
        public string GetRequiredDocumentsTwoMostRecentBankStatementsAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemTwoMostRecentBankStatements);
            string getTwoMostRecentBankStatements = ItemTwoMostRecentBankStatements.Text;
            string getTwoMostRecentBankStatementsActual = getTwoMostRecentBankStatements.ToString();

            return getTwoMostRecentBankStatementsActual;
        }

        [AllureStep("GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage")]
        public string GetRequiredDocumentsMostRecentWTwoOrOneZeroNineNineAddApartmentsPage()
        {
            WaitUntil.CustomElementIsVisible(ItemrMostRecentWTwoOrOneZeroNineNine);
            string getMostRecentWTwoOrOneZeroNineNine = ItemrMostRecentWTwoOrOneZeroNineNine.Text;
            string getMostRecentWTwoOrOneZeroNineNineActual = getMostRecentWTwoOrOneZeroNineNine.ToString();

            return getMostRecentWTwoOrOneZeroNineNineActual;
        }

        [AllureStep("VerifyRequiredDocumentsByDefaultMySpace")]
        public AddApartments VerifyRequiredDocumentsByDefaultMySpace(string getTwoRecentPaystubsActual, string getEmploymentVerificationLetterActual, string getGovIssuedIdActual, string getTwoMostRecentBankStatementsActual, string getMostRecentWTwoOrOneZeroNineNineActual, string getThreeMostRecentRentPaymentsActual, string getMostRecentTaxReturnActual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getTwoRecentPaystubsActual, requiredDocuments.TwoRecentPaystubs);
                Assert.AreEqual(getEmploymentVerificationLetterActual, requiredDocuments.EmploymentVerificationLetter);
                Assert.AreEqual(getGovIssuedIdActual, requiredDocuments.GovIssuedId);
                Assert.AreEqual(getTwoMostRecentBankStatementsActual, requiredDocuments.TwoMostRecentBankStatements);
                Assert.AreEqual(getThreeMostRecentRentPaymentsActual, requiredDocuments.ThreeMostRecentRentPayments);
                Assert.AreEqual(getMostRecentTaxReturnActual, requiredDocuments.MostRecentTaxReturn);

                Console.WriteLine($"TwoRecentPaystubs AR: {getTwoRecentPaystubsActual} = {requiredDocuments.TwoRecentPaystubs} :ER");
                Console.WriteLine($"EmploymentVerificationLetter AR: {getEmploymentVerificationLetterActual} = {requiredDocuments.EmploymentVerificationLetter} :ER");
                Console.WriteLine($"GovIssuedI AR: {getGovIssuedIdActual} = {requiredDocuments.GovIssuedId} :ER");
                Console.WriteLine($"TwoMostRecentBankStatements AR: {getTwoMostRecentBankStatementsActual} = {requiredDocuments.TwoMostRecentBankStatements} :ER");
                Console.WriteLine($"ThreeMostRecentRentPayments AR: {getThreeMostRecentRentPaymentsActual} = {requiredDocuments.ThreeMostRecentRentPayments} :ER");
                Console.WriteLine($"MostRecentTaxReturn AR: {getMostRecentTaxReturnActual} = {requiredDocuments.MostRecentTaxReturn} :ER");
            });

            return this;
        }

        #endregion
    }
}
