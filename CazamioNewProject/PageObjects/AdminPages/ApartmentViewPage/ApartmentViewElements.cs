using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Look up existing lead or create new']")]
        public IWebElement FieldInputGetApplicationLink;

        [FindsBy(How = How.XPath, Using = "//button[@title = 'Get Link']")]
        public IWebElement ButtonGetLink;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'creator_name']//div[@class = 'first-name-input-container']//input[@placeholder = 'First Name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'creator_name']//div[@id = 'last_name']//input[@placeholder = 'Last Name']")]
        public IWebElement FieldInputLastName;
    }
}
