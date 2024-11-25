using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects.AdminPages.SidebarPage;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        SuperAdmin superAdmin = new SuperAdmin().Generate();
        MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();
        Broker broker = new Broker().Generate();
        Agent agent = new Agent().Generate();
        AgentBroker agentBroker = new AgentBroker().Generate();

        [AllureStep("ClickIconShow")]
        public LogInLandlord ClickIconShow()
        {
            Button.Click(IconShowLogInPg);

            return this;
        }

        [AllureStep("ClickButtonLetsGo")]
        public LogInLandlord ClickButtonLetsGo()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonLetsGoLogInPg);
            WaitUntil.CustomElementIsVisible(SidebarLandlord.UserNameOfSidebar);

            return this;
        }
    }
}
