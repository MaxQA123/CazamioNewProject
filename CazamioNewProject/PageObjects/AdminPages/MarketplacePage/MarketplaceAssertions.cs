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

        [AllureStep("Verify Brand Logo section name")]
        public Marketplace VerifyBrandLogoSectionName()
        {
            WaitUntil.CustomElementIsVisible(BrandLogoSectionName);
            Assert.IsTrue(TextSubtitle.IsVisible(BrandLogoSectionName));

            return this;
        }

        [AllureStep("Verify Brand Name section name")]
        public Marketplace VerifyBrandNameSectionName()
        {
            WaitUntil.CustomElementIsVisible(BrandNameSectionName);
            Assert.IsTrue(TextSubtitle.IsVisible(BrandNameSectionName));

            return this;
        }

        [AllureStep("Verify Disclosure Information section name")]
        public Marketplace VerifyDisclosureInformationSectionName()
        {
            Assert.IsTrue(TextSubtitle.IsVisible(DisclosureInformationSectionName));

            return this;
        }
    }
}
