using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.PaymentSettingsPage
{
    public partial class PaymentSettings
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'Payment settings']")]
        public IWebElement TitlePaymentSettingsPage;
    }
}
