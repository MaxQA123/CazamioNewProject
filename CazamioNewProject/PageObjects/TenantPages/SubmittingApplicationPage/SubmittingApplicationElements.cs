using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        #region Block with applicationId

        [FindsBy(How = How.XPath, Using = "substring-after(//app-tenant-application//div[@class='apartment-address']//p[contains(text(), 'Application Id: #')], 'Application Id: #')")]
        public IWebElement ApplicationIdVl;

        #endregion
    }
}
