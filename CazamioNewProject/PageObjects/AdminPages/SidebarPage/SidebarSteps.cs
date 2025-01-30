using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class SidebarLandlord
    {
        [AllureStep("ChangingImagesUserAndLogoMarketplaceOfMA")]
        public SidebarLandlord ChangingImagesUserAndLogoMarketplaceOfMA()
        {
            WaitUntil.CustomElementIsVisible(ButtonUploadLogoOfLandlord);
            WaitUntil.CustomElementIsClickable(ButtonUploadLogoOfLandlord);
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_FIRST));
            Pages.ToasterMessages
                .VerifyChangingLogoImageLandlord();
            ButtonUploadLogoOfLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_SECOND));
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessages
               .VerifyChangingAvatarImageLandlord();
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            Pages.ToasterMessages
                .VerifyChangingAvatarImageLandlord();
            Button.Click(linkRemovePhotoOfLandlord);
            Pages.ToasterMessages
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ChangingImagesUserAndLogoMarketplaceOfBroker")]
        public SidebarLandlord ChangingImagesUserAndLogoMarketplaceOfBroker()
        {
            WaitUntil.CustomElementIsVisible(ButtonUploadPhotoOfAvatarLandlord);
            WaitUntil.CustomElementIsClickable(ButtonUploadPhotoOfAvatarLandlord);
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessages
               .VerifyChangingAvatarImageLandlord();
            ButtonUploadPhotoOfAvatarLandlord.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            Pages.ToasterMessages
                .VerifyChangingAvatarImageLandlord();
            Button.Click(linkRemovePhotoOfLandlord);
            Pages.ToasterMessages
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ClickingAllTabsOfMA")]
        public SidebarLandlord ClickingAllTabsOfMA()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonBuildingsSidebar);
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonApartmentsSidebar);
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonApplicationsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonBrokersSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg();
            WaitUntil.WaitSomeInterval(1000);
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLeaseSignDocumentsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.Templates
                .VerifyTitleTemplatesPage();
            WaitUntil.WaitSomeInterval(1000);
            ButtonPaymentSettingsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonPaymentSettingsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.PaymentSettings
                .VerifyTitlePaymentSettingsPage();
            WaitUntil.WaitSomeInterval(1000);
            ButtonTransactionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonTransactionsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLeadsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfLeads
                .VerifyTitleLeads();
            WaitUntil.WaitSomeInterval(1000);
            ButtonCommissionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCommissionsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();
            WaitUntil.WaitSomeInterval(1000);
            ButtonAgentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAgentsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfAgents
                .VerifyTitleAgentsPg();
            WaitUntil.WaitSomeInterval(1000);
            ButtonOwnersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            WaitUntil.WaitSomeInterval(1000);
            ButtonMarketplaceSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonMarketplaceSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.Marketplace
                .VerifyTitleMarketplacePg();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonReportsAdminsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.Reports
                .VerifyTitleReportsPage();

            return this;
        }

        [AllureStep("ClickingAllTabsOfBroker")]
        public SidebarLandlord ClickingAllTabsOfBroker()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonDashboardSidebar);
            Pages.Dashboard
                .VerifyTitleOfDashboardPg();
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonBuildingsSidebar);
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonApartmentsSidebar);
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonApplicationsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            WaitUntil.WaitSomeInterval(1000);
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLeaseSignDocumentsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.Templates
                .VerifyTitleTemplatesPage();
            WaitUntil.WaitSomeInterval(1000);
            ButtonPaymentSettingsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonPaymentSettingsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.PaymentSettings
                .VerifyTitlePaymentSettingsPage();
            WaitUntil.WaitSomeInterval(1000);
            ButtonTransactionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonTransactionsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLeadsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfLeads
                .VerifyTitleLeads();
            WaitUntil.WaitSomeInterval(1000);
            ButtonOwnersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();

            return this;
        }
    }
}
