using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region Basic elements

        [FindsBy(How = How.XPath, Using = "//table//tr//td[2]")]
        public IWebElement SubjectNotificationCommon;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'HTML')]")]
        public IWebElement ButtonBodyHtml;

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

        [FindsBy(How = How.XPath, Using = "//p[contains(., 'Dear ')]")]
        public IWebElement DearFrstRwBodyCreateMarketplaceaAdmin;
        
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Welcome to Noyo Properties NYC Real Estate!']")]
        public IWebElement ScndRwBodyCreateMarketplaceaAdmin;

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
        public IWebElement BtnCofirmEmailLandlord;

        
    }
}
