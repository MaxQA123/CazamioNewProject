using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [AllureStep("VerifyTitleCreateApplication")]
        public CreateApplicationMdlWndw VerifyTitleCreateApplication()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleCreateApplication));

            return this;
        }

        [AllureStep("VerifyTitleApplicationSuccessfullyCreated")]
        public CreateApplicationMdlWndw VerifyTitleApplicationSuccessfullyCreated()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleApplicationSuccessfullyCreated));

            return this;
        }

        [AllureStep("VerifyTextLinkAlreadyCopied")]
        public CreateApplicationMdlWndw VerifyTextLinkAlreadyCopied()
        {
            Assert.IsTrue(TextSubtitle.IsVisible(TextLinkAlreadyCopied));

            return this;
        }

        [AllureStep("VerifyTenantEmail")]
        public CreateApplicationMdlWndw VerifyTenantEmail(string actualTenantEmail)
        {
            Assert.AreEqual(tenantCreatorMySpace.CreatedWithCreditReport.Email, actualTenantEmail);

            return this;
        }
    }
}
