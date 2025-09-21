using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Password']")]
        public IWebElement FieldInputPassword;

        [FindsBy(How = How.XPath, Using = "//span[@class= 'show-password']")]
        public IWebElement IconShow;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'btn btn-warning btn-link btn-lg card-footer-btn']")]
        public IWebElement ButtonLetsGo;

        [FindsBy(How = How.XPath, Using = "//h4[text() = 'Login']")]
        public IWebElement TitleLogInPg;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/account/forgot-password']")]
        public IWebElement LinkForgotPassword;

        [FindsBy(How = How.XPath, Using = "//signin//form//div[@class = 'email-wrapper']//input/following-sibling::div[text() = ' Email is required ']")]
        public IWebElement MessageEmailIsRequired;

        [FindsBy(How = How.XPath, Using = "//signin//form//div[text() = ' Password is required ']")]
        public IWebElement MessagePasswordIsRequired;
    }
}
