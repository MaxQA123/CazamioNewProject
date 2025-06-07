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

        [AllureStep("ClickButtonDashboard")]
        public SidebarLandlord ClickButtonDashboard()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonDashboardSidebar);

            return this;
        }

        [AllureStep("ClickButtonBuildings")]
        public SidebarLandlord ClickButtonBuildings()
        {
            WaitUntil.WaitSomeInterval(5000);
            Button.Click(ButtonBuildingsSidebar);

            return this;
        }

        [AllureStep("ClickButtonApartments")]
        public SidebarLandlord ClickButtonApartments()
        {
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonApartmentsSidebar);

            return this;
        }

        [AllureStep("ClickButtonApplications")]
        public SidebarLandlord ClickButtonApplications()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonApplicationsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonBrokers")]
        public SidebarLandlord ClickButtonBrokers()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonBrokersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        //Hiddedn this element
        //[AllureStep("ClickButtonPreApprovalsSidebar")]
        //public SideBarLandlord ClickButtonPreApprovalsSidebar()
        //{
        //    WaitUntil.WaitSomeInterval(1000);
        //    Button.Click(ButtonPreApprovalsSidebar);
        //    WaitUntil.WaitSomeInterval(1000);

        //    return this;
        //}

        [AllureStep("ClickButtonMarketplaceAdmins")]
        public SidebarLandlord ClickButtonMarketplaceAdmins()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonMarketplaceAdminsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLeaseSignDocuments")]
        public SidebarLandlord ClickButtonLeaseSignDocuments()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonLeaseSignDocumentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLeaseSignDocumentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonPaymentSettings")]
        public SidebarLandlord ClickButtonPaymentSettings()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonPaymentSettingsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonPaymentSettingsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonTransactions")]
        public SidebarLandlord ClickButtonTransactions()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonTransactionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonTransactionsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonCommissions")]
        public SidebarLandlord ClickButtonCommissions()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonCommissionsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCommissionsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonAgents")]
        public SidebarLandlord ClickButtonAgents()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonAgentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAgentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("SwitchTabClickButtonBrokers")]
        public SidebarLandlord SwitchTabClickButtonBrokers()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);
            ButtonAgentsSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonAgentsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonOwners")]
        public SidebarLandlord ClickButtonOwners()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonOwnersSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonOwnersSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonMarketplace")]
        public SidebarLandlord ClickButtonMarketplace()
        {
            WaitUntil.WaitSomeInterval(1000);
            ButtonMarketplaceSidebar.SendKeys("");
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonMarketplaceSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonReports")]
        public SidebarLandlord ClickButtonReports()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonReportsAdminsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLeads")]
        public SidebarLandlord ClickButtonLeads()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLeadsSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonLogOutSidebar")]
        public SidebarLandlord ClickButtonLogOutSidebar()
        {
            WaitUntil.WaitSomeInterval(1000);
            Button.Click(ButtonLogOutSidebar);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }

        [AllureStep("ClickButtonBuildingsForSuperAdmin")]
        public SidebarLandlord ClickButtonBuildingsForSuperAdmin()
        {
            Button.Click(ButtonBuildingsSidebarForSuperAdmin);

            return this;
        }

        [AllureStep("GetUserNameFromSideBar")]
        public string GetUserNameFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameOfSidebar);
            string getUserName = UserNameOfSidebar.Text;
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }

        [AllureStep("GetUserNameRoleFromSideBar")]
        public string GetUserNameRoleFromSideBar()
        {
            WaitUntil.CustomElementIsVisible(UserNameRoleOfSidebar);
            string getUserNameRole = UserNameRoleOfSidebar.Text;
            string getUserNameRoleActual = getUserNameRole.ToString();

            return getUserNameRoleActual;
        }

        //[AllureStep("MakeLogOut")]
        //public SidebarLandlord MakeLogOut()
        //{
        //    WaitUntil.WaitSomeInterval(1000);
        //    Button.Click(ButtonLogOutSidebar);
        //    WaitUntil.WaitSomeInterval(1000);

        //    Pages.AreYouSureLogOutLandlord
        //        .ClickButtonYesIAmSure();

        //    return this;
        //}
    }
}
