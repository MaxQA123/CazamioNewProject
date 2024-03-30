using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfCommissionsPage
{
    public partial class ListOfCommissions
    {
        [AllureStep("VerifyTitleListOfCommissionsPg")]
        public ListOfCommissions VerifyTitleListOfCommissionsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleListOfCommissions));

            return this;
        }
    }
}
