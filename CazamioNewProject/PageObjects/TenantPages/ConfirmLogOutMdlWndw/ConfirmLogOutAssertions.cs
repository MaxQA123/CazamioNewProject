using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.ConfirmLogOutMdlWndw
{
    public partial class ConfirmLogOutMdlWndw
    {
        [AllureStep("VerifyTitle")]
        public ConfirmLogOutMdlWndw VerifyTitle()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAreYouSureThatYouWantToLogOut));

            return this;
        }
    }
}
