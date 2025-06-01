using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [AllureStep("FillInBrandNameAndDisclosureInformation")]
        public Marketplace FillInBrandNameAndDisclosureInformation()
        {
            WaitUntil.CustomElementIsVisible(BrandLogoSectionName);
            InputGeneral.InputFunctionWithClear(ChangeBrandNameInputField, basicDataForProject.SettingsMarketplaceMySpace.CompanyFullLegalName);

            return this;
        }
    }
}
