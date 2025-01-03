using CazamioNewProject.GuiHelpers;
using CazamioNewProject.GuiHelpers.BasicTests;
using NUnit.Framework;

namespace TenantsJrzeeCriticalFlow
{
    public class TenantsJrzeeBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_TENANT_MARKET_JRZEE);
        }
    }
}
