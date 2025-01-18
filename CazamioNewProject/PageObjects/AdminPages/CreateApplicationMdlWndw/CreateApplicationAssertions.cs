using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        [AllureStep("VerifyTitleCreateApplication")]
        public CreateApplicationMdlWndw VerifyTitleCreateApplication()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleCreateApplication));

            return this;
        }
    }
}
