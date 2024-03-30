using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfTransactionsPage
{
    public partial class ListOfTransactions
    {
        [AllureStep("VerifyTitleTransactionsPg")]
        public ListOfTransactions VerifyTitleTransactionsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleTransactionsPage));

            return this;
        }
    }
}
