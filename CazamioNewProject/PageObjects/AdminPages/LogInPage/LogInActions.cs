using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        SuperAdmin superAdmin = SuperAdmin.Generate();
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
        Broker broker = Broker.Generate();
        Agent agent = Agent.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();

        [AllureStep("ClickIconShow")]
        public LogInLandlord ClickIconShow()
        {
            Button.Click(IconShow);

            return this;
        }

        [AllureStep("ClickButtonLetsGo")]
        public LogInLandlord ClickButtonLetsGo()
        {
            Button.Click(ButtonLetsGo);

            return this;
        }

        [AllureStep("ClickLinkForgotPassword")]
        public LogInLandlord ClickLinkForgotPassword()
        {
            Button.Click(LinkForgotPassword);

            return this;
        }
    }
}
