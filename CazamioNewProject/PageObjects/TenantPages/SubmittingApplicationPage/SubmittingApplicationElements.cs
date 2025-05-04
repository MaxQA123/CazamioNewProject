using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        #region Block with applicationId

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Account was successfully activated ']")]
        public IWebElement ApplicationIdVl;

        #endregion
    }
}
