using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureDeleteTemplteMdlWndw
{
    public partial class AreYouSureDeleteTemplteMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Are you sure?']")]
        public IWebElement TitleAreYouSure;

        [FindsBy(How = How.XPath, Using = "//div[text() = 'Are you sure you want to delete a template?']")]
        public IWebElement SubTitleAreYouSureYouWantDeleteTemplate;

        [FindsBy(How = How.XPath, Using = "//button[text() = 'Delete']")]
        public IWebElement DeleteBtn;
    }
}
