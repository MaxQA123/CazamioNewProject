using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfLeadsPage
{
    public partial class ListOfLeads
    {
        [AllureStep("Verify Title Leads page")]
        public ListOfLeads VerifyTitleLeads()
        {
            WaitUntil.CustomElementIsVisible(TitleLeads);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleLeads));

            return this;
        }
    }
}
