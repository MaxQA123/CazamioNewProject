using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        #region Applications tab

        [FindsBy(How = How.XPath, Using = "//my-info//applications//div[@class ='empty-histories ng-star-inserted']")]
        public IWebElement YouHaveNoApplicationsYetRecord;

        [FindsBy(How = How.XPath, Using = "//my-info//applications//div[@class = 'application-apartments-collection']//div[@class = 'apartment-info']//div[@class = 'application-id']")]
        public IWebElement ApplicationIdStringAndValueFromFrstRw;

        [FindsBy(How = How.XPath, Using = "//applications//span[text() = 'Complete or Edit This Application']")]
        public IWebElement CompleteOrEditThisApplicationBtn;

        #endregion
    }
}
