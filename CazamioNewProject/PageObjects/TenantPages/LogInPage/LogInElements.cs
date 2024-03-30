using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.LogInPage
{
    public partial class LogInTenant
    {
        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmailAddress;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password']")]
        public IWebElement FieldInputPassword;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'show-password-container']//span[@class = 'ng-star-inserted']")]
        public IWebElement IconShow;

        [FindsBy(How = How.XPath, Using = "//label[@for= 'checkbox-remember']//span[@class = 'check-label-box']")]
        public IWebElement CheckBoxRememberMe;

        [FindsBy(How = How.XPath, Using = "//button[@aria-label= 'button']//span[text() = 'Login']")]
        public IWebElement ButtonLogIn;

        [FindsBy(How = How.XPath, Using = "//a[text() = 'Forgot password?']")]
        public IWebElement ButtonForgotPassword;

        [FindsBy(How = How.XPath, Using = "//span[text() = 'Account was successfully activated']")]
        public IWebElement MessageAccountWasSuccessfullyActivated;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'You have succesfully changed your password and you can now login back to your account.')]")]
        public IWebElement MessageYouHaveSuccesfullyChangedYourPassword;
    }
}
