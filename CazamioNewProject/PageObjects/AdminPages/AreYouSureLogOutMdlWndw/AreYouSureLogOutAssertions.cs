using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureLogOutMdlWndw
{
    public partial class AreYouSureLogOutLandlordMdlWndw
    {
        [AllureStep("VerifyTitleAreYouSureMdlwndw")]
        public AreYouSureLogOutLandlordMdlWndw VerifyTitleAreYouSureMdlwndw()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAreYouSureMdlwndw));

            return this;
        }
    }
}
