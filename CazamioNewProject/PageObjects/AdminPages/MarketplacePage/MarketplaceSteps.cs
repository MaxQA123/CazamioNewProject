using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.MarketplacePage
{
    public partial class Marketplace
    {
        [AllureStep("Update settings on the Marketplace page")]
        public Marketplace UpdateSettingsOnMarketplacePage()
        {
            VerifyTitleMarketplacePg();
            VerifyBrandLogoSectionName();
            VerifyBrandNameSectionName();
            WaitUntil.WaitSomeInterval(500);
            EnterBrandNameMySpaceNYC();
            ClickSaveBtnForChangeBrandNameInputField();
            Pages.ToasterMessagesLandlord
                .VerifyMessageBrandNameHasBeenSaveddSuccessfully();
            EnterBrandNameNoyoPropertiesNYC();
            ClickSaveBtnForChangeBrandNameInputField();
            Pages.ToasterMessagesLandlord
                .VerifyMessageBrandNameHasBeenSaveddSuccessfully();
            EnterOwnerName();
            EnterCompanyFullLegalName();
            EnterAddress();
            EnterPhoneNumber();
            ClickSaveBtnForDisclosureInformationSection();
            Pages.ToasterMessagesLandlord
                .VerifyMessageDisclosureЫavedЫuccessfully();

            return this;
        }
    }
}
