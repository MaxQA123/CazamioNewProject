using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfTransactionsPage
{
    public partial class ListOfTransactions
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'Transactions']")]
        public IWebElement TitleTransactionsPage;
    }
}
