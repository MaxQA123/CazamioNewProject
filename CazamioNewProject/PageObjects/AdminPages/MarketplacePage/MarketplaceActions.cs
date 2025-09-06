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

        [AllureStep("Click Save button for Brand Name field")]
        public Marketplace ClickSaveBtnForChangeBrandNameInputField()
        {
            WaitUntil.CustomElementIsVisible(SaveBtnForChangeBrandNameInputField);
            WaitUntil.CustomElementIsClickable(SaveBtnForChangeBrandNameInputField);
            Button.Click(SaveBtnForChangeBrandNameInputField);

            return this;
        }

        [AllureStep("Enter Owner name")]
        public Marketplace EnterOwnerName()
        {
            WaitUntil.CustomElementIsVisible(OwnerNameInputField);
            InputGeneral.InputFunctionWithClear(OwnerNameInputField, basicDataForProject.SettingsMarketplaceMySpace.Ownername);

            return this;
        }

        [AllureStep("Enter Company Full Legal name")]
        public Marketplace EnterCompanyFullLegalName()
        {
            WaitUntil.CustomElementIsVisible(CompanyFullLegalNameInputField);
            InputGeneral.InputFunctionWithClear(CompanyFullLegalNameInputField, basicDataForProject.SettingsMarketplaceMySpace.CompanyFullLegalName);

            return this;
        }

        [AllureStep("Enter Address")]
        public Marketplace EnterAddress()
        {
            WaitUntil.CustomElementIsVisible(AddressInputField);
            InputGeneral.InputFunctionWithClear(AddressInputField, basicDataForProject.SettingsMarketplaceMySpace.Address);

            return this;
        }

        [AllureStep("Enter Phone number")]
        public Marketplace EnterPhoneNumber()
        {
            WaitUntil.CustomElementIsVisible(PhoneNumberInputField);
            InputGeneral.InputFunctionWithClear(PhoneNumberInputField, basicDataForProject.SettingsMarketplaceMySpace.PhoneNumber);

            return this;
        }

        [AllureStep("Click Save button for Disclosure Information section")]
        public Marketplace ClickSaveBtnForDisclosureInformationSection()
        {
            WaitUntil.CustomElementIsVisible(SaveBtnForDisclosureInformationSection);
            WaitUntil.CustomElementIsClickable(SaveBtnForDisclosureInformationSection);
            Button.Click(SaveBtnForDisclosureInformationSection);

            return this;
        }
    }
}
