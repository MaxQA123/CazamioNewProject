using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region Basic elements

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'HTML')]")]
        public IWebElement ButtonBodyHtml;

        [FindsBy(How = How.XPath, Using = "//section[@class = 'putsbox-url-box']//input[@id = 'putsbox-token-input']")]
        public IWebElement YourPutsBoxEmailFieldInput;

        [FindsBy(How = How.XPath, Using = "//table//tr//td[2]")]
        public IWebElement SubjectNotificationCommon;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Dear ')]")]
        public IWebElement DearRowCommon;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Welcome ')]")]
        public IWebElement WelcomeRowCommon;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'To get started:')]")]
        public IWebElement ToGetStartedCommon;

        [FindsBy(How = How.XPath, Using = "//td//a[text() = 'Get started']")]
        public IWebElement GetStartedBtn;

        #endregion

        #region Subjects and bodies notifications when creating the users on the tenant's website

        [FindsBy(How = How.XPath, Using = "//td[text() = 'You’re (Almost) In!']")]
        public IWebElement SubjectNotificationCreateTenant;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Start Your Application Now!']")]
        public IWebElement ButtonStartYourApplicationNow;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonConfirmEmailForTenant;

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForTenant;

        #endregion

        #region Subjects and bodies notifications when creating the users on the landlord's website

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'We are delighted')]")]
        public IWebElement ThrdRwBodyWeAreDelightedCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., '1. Copy the password:')]")]
        public IWebElement FfthRwBodyCopyThePasswordCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., '2. Click the button')]")]
        public IWebElement SxthRwBodyClickTheButtonGetStartedCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Paste the password:')]")]
        public IWebElement SvnthRwBodyPasteThePasswordCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Paste the email')]")]
        public IWebElement EightthRwBodyOnlyTextPasteTheEmailCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., '5. Click the ')]")]
        public IWebElement NinethRwBodyClickTheLetsGoCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'If you have any questions, please contact our support team')]")]
        public IWebElement TenthRwBodyPleaseContactOurSupportTeamCreateMarketplaceaAdmin;

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Your account was created')]")]
        public IWebElement ElevnthRwBodyYourAccountWasCreatedCreateMarketplaceaAdmin;

        #endregion

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForAdmin;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!']")]
        public IWebElement SubjectNotificationCreateAdminMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Broker at Noyo Properties NYC!']")]
        public IWebElement SubjectNotificationCreateBrokerMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as an Agent at Noyo Properties NYC!']")]
        public IWebElement SubjectNotificationCreateAgentMySpace;

        [FindsBy(How = How.XPath, Using = "//td[@class = 'esd-block-text']//p[contains(text(), 'password:')]//span")]
        public IWebElement PasswordFromTextForCreationAdminUser;

        [FindsBy(How = How.XPath, Using = "//tbody//tr[3]//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement BtnGetStartedForConfirmingUserLandlord;

        
    }
}
