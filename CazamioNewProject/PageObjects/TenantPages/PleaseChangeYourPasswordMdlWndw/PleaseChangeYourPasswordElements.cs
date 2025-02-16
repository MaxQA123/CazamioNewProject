using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseChangeYourPasswordMdlWndw
{
    public partial class PleaseChangeYourPasswordMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-change-password//h2[text() = 'Please change your password']")]
        public IWebElement TitlePleaseChangeYourPassword;

        [FindsBy(How = How.XPath, Using = "//app-change-password//input[@id = 'password']")]
        public IWebElement FieldInputPassword;

        [FindsBy(How = How.XPath, Using = "//app-change-password//span[text() = 'Save']")]
        public IWebElement BtnSave;
    }
}
