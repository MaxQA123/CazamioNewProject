using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System.Diagnostics;

namespace CazamioNewProject.GuiHelpers
{
    public class AllureServe
    {
        [Test]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Perevalov Maksim")]
        [AllureSuite("WebSite")]
        [AllureSubSuite("Client")]


        public void GoToAllureResults()
        {
            AllureConfigFilesHelper.CreateBatFile();
            Process.Start(Browser.RootPath() + "allure serve.bat");
        }
    }
}
