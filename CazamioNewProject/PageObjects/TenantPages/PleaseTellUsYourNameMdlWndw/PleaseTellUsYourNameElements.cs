using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameMdlWndw
{
    public partial class PleaseTellUsYourNameMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//h2[text() = 'Please tell us your name']")]
        public IWebElement TitlePleaseTellUsYourName;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//input[@id = 'last-name']")]
        public IWebElement FieldInputLastName;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//span[text() = 'Save']")]
        public IWebElement BtnSave;
    }
}
