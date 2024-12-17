using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= ' Account was successfully activated ']")]
        public IWebElement MessageAccountWasSuccessfullyActivated;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Successfully updated password. ']")]
        public IWebElement MessageOne;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Successfully updated name. ']")]
        public IWebElement MessageThird;

        [FindsBy(How = How.XPath, Using = "//div[text()= ' Lease price was agreed on successfully. ']")]
        public IWebElement MessageTwo;
    }
}
