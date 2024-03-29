using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            WaitUntil.WaitSomeInterval(2000);
            Button.Click(ButtonLetsGoLogInPg);
            WaitUntil.WaitSomeInterval(1000);

            return this;
        }
    }
}
