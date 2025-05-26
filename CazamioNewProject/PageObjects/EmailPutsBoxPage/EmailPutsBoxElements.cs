using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region PageListOfLetters

        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'HTML')]")]
        public IWebElement ButtonBodyHtml;

        #endregion

        #region SubjectLetterOfTenant

        [FindsBy(How = How.XPath, Using = "//td[text() = 'You’re (Almost) In!']")]
        public IWebElement SubjectLetterCreateTenant;

        [FindsBy(How = How.XPath, Using = "//table//tr//td[2]")]
        public IWebElement SubjectNotificationCommon;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Start Your Application Now!']")]
        public IWebElement ButtonStartYourApplicationNow;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonConfirmEmailForTenant;

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForTenant;

        #endregion

        #region SubjectLetterOfAdmin

        [FindsBy(How = How.XPath, Using = "//table[@class ='es-content']//tbody//tr[3]//table[@class = 'es-content-body']//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement ButtonResetPasswordForAdmin;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Marketplace Admin at Noyo Properties NYC!']")]
        public IWebElement TitleLetterCreateAdminMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as a Broker at Noyo Properties NYC!']")]
        public IWebElement TitleLetterCreateBrokerMySpace;

        [FindsBy(How = How.XPath, Using = "//td[text() = 'Welcome Aboard as an Agent at Noyo Properties NYC!']")]
        public IWebElement SubjectLetterCreateAgentMySpace;

        [FindsBy(How = How.XPath, Using = "//td[@class = 'esd-block-text']//p[contains(text(), 'password:')]//span")]
        public IWebElement PasswordFromTextForCreationAdminUser;

        [FindsBy(How = How.XPath, Using = "//tbody//tr[3]//a[contains(@href, 'https://u28342774.ct.sendgrid.net/ls/click')]")]
        public IWebElement BtnCofirmEmailLandlord;

        #endregion
    }
}
