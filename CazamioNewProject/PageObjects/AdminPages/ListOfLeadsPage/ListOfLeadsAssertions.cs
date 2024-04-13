using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage
{
    public partial class ListOfLeads
    {
        [AllureStep("VerifyTitleListOfCommissionsPg")]
        public ListOfLeads VerifyTitleListOfCommissionsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfCommissions));

            return this;
        }
    }
}
