using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfMarketplaceAdminsPage
{
    public partial class ListOfMarketplaceAdmins
    {
        [AllureStep("VerifyTitleListOfMarketplaceAdmins")]
        public ListOfMarketplaceAdmins VerifyTitleListOfMarketplaceAdmins()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfMarketplaceAdmins));

            return this;
        }

        [AllureStep("VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated")]
        public ListOfMarketplaceAdmins VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageMarketplaceAdminHasBeenSuccessfullyCreated));

            return this;
        }
    }
}
