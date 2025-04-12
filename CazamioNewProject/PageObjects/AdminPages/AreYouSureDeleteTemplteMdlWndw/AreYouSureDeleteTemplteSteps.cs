using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.AreYouSureDeleteTemplteMdlWndw
{
    public partial class AreYouSureDeleteTemplteMdlWndw
    {
        [AllureStep("ConfirmDeleteTemplate")]
        public AreYouSureDeleteTemplteMdlWndw ConfirmDeleteTemplate()
        {
            VerifyTitleAreYouSure();
            VerifySubTitleAreYouSureYouWantDeleteTemplate();
            Button.Click(DeleteBtn);
            Pages.ToasterMessagesLandlord
                .VerifyMessageTemplateWasDeleted();

            return this;
        }
    }
}
