using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.ConfirmLogOutMdlWndw
{
    public partial class ConfirmLogOutMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//app-profile-logout//p[text() = 'Are you sure that you want to log out?']")]
        public IWebElement TitleAreYouSureThatYouWantToLogOut;

        [FindsBy(How = How.XPath, Using = "//app-profile-logout//button[text() = 'No']")]
        public IWebElement BtnNo;

        [FindsBy(How = How.XPath, Using = "//app-profile-logout//button[text() = 'Yes, I am sure']")]
        public IWebElement BtnYesIamSure;
    }
}
