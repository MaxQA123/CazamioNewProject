using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.ConfirmLogOutMdlWndw
{
    public partial class ConfirmLogOutMdlWndw
    {
        [AllureStep("ConmfirmLogOut")]
        public ConfirmLogOutMdlWndw ConmfirmLogOut()
        {
            VerifyTitle();
            Button.Click(BtnYesIamSure);

            return this;
        }
    }
}
