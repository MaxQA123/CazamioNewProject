using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplication
    {
        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Cancel']"))]
        public IWebElement ButtonCancel;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Next']"))]
        public IWebElement ButtonNext;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Back']"))]
        public IWebElement ButtonBack;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//cazamio-mobile-button//button//div//span[text() = 'Create']"))]
        public IWebElement ButtonCreate;

        #region First step with enter the email

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//h2[@class = 'Create application']"))]
        public IWebElement TitleCreateApplication;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@placeholder = 'Look up existing lead or create new']"))]
        public IWebElement FieldInputMainApplicantEmailAddress;

        #endregion

        #region Second step with enter an address

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//h2[@class = 'Create application']"))]
        public IWebElement New;

        [FindsBy(How = How.XPath, Using = ("//app-prepare-application//input[@placeholder = 'Look up existing lead or create new']"))]
        public IWebElement NewA;

        #endregion

        #region Third step with enter the basic data of an application

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement StrngLeadEmail;

        [FindsBy(How = How.XPath, Using = (""))]
        public IWebElement StrngUnitAddress;

        #endregion
    }
}
