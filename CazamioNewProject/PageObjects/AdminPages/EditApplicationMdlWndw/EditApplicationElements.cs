using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [FindsBy(How = How.XPath, Using = ("//app-edit-application//h3[text() = 'Edit application']"))]
        public IWebElement EditApplicationTitle;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'requestedOfferPrice']"))]
        public IWebElement RequestedOfferPriceFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'leasePrice']"))]
        public IWebElement LeasePriceFieldInput;

        [FindsBy(How = How.XPath, Using = ("//app-edit-application//input[@id = 'depositPrice']"))]
        public IWebElement SecurityDepositFieldInput;
    }
}
