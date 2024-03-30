using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.Header
{
    public partial class Header
    {
        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/signup']")]
        public IWebElement ButtonSignUp;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/signin']")]
        public IWebElement ButtonLogIn;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/my-info/applications']")]
        public IWebElement ButtonMyApplications;

        [FindsBy(How = How.XPath, Using = "//logged-in-header//header//div[@class = 'user-panel']//ul//li[@class = 'avatar']")]
        public IWebElement ButtonInFormAvatar;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label= 'My account']")]
        public IWebElement ButtonMyAccount;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Sign Out']")]
        public IWebElement ButtonSignOut;
    }
}
