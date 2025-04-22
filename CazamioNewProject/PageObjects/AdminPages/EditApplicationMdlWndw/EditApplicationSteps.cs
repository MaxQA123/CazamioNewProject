using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        [AllureStep("EditApplicationNineNineNineEightSaintJohnsonPlace")]
        public EditApplicationMdlWndw EditApplicationNineNineNineEightSaintJohnsonPlace()
        {
            Pages.ApplicationDetail
                .ClickEditApplicationBtn();
            VerifyEditApplicationTitle();
            InputGeneral.InputFunctionWithClear(RequestedOfferPriceFieldInput, application.RequestedOfferPrice.SixthPriceStatic);
            InputGeneral.InputFunctionWithClear(LeasePriceFieldInput, application.LeasePrice.SixthPriceStatic);
            InputGeneral.InputFunctionWithClear(SecurityDepositFieldInput, application.SecurityDeposit.SixthPriceStatic);

            return this;
        }
    }
}
