using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [AllureStep("Verify Title Create New Broker modal window")]
        public CreateANewBrokerMdlWndw VerifyTitleCreateNewBroker()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleCreateNewBroker));

            return this;
        }
    }
}
