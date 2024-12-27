using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects.AdminPages.SidebarPage;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        SuperAdmin superAdmin = new SuperAdmin().Generate();
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
        Broker broker = Broker.Generate();
        Agent agent = Agent.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();

        [AllureStep("ClickIconShow")]
        public LogInLandlord ClickIconShow()
        {
            Button.Click(IconShowLogInPg);

            return this;
        }

        [AllureStep("ClickButtonLetsGo")]
        public LogInLandlord ClickButtonLetsGo()
        {
            Button.Click(ButtonLetsGoLogInPg);

            return this;
        }
    }
}
