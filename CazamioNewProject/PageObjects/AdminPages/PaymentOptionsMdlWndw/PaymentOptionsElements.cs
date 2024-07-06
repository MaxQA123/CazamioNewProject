using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentOptionsMdlWndw
{
    public partial class PaymentOptionsMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Payment options']")]
        public IWebElement TitlePaymentOptions;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Credit Card ']")]
        public IWebElement ItemCreditCard;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' ACH ']")]
        public IWebElement ItemAch;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Deliver Check ']")]
        public IWebElement ItemDeliverCheck;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Zelle ']")]
        public IWebElement ItemZelle;

        [FindsBy(How = How.XPath, Using = "//label[text() = ' Venmo ']")]
        public IWebElement ItemVenmo;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input']//textarea")]
        public IWebElement FieldInputDeliverCheckNoteBuilding;

        [FindsBy(How = How.XPath, Using = "//mat-dialog-container//label[contains(text(), 'Deliver check note')]//following-sibling::textarea")]
        public IWebElement FieldInputDeliverCheckNoteApartment;

        [FindsBy(How = How.XPath, Using = "//div[@class='note-input']//label[contains(text(), 'Zelle address or phone')]/following-sibling::input[@type='text']")]
        public IWebElement FieldInputZelleAddressOrPhoneBuilding;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(), 'Zelle address or phone')]/following-sibling::input[@type='text']")]
        public IWebElement FieldInputZelleAddressOrPhoneApartment;

        ////mat-dialog-container//div[@class = 'payments-wrapper']//div[@class = 'note-input ng-star-inserted'][2]//input

        [FindsBy(How = How.XPath, Using = "//input[@id = 'change-brand']")]
        public IWebElement ButtonForVenmoQrCodeImage;

        [FindsBy(How = How.XPath, Using = "//app-select-payment-method//span[@class = 'cazamio-button-txt']")]
        public IWebElement ButtonSave;

        [FindsBy(How = How.XPath, Using = "//i[@class= 'material-icons']")]
        public IWebElement ButtonInFormCross;

        #region Assertions

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Success']")]
        public IWebElement MessageSuccessMdlWndwOptns;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Payment methods selected, Click save to confirm']")]
        public IWebElement MessageSuccessPaymentMethodsSelectedMdlWndwOptns;

        #endregion
    }
}
