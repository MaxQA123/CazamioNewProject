using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

        [AllureStep("Enter Brand Name MySpace NYC")]
        public Marketplace EnterBrandNameMySpaceNYC()
        {
            WaitUntil.CustomElementIsVisible(ChangeBrandNameInputField);
            InputGeneral.InputFunctionWithClear(ChangeBrandNameInputField, basicDataForProject.SettingsMarketplaceMySpace.BrandNameSecond);

            return this;
        }

        [AllureStep("Enter Brand Name Noyo Properties NYC")]
        public Marketplace EnterBrandNameNoyoPropertiesNYC()
        {
            WaitUntil.CustomElementIsVisible(ChangeBrandNameInputField);
            InputGeneral.InputFunctionWithClear(ChangeBrandNameInputField, basicDataForProject.SettingsMarketplaceMySpace.BrandNameFirst);

            return this;
        }
    }
}
