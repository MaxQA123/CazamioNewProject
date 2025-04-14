using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameChangeYourPasswordMdlWndw
{
    public partial class PleaseTellUsYourNameChangeYourPasswordMdlWndw
    {
        [AllureStep("VerifyTitlePleaseTellUsYourNameAndChangeYourPassword")]
        public PleaseTellUsYourNameChangeYourPasswordMdlWndw VerifyTitlePleaseTellUsYourNameAndChangeYourPassword()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitlePleaseTellUsYourNameAndChangeYourPassword));

            return this;
        }
    }
}
