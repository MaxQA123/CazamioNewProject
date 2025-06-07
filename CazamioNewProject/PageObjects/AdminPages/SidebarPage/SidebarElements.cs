using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.SidebarPage
{
    public partial class SidebarLandlord
    {
        [FindsBy(How = How.XPath, Using = "//div[@class= 'edit-btns']//input[@id = 'logo']")]
        public IWebElement UploadLogoMarketplaceBtn;

        [FindsBy(How = How.XPath, Using = "//app-sidebar//input[@id = 'avatar']")]
        public IWebElement IconBtnForUploadImageAvatar;

        [FindsBy(How = How.XPath, Using = "//app-sidebar//span[text() = ' delete ']")]
        public IWebElement IconBtnForDeleteImageAvatar;

        [FindsBy(How = How.XPath, Using = "//app-sidebar//div[@class = 'user-name']")]
        public IWebElement UserNameOfSidebar;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'user-role']")]
        public IWebElement UserNameRoleOfSidebar;

        #region ButtonsTabs

        [FindsBy(How = How.XPath, Using = "//a[@href= '/dashboard']")]
        public IWebElement ButtonDashboardSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/buildings']")]
        public IWebElement ButtonBuildingsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/buildings-list']")]
        public IWebElement ButtonBuildingsSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/apartments']")]
        public IWebElement ButtonApartmentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/apartments-list']")]
        public IWebElement ButtonApartmentsSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/applications']")]
        public IWebElement ButtonApplicationsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/application-list']")]
        public IWebElement ButtonApplicationsSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/marketplace-admins-list']")]
        public IWebElement ButtonMarketplaceAdminsSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/brokers']")]
        public IWebElement ButtonBrokersSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/pre-approvals']")]
        public IWebElement ButtonPreApprovalsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/lease-sign-documents']")]
        public IWebElement ButtonLeaseSignDocumentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/payment-settings/payment-view']")]
        public IWebElement ButtonPaymentSettingsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/transactions']")]
        public IWebElement ButtonTransactionsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/leads']")]
        public IWebElement ButtonLeadsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/commissions']")]
        public IWebElement ButtonCommissionsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href = '/agents']")]
        public IWebElement ButtonAgentsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/owners']")]
        public IWebElement ButtonOwnersSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/owners-list']")]
        public IWebElement ButtonOwnersSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/visit-logs']")]
        public IWebElement ButtonVisitLogsSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/address-manager']")]
        public IWebElement ButtonAddressManagerSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/users']")]
        public IWebElement ButtonUsersSidebarForSuperAdmin;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/marketplace']")]
        public IWebElement ButtonMarketplaceSidebar;

        [FindsBy(How = How.XPath, Using = "//div[@class= 'sidebar-layout']")]
        public IWebElement ButtonLogOutSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/administrator/marketplace-admins-list']")]
        public IWebElement ButtonMarketplaceAdminsSidebar;

        [FindsBy(How = How.XPath, Using = "//a[@href= '/reports']")]
        public IWebElement ButtonReportsAdminsSidebar;

        #endregion
    }
}
