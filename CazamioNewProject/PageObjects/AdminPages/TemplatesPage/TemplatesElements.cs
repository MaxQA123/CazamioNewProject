using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'Templates']")]
        public IWebElement TitleTemplatesPage;
    }
}
