using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace CazamioNewProject.GuiHelpers.BasicTests
{
    public class BaseGui
    {
        [OneTimeSetUp]
        public void DobeforeAllTheTests()
        {

        }

        [OneTimeTearDown]
        public void DoAfterAllTheTests()
        {
            Browser.Quit();

            ForceCloseDriver.ForceClose();
        }

        [TearDown]
        public void DoAfterEach()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ScreenShot.MakeScreenShot();
                Browser.Close();
            }
            else if (Browser._Driver != null)
            {
                Browser.Close();
            }

        }
    }
}
