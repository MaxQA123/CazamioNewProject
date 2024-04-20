using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw
{
    public partial class CreateANewMarketplaceAdminMdlWindow
    {
        [AllureStep("VerifyTitleCreateANewMarketplaceadmin")]
        public CreateANewMarketplaceAdminMdlWindow VerifyTitleCreateANewMarketplaceadmin()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateANewMarketplaceadmin));

            return this;
        }

        [AllureStep("VerifyNameHostMarketplaceSubdomain")]
        public CreateANewMarketplaceAdminMdlWindow VerifyNameHostMarketplaceSubdomain()
        {
            Assert.IsTrue(Successfully.IsVisible(NameHostMarketplaceSubdomain));

            return this;
        }
    }
}
