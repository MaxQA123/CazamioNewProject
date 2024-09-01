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
            WaitUntil.CustomElementIsVisible(LoaderHidden);
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
            Assert.AreEqual(getMonthlyRentsPrePayment, demo.UnitBasicData.MonthlyRentsPrePaymentOne);

            Console.WriteLine($"MonthlyRentsPrePayment AR: {getMonthlyRentsPrePayment} = {demo.UnitBasicData.MonthlyRentsPrePaymentOne} :ER MonthlyRentsPrePayment");

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

        [AllureStep("GetApartmentHoldDeposit")]
        public string GetApartmentHoldDeposit()
        {
            WaitUntil.CustomElementIsVisible(FieldInputApartmentHoldDeposit);
            string getApartmentHoldDeposit = FieldInputApartmentHoldDeposit.GetAttribute("value");
            string getApartmentHoldDepositActual = getApartmentHoldDeposit.ToString();

            return getApartmentHoldDepositActual;
        }

        [AllureStep("VerifyApartmentHoldDepositAddApartmentsPage")]
        public AddApartments VerifyApartmentHoldDepositAddApartmentsPage(string getApartmentHoldDepositFromAddApartments)
        {
            Assert.AreEqual(getApartmentHoldDepositFromAddApartments, building.MySpaceAmountPayments.HoldDepositByDefault);

            Console.WriteLine($"Apartment Hold Deposit AR: {getApartmentHoldDepositFromAddApartments} = {building.MySpaceAmountPayments.HoldDepositByDefault} :ER");

            return this;
        }

        [AllureStep("GetRentalTerms")]
        public string GetRentalTerms()
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

        [AllureStep("GetRequiredDocumentTwoRecentPaystubs")]
        public string GetRequiredDocumentTwoRecentPaystubs()
        {
            WaitUntil.WaitSomeInterval(100);
            string getTwoRecentPaystubs = ItemTwoRecentPaystubs.Text;
            string getTwoRecentPaystubsActual = getTwoRecentPaystubs.ToString();

            return getTwoRecentPaystubsActual;
        }

        [AllureStep("GetRequiredDocumentItemEmploymentVerificationLetter")]
        public string GetRequiredDocumentItemEmploymentVerificationLetter()
        {
            WaitUntil.WaitSomeInterval(100);
            string getEmploymentVerificationLetter = ItemEmploymentVerificationLetter.Text;
            string getEmploymentVerificationLetterActual = getEmploymentVerificationLetter.ToString();

            return getEmploymentVerificationLetterActual;
        }

        [AllureStep("GetRequiredDocumentTwoMostRecentBankStatements")]
        public string GetRequiredDocumentTwoMostRecentBankStatements()
        {
            WaitUntil.WaitSomeInterval(100);
            string getTwoMostRecentBankStatements = ItemTwoMostRecentBankStatements.Text;
            string getTwoMostRecentBankStatementsActual = getTwoMostRecentBankStatements.ToString();

            return getTwoMostRecentBankStatementsActual;
        }

        [AllureStep("GetRequiredDocumentGovIssuedId")]
        public string GetRequiredDocumentGovIssuedId()
        {
            WaitUntil.WaitSomeInterval(100);
            string getGovIssuedId = ItemGovIssuedId.Text;
            string getGovIssuedIdActual = getGovIssuedId.ToString();

            return getGovIssuedIdActual;
        }

        [AllureStep("GetRequiredDocumentThreeMostRecentRentPayments")]
        public string GetRequiredDocumentThreeMostRecentRentPayments()
        {
            WaitUntil.WaitSomeInterval(100);
            string getThreeMostRecentRentPayments = ItemThreeMostRecentRentPayments.Text;
            string getThreeMostRecentRentPaymentsActual = getThreeMostRecentRentPayments.ToString();

            return getThreeMostRecentRentPaymentsActual;
        }

        [AllureStep("GetRequiredDocumentMostRecentTaxReturn")]
        public string GetRequiredDocumentMostRecentTaxReturn()
        {
            WaitUntil.WaitSomeInterval(100);
            string getMostRecentTaxReturn = ItemMostRecentTaxReturn.Text;
            string getMostRecentTaxReturnActual = getMostRecentTaxReturn.ToString();

            return getMostRecentTaxReturnActual;
        }

        [AllureStep("VerifyRequiredDocumentsByDefaultMySpaceAddApartments")]
        public AddApartments VerifyRequiredDocumentsByDefaultMySpaceAddApartments(string getThreeRecentPaystubsAddApartments, string getEmploymentVerificationLetterAddApartments, string getGovIssuedIdAddApartments, string getTwoMostRecentBankStatementsAddApartments, string getThreeMostRecentRentPaymentsAddApartments, string getMostRecentTaxReturnAddApartments)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(getThreeRecentPaystubsAddApartments, requiredDocuments.TwoRecentPaystubs);
                Assert.AreEqual(getEmploymentVerificationLetterAddApartments, requiredDocuments.EmploymentVerificationLetter);
                Assert.AreEqual(getGovIssuedIdAddApartments, requiredDocuments.GovIssuedId);
                Assert.AreEqual(getTwoMostRecentBankStatementsAddApartments, requiredDocuments.TwoMostRecentBankStatements);
                Assert.AreEqual(getThreeMostRecentRentPaymentsAddApartments, requiredDocuments.ThreeMostRecentRentPayments);
                Assert.AreEqual(getMostRecentTaxReturnAddApartments, requiredDocuments.MostRecentTaxReturn);
            });

            return this;
        }

        #endregion
    }
}
