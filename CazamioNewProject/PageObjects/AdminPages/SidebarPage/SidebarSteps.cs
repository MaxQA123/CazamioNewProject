using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class SidebarLandlord
    {
        [AllureStep("Changing user image and Logo Marketplace of MA")]
        public SidebarLandlord ChangingImagesUserAndLogoMarketplaceOfMA()
        {
            WaitUntil.CustomElementIsVisible(UploadLogoMarketplaceBtn);
            WaitUntil.CustomElementIsClickable(UploadLogoMarketplaceBtn);
            UploadLogoMarketplaceBtn.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
                .VerifyChangingLogoImageLandlord();
            UploadLogoMarketplaceBtn.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_SECOND));
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
               .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ChangingImageUserOfBroker")]
        public SidebarLandlord ChangingImageUserOfBroker()
        {
            WaitUntil.CustomElementIsVisible(IconBtnForUploadImageAvatar);
            WaitUntil.CustomElementIsClickable(IconBtnForUploadImageAvatar);
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
               .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            Pages.ToasterMessagesLandlord
                .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ChangingImageUserOfAgentBroker")]
        public SidebarLandlord ChangingImageUserOfAgentBroker()
        {
            WaitUntil.CustomElementIsVisible(IconBtnForUploadImageAvatar);
            WaitUntil.CustomElementIsClickable(IconBtnForUploadImageAvatar);
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
               .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            Pages.ToasterMessagesLandlord
                .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ChangingImageUserOfAgent")]
        public SidebarLandlord ChangingImageUserOfAgent()
        {
            WaitUntil.CustomElementIsVisible(IconBtnForUploadImageAvatar);
            WaitUntil.CustomElementIsClickable(IconBtnForUploadImageAvatar);
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
               .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            Pages.ToasterMessagesLandlord
                .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("ChangingImageUserOfSuperAdmin")]
        public SidebarLandlord ChangingImageUserOfSuperAdmin()
        {
            WaitUntil.CustomElementIsVisible(IconBtnForUploadImageAvatar);
            WaitUntil.CustomElementIsClickable(IconBtnForUploadImageAvatar);
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_FIRST));
            Pages.ToasterMessagesLandlord
               .VerifyChangingAvatarImageLandlord();
            Button.Click(IconBtnForDeleteImageAvatar);
            Pages.ToasterMessagesLandlord
                .VerifyRewmoveAvatarImageLandlord();

            return this;
        }

        [AllureStep("Click All Tabs")]
        public SidebarLandlord ClickingAllTabsOfMA()
        {
            ClickButtonBuildings();
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            ClickButtonApartments();
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            ClickButtonApplications();
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            ClickButtonBrokers();
            Pages.ListOfBrokers
                .VerifyTitleListOfBrokersPg();
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            ClickButtonLeaseSignDocuments();
            Pages.Templates
                .VerifyTitleTemplatesPage();
            ButtonPaymentSettingsSidebar.SendKeys("");
            ClickButtonPaymentSettings();
            Pages.PaymentSettings
                .VerifyTitlePaymentSettingsPage();
            ButtonTransactionsSidebar.SendKeys("");
            ClickButtonTransactions();
            Pages.ListOfTransactions
                .VerifyTitleTransactionsPg();
            ClickButtonLeads();
            Pages.ListOfLeads
                .VerifyTitleLeads();
            ButtonCommissionsSidebar.SendKeys("");
            ClickButtonCommissions();
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();
            ButtonAgentsSidebar.SendKeys("");
            ClickButtonAgents();
            Pages.ListOfAgents
                .VerifyTitleAgentsPg();
            ButtonOwnersSidebar.SendKeys("");
            ClickButtonOwners();
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            ButtonMarketplaceSidebar.SendKeys("");
            ClickButtonMarketplace();
            Pages.Marketplace
                .VerifyTitleMarketplacePg();
            ClickButtonReports();
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

        [AllureStep("ClickingAllTabsOfAgentBroker")]
        public SidebarLandlord ClickingAllTabsOfAgentBroker()
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
            Button.Click(ButtonCommissionsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();

            return this;
        }

        [AllureStep("ClickingAllTabsOfAgent")]
        public SidebarLandlord ClickingAllTabsOfAgent()
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
            Button.Click(ButtonCommissionsSidebar);
            WaitUntil.WaitSomeInterval(1000);
            Pages.ListOfCommissions
                .VerifyTitleListOfCommissions();

            return this;
        }

        [AllureStep("ClickingAllTabsOfSuperAdmin")]
        public SidebarLandlord ClickingAllTabsOfSuperAdmin()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonApartmentsSidebarForSuperAdmin);
            Pages.ListOfApartments
                .VerifyTitleListOfApartments();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonBuildingsSidebarForSuperAdmin);
            Pages.ListOfBuildings
                .VerifyTitleListOfBuildings();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonApplicationsSidebarForSuperAdmin);
            WaitUntil.WaitSomeInterval(500);
            Pages.ListOfApplications
                .VerifyTitleListOfApplications();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonMarketplaceAdminsSidebarForSuperAdmin);
            WaitUntil.WaitSomeInterval(500);
            Pages.ListOfMarketplaceAdmins
                .VerifyTitleListOfMarketplaceAdmins();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebarForSuperAdmin);
            WaitUntil.WaitSomeInterval(500);
            Pages.ListOfOwners
                .VerifyTitleListOfOwnersPg();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonVisitLogsSidebarForSuperAdmin);
            Pages.VisitLogs
                .VerifyTitleVisitLogsPg();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAddressManagerSidebarForSuperAdmin);
            Pages.AddressManager
                .VerifyTitleAddressManagerPg();
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonUsersSidebarForSuperAdmin);
            Pages.ListOfUsers
                .VerifyTitleListOfUsersPg();

            return this;
        }
    }
}
