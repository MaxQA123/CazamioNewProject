using CazamioNewProject.GuiHelpers;
using CazamioNewProject.GuiHelpers.BasicTests;
using NUnit.Framework;

namespace AgentBrokerGui
{
    public class AgentBrokerBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_LOGIN_ADMIN_WEBSITE);
        }
    }
}
