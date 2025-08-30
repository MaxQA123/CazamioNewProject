using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [AllureStep("Verify Title Marketplace page")]
        public Marketplace VerifyTitleMarketplacePg()
        {
            WaitUntil.CustomElementIsVisible(TitleMarketplacePage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleMarketplacePage));

            return this;
        }

        [AllureStep("VerifyBrandLogoSectionName")]
        public Marketplace VerifyBrandLogoSectionName()
        {
            Assert.IsTrue(TextSubtitle.IsVisible(BrandLogoSectionName));

            return this;
        }

        [AllureStep("VerifyBrandNameSectionName")]
        public Marketplace VerifyBrandNameSectionName()
        {
            Assert.IsTrue(TextSubtitle.IsVisible(BrandNameSectionName));

            return this;
        }

        [AllureStep("VerifyDisclosureInformationSectionName")]
        public Marketplace VerifyDisclosureInformationSectionName()
        {
            Assert.IsTrue(TextSubtitle.IsVisible(DisclosureInformationSectionName));

            return this;
        }
    }
}
