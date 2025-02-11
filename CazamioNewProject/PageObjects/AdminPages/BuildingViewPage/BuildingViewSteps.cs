using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingViewPage
{
    public partial class BuildingView
    {
        [AllureStep("UpdateValueCreditScreeningFee")]
        public BuildingView UpdateValueCreditScreeningFee()
        {
            WaitUntil.CustomElementIsVisible(ButtonEditOfCreditScreeningFee);
            WaitUntil.CustomElementIsClickable(ButtonEditOfCreditScreeningFee);
            Button.Click(ButtonEditOfCreditScreeningFee);
            WaitUntil.CustomElementIsVisible(FieldInputCreditScreeningFee);
            InputGeneral.InputFunctionWithClear(FieldInputCreditScreeningFee, building.MySpaceAmountPayments.CreditScreeningOne);
            Button.Click(ButtonSaveOfCreditScreeningFee);
            Pages.ToasterMessagesLandlord
                .VerifMessageScreeningFeeSaved();

            return this;
        }
    }
}
