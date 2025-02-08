using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AddressManagerPage
{
    public partial class AddressManager
    {
        [FindsBy(How = How.XPath, Using = "//div[text() = 'Address manager']")]
        public IWebElement TitleAddressManagerPg;
    }
}
