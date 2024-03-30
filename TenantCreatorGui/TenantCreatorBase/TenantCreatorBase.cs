using CazamioNewProject.GuiHelpers;
using CazamioNewProject.GuiHelpers.BasicTests;
using NUnit.Framework;

namespace TenantCreatorGui
{
    public class TenantCreatorBase : BaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialize();

            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_TENANT_MARKET_MYSPACE);
        }
    }
}
