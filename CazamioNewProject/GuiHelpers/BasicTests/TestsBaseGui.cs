using NUnit.Framework;

namespace CazamioNewProject.GuiHelpers.BasicTests
{
    public class TestsBaseGui
    {
        [SetUp]
        public void SetUp()
        {
            Browser._Driver.Navigate().GoToUrl(StartPoints.URL_HOME_PAGE_TENANT_WEBSITE_CAZAMIO);
        }
    }
}
