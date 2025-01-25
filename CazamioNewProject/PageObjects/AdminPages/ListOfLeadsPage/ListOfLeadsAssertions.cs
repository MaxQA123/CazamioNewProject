using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage
{
    public partial class ListOfLeads
    {
        [AllureStep("VerifyTitleLeads")]
        public ListOfLeads VerifyTitleLeads()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleLeads));

            return this;
        }
    }
}
