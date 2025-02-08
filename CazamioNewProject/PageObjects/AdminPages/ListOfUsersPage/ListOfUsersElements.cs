using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.UsersPage
{
    public partial class ListOfUsers
    {
        [FindsBy(How = How.XPath, Using = "//div[text() = 'List of users']")]
        public IWebElement TitleListOfUsersPg;
    }
}
