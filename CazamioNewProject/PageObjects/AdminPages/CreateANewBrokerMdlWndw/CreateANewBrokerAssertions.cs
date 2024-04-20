using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [AllureStep("VerifyTitleCreateNewBroker")]
        public CreateANewBrokerMdlWndw VerifyTitleCreateNewBroker()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateNewBroker));

            return this;
        }
    }
}
