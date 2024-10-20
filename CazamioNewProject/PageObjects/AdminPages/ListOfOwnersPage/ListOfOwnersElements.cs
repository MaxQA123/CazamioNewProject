using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'List of owners']"))]
        public IWebElement TitleListOfOwnersPg;

        [FindsBy(How = How.XPath, Using = ("//button//span[text() = 'Create Owner']"))]
        public IWebElement ButtonCreateOwner;

        [FindsBy(How = How.XPath, Using = ("//tbody//tr//td[4]"))]
        public IWebElement FirstOwnerEmailOnPage;

        [FindsBy(How = How.XPath, Using = ("//span[text() = 'Owner has been successfully created']"))]
        public IWebElement MessageOwnerHasBeenSuccessfullyCreated;
    }
}
