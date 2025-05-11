using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.ToasterMessages
{
    public partial class ToasterMessagesTenants
    {
        //Common Success toaster 
        //[FindsBy(How = How.XPath, Using = "//span[text() = 'Success!']")]
        //public IWebElement MessageSuccessFirstVersion;

        [FindsBy(How = How.XPath, Using = "//div[@aria-label = 'Success!']")]
        public IWebElement MessageSuccessSecondVersion;

        #region Success toasters when creating a new tenant plus application

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Account was successfully activated ']")]
        public IWebElement MessageAccountWasSuccessfullyActivated;

        //Appeared when clicking the Save buttom for the Please tell us your name and change your password MdlWndw and creating a new tenant
        [FindsBy(How = How.XPath, Using = "//div[text()= ' Successfully updated name and password. ']")]
        public IWebElement MessageSuccessfullyUpdatedNameAndPassword;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Lease price was agreed on successfully. ']")]
        public IWebElement MessageThirdLeasePriceWasAgreedOnSuccessfully;

        #endregion

        //Common Warning toaster 
        [FindsBy(How = How.XPath, Using = "//div[@aria-label = 'Warning']")]
        public IWebElement MessageWarning;

        #region Warning toasters when creating a new tenant plus application

        //Appeared when creating a new tenant + application without an application
        [FindsBy(How = How.XPath, Using = "//div[text()= 'Not found']")]
        public IWebElement MessageNotFound;

        #endregion
    }
}
