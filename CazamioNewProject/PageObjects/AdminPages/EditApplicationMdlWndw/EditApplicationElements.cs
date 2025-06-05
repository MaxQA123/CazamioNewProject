using CazamioNewProject.GuiHelpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [FindsBy(How = How.XPath, Using = ("//app-edit-application//h3[text() = 'Edit application']"))]
        public IWebElement EditApplicationTitle;

        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'requestedOfferPrice']"))]
        public IWebElement RequestedOfferPriceFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'leasePrice']"))]
        public IWebElement LeasePriceFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'depositPrice']"))]
        public IWebElement SecurityDepositFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[@class='add-fields-text' and contains(., 'Concession')]//span[normalize-space(text())='+ Add']"))]
        public IWebElement PlusAddConcessionBtn;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[@class='add-fields-text' and contains(., 'Concession')]//span[normalize-space(text())='- Remove']"))]
        public IWebElement RemoveConcessionBtn;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'monthsFree']"))]
        public IWebElement MonthsFreeFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'netPrice']"))]
        public IWebElement NetEffectiveRentField;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'additionalInfo']"))]
        public IWebElement AdditionalInfoFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//label[text() = 'Move in Date']/following-sibling::mat-form-field"))]
        public IWebElement MoveInDateFieldButton;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@formcontrolname = 'rentalTerms']"))]
        public IWebElement RentalTermsFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'paidMonths']"))]
        public IWebElement MonthlyRentsPrePaymentFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[@class='add-fields-text' and contains(., 'Requested Work')]//span[normalize-space(text())='+ Add']"))]
        public IWebElement PlusAddRequestedWorkBtn;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//textarea[@id = 'requestedWork']"))]
        public IWebElement RequestedWorkFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//mat-checkbox[@id='is-referral']//input[@id = 'is-referral-input']"))]
        public IWebElement ReferralAgentCheckTheBox;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//textarea[@id = 'referral-details']"))]
        public IWebElement ReferralDetailsFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//mat-select[@class = 'agent-select mat-mdc-select-empty']"))]
        public IWebElement AssignedAgentBtn;

        public IWebElement SetAgentAgentusBrokerusItem()
        {

            var xpath = "//mat-option//span[text() = '" + agentBroker.CreatedAgentMySpace.FullName + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[@class = 'applicants main-applicant']//input[@placeholder = 'Look up existing lead or create new']"))]
        public IWebElement EmailAddressMainApplicantFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[@class = 'add-applicant']"))]
        public IWebElement PlusAddApplicantBtn;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//div[@class = 'applicants']//input")]
        public IWebElement FirstFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//mat-checkbox[@id = 'is-guarantor']//input[@id = 'is-guarantor-input']")]
        public IWebElement CheckBoxThisIsAGuarantorFirstEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//div[@class = 'remove-applicant']")]
        public IWebElement CrossBtnFirstForDeleting;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//div[@class = 'email-input no-margin'][2]//input")]
        public IWebElement SecondFieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//mat-checkbox[@id = 'is-guarantor-1']")]
        public IWebElement CheckBoxThisIsAGuarantorSecondEmailAddressField;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//div[@class = 'email-input no-margin'][2]//div[@class = 'remove-applicant']")]
        public IWebElement CrossBtnSecondForDeleting;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//span[text() = 'Edit']")]
        public IWebElement EditBtn;

        #region Edit application modal window for confirmation

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//div[text() = ' Sure you want to edit this application? ']"))]
        public IWebElement SureYouWantToEditThisApplicationSubTitle;

        [FindsBy(How = How.XPath, Using = "//app-edit-application//span[text() = 'Edit']")]
        public IWebElement EditBtnForConfirmation;

        #endregion
    }
}
