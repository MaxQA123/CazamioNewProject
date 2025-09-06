using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Cancel']"))]
        public IWebElement ButtonCancel;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Next']"))]
        public IWebElement ButtonNext;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Back']"))]
        public IWebElement ButtonBack;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Create']"))]
        public IWebElement ButtonCreate;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Close']"))]
        public IWebElement ButtonClose;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Add Applicant']"))]
        public IWebElement ButtonAddApplicant;

        #region First step with enter the email

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//h2[text() = 'Create application']"))]
        public IWebElement TitleCreateApplication;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = ' Main Applicant email address ']"))]
        public IWebElement NameFieldMainApplicantEmailAddress;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@placeholder = 'Look up existing lead or create new']"))]
        public IWebElement FieldInputMainApplicantEmailAddress;

        #endregion

        #region Second step with enter an address

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[@class = 'address-input']"))]
        public IWebElement UnitAddressButton;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[@class = 'address-input']//input[@aria-autocomplete = 'list']"))]
        public IWebElement UnitAddressFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//ng-dropdown-panel//span[contains(@title, '12867 Gates Avenue')]"))]
        public IWebElement OneTwoEightSixSevenGatesAvenueAddress;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//ng-dropdown-panel//span[contains(@title, '111A East 51st Street Pedestrian Crossing')]"))]
        public IWebElement OneOneOneAEastStPedestrianCrossingAddressAddress;

        public IWebElement SetOneTwoEightSixSevenGatesAvenueAddress()
        {
            Building building = Building.Generate();

            var xpath = "//app-prepare-application//ng-dropdown-panel//span[contains(@title, '" + building.GatesAvenue.NumberNameAddress + "')]";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement SetOneOneOneAEastStPedestrianCrossingAddressAddress()
        {
            Building building = Building.Generate();

            var xpath = "//app-prepare-application//ng-dropdown-panel//span[contains(@title, '" + building.East51stStreetPedestrianCrossing.NumberNameAddress + "')]";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[@class = 'address-input']//input"))]
        public IWebElement VlFromBtnUnitAddress;

        #endregion

        #region Third step with enter the basic data of an application

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = ' Lead Email ']"))]
        public IWebElement StringLeadEmail;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = ' Lead Email ']/following-sibling::div[1]"))]
        public IWebElement VlFromStringLeadEmail;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = ' Unit Address ']/following-sibling::div[1]"))]
        public IWebElement VlFromStringUnitAddress;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'requested-offer-price']"))]
        public IWebElement FieldInputRequestedOfferPrice;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'lease-price']"))]
        public IWebElement FieldInputLeasePrice;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'security-deposit']"))]
        public IWebElement FieldInputSecurityDeposit;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'monthsFree']"))]
        public IWebElement FieldInputMonthsFree;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'netPrice']"))]
        public IWebElement FieldNetEffectiveRent;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'additionalInfo']"))]
        public IWebElement FieldInputAdditionalInfo;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@id = 'rent-pre-payment']"))]
        public IWebElement FieldInputMonthlyRentsPrePayment;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//label[text() = 'Move in Date']/following-sibling::mat-form-field"))]
        public IWebElement FieldButtonMoveInDate;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//textarea[@id = 'requestedWork']"))]
        public IWebElement FieldInputRequestedWork;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@formcontrolname = 'rentalTerms']"))]
        public IWebElement FieldInputRentalTerms;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//textarea[@id = 'referral-details']"))]
        public IWebElement FieldInputReferralDetails;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[@class='add-fields-text' and contains(., 'Requested Work')]//span[normalize-space(text())='+ Add']"))]
        public IWebElement ButtonPlusAddRequestedWork;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//mat-checkbox[@id='is-referral']//input[@id = 'is-referral-input']"))]
        public IWebElement CheckTheBoxReferralAgent;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[@class='add-fields-text' and contains(., 'Concession')]//span[normalize-space(text())='+ Add']"))]
        public IWebElement ButtonPlusAddConcession;

        #endregion

        #region Fourth step with adding the applicants to an application

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = 'Application successfully created']"))]
        public IWebElement TitleApplicationSuccessfullyCreated;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//div[text() = 'Link for the application was generated and already copied']"))]
        public IWebElement TextLinkAlreadyCopied;

        #endregion
    }
}
