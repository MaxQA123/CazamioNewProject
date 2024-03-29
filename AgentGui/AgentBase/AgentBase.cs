using CazamioNewProject.GuiHelpers;
using CazamioNewProject.GuiHelpers.BasicTests;
using NUnit.Framework;

namespace AgentGuiTests
{
    public class AgentBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_LOGIN_ADMIN_WEBSITE);
        }
    }
}