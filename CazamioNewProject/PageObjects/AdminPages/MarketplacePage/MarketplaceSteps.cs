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
            VerifyBrandLogoSectionName();
            VerifyBrandNameSectionName();
            InputGeneral.InputFunctionWithClear(ChangeBrandNameInputField, basicDataForProject.SettingsMarketplaceMySpace.BrandNameSecond);
            WaitUntil.CustomElementIsVisible(SaveBtnForChangeBrandNameInputField);
            WaitUntil.CustomElementIsClickable(SaveBtnForChangeBrandNameInputField);
            Button.Click(SaveBtnForChangeBrandNameInputField);
            Pages.ToasterMessagesLandlord
                .VerifyMessageBrandNameHasBeenSaveddSuccessfully();
            InputGeneral.InputFunctionWithClear(ChangeBrandNameInputField, basicDataForProject.SettingsMarketplaceMySpace.BrandNameFirst);
            WaitUntil.CustomElementIsVisible(SaveBtnForChangeBrandNameInputField);
            WaitUntil.CustomElementIsClickable(SaveBtnForChangeBrandNameInputField);
            Button.Click(SaveBtnForChangeBrandNameInputField);
            Pages.ToasterMessagesLandlord
                .VerifyMessageBrandNameHasBeenSaveddSuccessfully();
            InputGeneral.InputFunctionWithClear(OwnerNameInputField, basicDataForProject.SettingsMarketplaceMySpace.Ownername);
            InputGeneral.InputFunctionWithClear(CompanyFullLegalNameInputField, basicDataForProject.SettingsMarketplaceMySpace.CompanyFullLegalName);
            InputGeneral.InputFunctionWithClear(AddressInputField, basicDataForProject.SettingsMarketplaceMySpace.Address);
            InputGeneral.InputFunctionWithClear(PhoneNumberInputField, basicDataForProject.SettingsMarketplaceMySpace.PhoneNumber);
            Button.Click(SaveBtnForDisclosureInformationSection);
            Pages.ToasterMessagesLandlord
                .VerifyMessageDisclosureЫavedЫuccessfully();

            return this;
        }
    }
}
