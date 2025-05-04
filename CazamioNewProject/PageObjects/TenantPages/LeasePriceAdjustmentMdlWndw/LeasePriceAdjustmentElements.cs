using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.LeasePriceAdjustmentMdlWndw
{
    public partial class LeasePriceAdjustmentMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-accept-lease-price//h2[text() = 'Lease price adjustment']")]
        public IWebElement TitleLeasePriceAdjustment;

        [FindsBy(How = How.XPath, Using = "//app-accept-lease-price//span[text() = 'Save']")]
        public IWebElement SaveBtn;

        [FindsBy(How = How.XPath, Using = "//app-accept-lease-price//span[text() = 'Cancel']")]
        public IWebElement CancelBtn;
    }
}
