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
            Assert.IsTrue(Successfully.IsVisible(TitleListOfMarketplaceAdmins));

            return this;
        }

        [AllureStep("VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated")]
        public ListOfMarketplaceAdmins VerifyMessageMarketplaceAdminHasBeenSuccessfullyCreated()
        {
            WaitUntil.CustomElementIsVisible(MessageMarketplaceAdminHasBeenSuccessfullyCreated);
            Assert.IsTrue(Successfully.IsVisible(MessageMarketplaceAdminHasBeenSuccessfullyCreated));

            return this;
        }
    }
}
