using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class SidebarLandlord
    {
        BasicDataForProject basicDataForProject = BasicDataForProject.Generate();
        SuperAdmin superAdmin = SuperAdmin.Generate();
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
        Broker broker = Broker.Generate();
        Agent agent = Agent.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();

        #region UploadImage

        [AllureStep("UploadLogoMarketplace")]
        public SidebarLandlord UploadLogoMarketplace()
        {
            WaitUntil.CustomElementIsVisible(UploadLogoMarketplaceBtn);
            WaitUntil.CustomElementIsClickable(UploadLogoMarketplaceBtn);
            UploadLogoMarketplaceBtn.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.LOGO_IMG_ADMIN_FIRST));
            return this;
        }

        [AllureStep("UploadImageAvatar")]
        public SidebarLandlord UploadImageAvatar()
        {
            WaitUntil.WaitSomeInterval(1000);
            IconBtnForUploadImageAvatar.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadImages.AVATAR_IMG_ADMIN_SECOND));
            return this;
        }

        [AllureStep("DeleteImageAvatar")]
        public SidebarLandlord DeleteImageAvatar()
        {
            Button.Click(IconBtnForDeleteImageAvatar);

            return this;
        }

        private static IWebElement _element;

        [AllureStep("SelectorItemsOnSidebar")]
        public static IList<IWebElement> SelectorItemsOnSidebar(string _locationItemSidebar)
        {
            WaitUntil.WaitSomeInterval(1000);
            var str = "//aside[@class= 'aside-container']";
            _element = Browser._Driver.FindElement(By.XPath(str));
            return _element.FindElements(By.XPath($".//ul[@class= 'sidebar-nav']//li//a[contains(@href, '{_locationItemSidebar}')]"));
        }

        [AllureStep("SelectItemsOnSidebar")]
        public SidebarLandlord SelectItemsOnSidebar(int item, string locationItemSidebar)
        {
            WaitUntil.WaitSomeInterval(1000);
            IList<IWebElement> _item = SelectorItemsOnSidebar(locationItemSidebar);

            _item[item].Click();

            return this;
        }

        #endregion

        [AllureStep("Click Button Dashboard")]
        public SidebarLandlord ClickButtonDashboard()
        {
            WaitUntil.CustomElementIsVisible(ButtonDashboardSidebar);
            Button.Click(ButtonDashboardSidebar);

            return this;
        }

        [AllureStep("Click Button Buildings")]
        public SidebarLandlord ClickButtonBuildings()
        {
            WaitUntil.CustomElementIsVisible(ButtonBuildingsSidebar);
            Button.Click(ButtonBuildingsSidebar);

            return this;
        }

        [AllureStep("Click Button Apartments")]
        public SidebarLandlord ClickButtonApartments()
        {
            WaitUntil.CustomElementIsVisible(ButtonApartmentsSidebar);
            Button.Click(ButtonApartmentsSidebar);

            return this;
        }

        [AllureStep("Click Button Applications")]
        public SidebarLandlord ClickButtonApplications()
        {
            WaitUntil.CustomElementIsVisible(ButtonApplicationsSidebar);
            Button.Click(ButtonApplicationsSidebar);

            return this;
        }

        [AllureStep("Click Button Brokers")]
        public SidebarLandlord ClickButtonBrokers()
        {
            WaitUntil.CustomElementIsVisible(ButtonBrokersSidebar);
            Button.Click(ButtonBrokersSidebar);

            return this;
        }

        [AllureStep("Click Button Marketplace Admins")]
        public SidebarLandlord ClickButtonMarketplaceAdmins()
        {
            WaitUntil.CustomElementIsVisible(ButtonMarketplaceAdminsSidebar);
            Button.Click(ButtonMarketplaceAdminsSidebar);

            return this;
        }

        [AllureStep("Click Button Lease Sign Documents")]
        public SidebarLandlord ClickButtonLeaseSignDocuments()
        {
            WaitUntil.CustomElementIsVisible(ButtonLeaseSignDocumentsSidebar);
            Button.Click(ButtonLeaseSignDocumentsSidebar);

            return this;
        }

        [AllureStep("Click Button Payment Settings")]
        public SidebarLandlord ClickButtonPaymentSettings()
        {
            WaitUntil.CustomElementIsVisible(ButtonPaymentSettingsSidebar);
            Button.Click(ButtonPaymentSettingsSidebar);

            return this;
        }

        [AllureStep("Click Button Transactions")]
        public SidebarLandlord ClickButtonTransactions()
        {
            WaitUntil.CustomElementIsVisible(ButtonTransactionsSidebar);
            Button.Click(ButtonTransactionsSidebar);

            return this;
        }

        [AllureStep("Click Button Commissions")]
        public SidebarLandlord ClickButtonCommissions()
        {
            WaitUntil.CustomElementIsVisible(ButtonCommissionsSidebar);
            Button.Click(ButtonCommissionsSidebar);

            return this;
        }

        [AllureStep("Click Button Agents")]
        public SidebarLandlord ClickButtonAgents()
        {
            WaitUntil.CustomElementIsVisible(ButtonAgentsSidebar);
            Button.Click(ButtonAgentsSidebar);

            return this;
        }

        [AllureStep("Click Button Owners")]
        public SidebarLandlord ClickButtonOwners()
        {
            WaitUntil.CustomElementIsVisible(ButtonOwnersSidebar);
            Button.Click(ButtonOwnersSidebar);

            return this;
        }

        [AllureStep("Click Button Marketplace")]
        public SidebarLandlord ClickButtonMarketplace()
        {
            WaitUntil.CustomElementIsVisible(ButtonMarketplaceSidebar);
            Button.Click(ButtonMarketplaceSidebar);

            return this;
        }

        [AllureStep("Click Button Reports")]
        public SidebarLandlord ClickButtonReports()
        {
            WaitUntil.CustomElementIsVisible(ButtonReportsAdminsSidebar);
            Button.Click(ButtonReportsAdminsSidebar);

            return this;
        }

        [AllureStep("Click Button Leads")]
        public SidebarLandlord ClickButtonLeads()
        {
            WaitUntil.CustomElementIsVisible(ButtonReportsAdminsSidebar);
            Button.Click(ButtonLeadsSidebar);

            return this;
        }

        [AllureStep("Click Button Log Out")]
        public SidebarLandlord ClickButtonLogOutSidebar()
        {
            WaitUntil.CustomElementIsVisible(ButtonLogOutSidebar);
            Button.Click(ButtonLogOutSidebar);

            return this;
        }

        [AllureStep("Click Button Buildings for SuperAdmin")]
        public SidebarLandlord ClickButtonBuildingsForSuperAdmin()
        {
            Button.Click(ButtonBuildingsSidebarForSuperAdmin);

            return this;
        }

        [AllureStep("Get User Name from SideBar")]
        public string GetUserNameFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameOfSidebar);
            string getUserName = UserNameOfSidebar.Text;
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }

        [AllureStep("Get User Name Role from SideBar")]
        public string GetUserNameRoleFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameRoleOfSidebar);
            string getUserNameRole = UserNameRoleOfSidebar.Text;
            string getUserNameRoleActual = getUserNameRole.ToString();

            return getUserNameRoleActual;
        }
    }
}
