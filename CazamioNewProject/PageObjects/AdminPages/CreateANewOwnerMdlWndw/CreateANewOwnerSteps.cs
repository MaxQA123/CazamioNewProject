using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.Create_ANewOwnerMdlWndw
{
    public partial class CreateANewOwnerMdlWndw
    {
        [AllureStep("SelectBroker")]
        public CreateANewOwnerMdlWndw SelectBroker()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSelectUser);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemBrokerUser);
            //KeyBoardActions.ClickEnterButton();

            return this;
        }

        [AllureStep("SelectAgent")]
        public CreateANewOwnerMdlWndw SelectAgent()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonSelectUser);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemAgentUser);

            return this;
        }

        [AllureStep("EnterPhoneExtensionNumbersFull")]
        public CreateANewOwnerMdlWndw EnterPhoneExtensionNumbersFull()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, owner.PhoneNumber.BasicFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNumber, owner.PhoneNumber.ExtensionFirst);

            return this;
        }

        [AllureStep("EnterPhoneExtensionNumbers")]
        public CreateANewOwnerMdlWndw EnterPhoneExtensionNumbers()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, owner.PhoneNumber.BasicSecond);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNumber, owner.PhoneNumber.ExtensionSecond);

            return this;
        }

        [AllureStep("SwitchingItemsPays")]
        public CreateANewOwnerMdlWndw SwitchingItemsPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerAndTenantPays);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemTenantPays);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ItemOwnerPays);

            return this;
        }

        [AllureStep("SelectItemTenantPays")]
        public CreateANewOwnerMdlWndw SelectItemTenantPays()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);
            WaitUntil.CustomElementIsVisible(ItemTenantPays);
            WaitUntil.CustomElementIsClickable(ItemTenantPays);
            Button.Click(ItemTenantPays);

            return this;
        }

        [AllureStep("EnterDataOwnerAndTenantPaysMin")]
        public CreateANewOwnerMdlWndw EnterDataOwnerAndTenantPaysMin()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, owner.CommissionStructure.OwnerNumberOfMonthsMin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, owner.CommissionStructure.TenantNumberOfMonthsMin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerPercentage, owner.CommissionStructure.OwnerPercentageMin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantPercentage, owner.CommissionStructure.TenantPercentageMin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.CommissionStructure.TakeOffMin);

            return this;
        }

        [AllureStep("EnterDataTenantPaysMax")]
        public CreateANewOwnerMdlWndw EnterDataTenantPaysMax()
        {
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, owner.CommissionStructure.TenantNumberOfMonthsMax);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.CommissionStructure.TakeOffMax);

            return this;
        }

        [AllureStep("EnterDataOwnerPays")]
        public CreateANewOwnerMdlWndw EnterDataOwnerPays()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, owner.CommissionStructure.OwnerNumberOfMonthsStatic);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.CommissionStructure.TakeOffStatic);

            return this;
        }

        [AllureStep("EnterFullDataMgmt")]
        public CreateANewOwnerMdlWndw EnterFullDataMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, owner.OwnerName.FirstLastNameRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtEmail, owner.OwnerEmail.xitroo);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMgmt, owner.PhoneNumber.BasicFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtExtensionNumber, owner.PhoneNumber.ExtensionFirst);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtOfficeLocation, owner.OfficeLocation.Dallas);

            return this;
        }
    }
}
