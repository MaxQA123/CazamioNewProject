using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//h3[text() = 'Create a new Broker']")]
        public IWebElement TitleCreateNewBroker;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Create']")]
        public IWebElement ButtonCreate;
    }
}
