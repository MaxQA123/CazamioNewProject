using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.LeasePriceAdjustmentMdlWndw
{
    public partial class LeasePriceAdjustmentMdlWndw
    {
        [AllureStep("ClickSaveBtn")]
        public LeasePriceAdjustmentMdlWndw ClickSaveBtn()
        {
            WaitUntil.CustomElementIsClickable(SaveBtn);
            Button.Click(SaveBtn);
            Pages.ToasterMessagesTenants
                .VerifyMessageThirdLeasePriceWasAgreedOnSuccessfully();


            return this;
        }

        [AllureStep("ClickCancelBtn")]
        public LeasePriceAdjustmentMdlWndw ClickCancelBtn()
        {
            WaitUntil.CustomElementIsClickable(CancelBtn);
            Button.Click(CancelBtn);


            return this;
        }
    }
}
