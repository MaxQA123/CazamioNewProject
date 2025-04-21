using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [FindsBy(How = How.XPath, Using = ("//app-edit-application//h3[text() = 'Edit application']"))]
        public IWebElement EditApplicationTitle;
    }
}
