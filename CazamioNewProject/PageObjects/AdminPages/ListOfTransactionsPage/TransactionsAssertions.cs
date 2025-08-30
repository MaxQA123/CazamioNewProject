using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfTransactionsPage
{
    public partial class ListOfTransactions
    {
        [AllureStep("Verify Title Transactions page")]
        public ListOfTransactions VerifyTitleTransactionsPg()
        {
            WaitUntil.CustomElementIsVisible(TitleTransactionsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleTransactionsPage));

            return this;
        }
    }
}
