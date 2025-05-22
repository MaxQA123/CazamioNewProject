using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        #region Block with applicationId

        [FindsBy(How = How.XPath, Using = "//app-tenant-application//p")]
        public IWebElement ApplicationIdVl;

        #endregion
    }
}
