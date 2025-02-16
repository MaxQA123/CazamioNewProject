using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.LeasePriceAdjustmentMdlWndw
{
    public partial class LeasePriceAdjustmentMdlWndw
    {
        [AllureStep("ClickBtnCancel")]
        public LeasePriceAdjustmentMdlWndw ClickBtnCancel()
        {
            WaitUntil.CustomElementIsClickable(BtnCancel);
            Button.Click(BtnCancel);

            return this;
        }
    }
}
