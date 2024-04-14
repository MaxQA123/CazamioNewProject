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
            Assert.IsTrue(Successfully.IsVisible(TitleLeads));

            return this;
        }
    }
}
