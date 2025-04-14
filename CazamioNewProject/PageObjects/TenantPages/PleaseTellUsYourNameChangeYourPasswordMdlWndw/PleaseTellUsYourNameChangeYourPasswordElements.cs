using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
{
    public partial class PleaseTellUsYourNameChangeYourPasswordMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//h2[text() = 'Please tell us your name and change your password']")]
        public IWebElement TitlePleaseTellUsYourNameAndChangeYourPassword;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//input[@id = 'last-name']")]
        public IWebElement FieldInputLastName;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//div[text() = ' If you plan to complete an application with us, please enter your name as appears on your ID ']")]
        public IWebElement IfYouPlanToCompleteSubText;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//div[text() = ' Your email is: ']")]
        public IWebElement YourEmailIsSubText;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//input[@id = 'password']")]
        public IWebElement FieldInputPassword;

        [FindsBy(How = How.XPath, Using = "//app-generated-tenant-signup//span[text() = 'Save']")]
        public IWebElement BtnSave;
    }
}
