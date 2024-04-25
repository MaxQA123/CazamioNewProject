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
            KeyBoardActions.ClickEnterButton();

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

        [AllureStep("EnterPhoneExtensionNumbers")]
        public CreateANewOwnerMdlWndw EnterPhoneExtensionNumbers()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, owner.PhoneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputExtensionNumber, owner.ExtensionNumber);

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

        [AllureStep("EnterDataOwnerAndTenantPays")]
        public CreateANewOwnerMdlWndw EnterDataOwnerAndTenantPays()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, owner.OwnerNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, owner.TenantNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerPercentage, owner.OwnerPercentage);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTenantPercentage, owner.TenantPercentage);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.TakeOff);

            return this;
        }

        [AllureStep("EnterDataTenantPays")]
        public CreateANewOwnerMdlWndw EnterDataTenantPays()
        {
            InputGeneral.InputFunctionWithClear(FieldInputTenantNumberOfMonths, owner.TenantNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.TakeOff);

            return this;
        }

        [AllureStep("EnterDataOwnerPays")]
        public CreateANewOwnerMdlWndw EnterDataOwnerPays()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerNumberOfMonths, owner.OwnerNumberOfMonths);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputTakeOff, owner.TakeOff);

            return this;
        }

        [AllureStep("EnterFullDataMgmt")]
        public CreateANewOwnerMdlWndw EnterFullDataMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, owner.FullName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtEmail, owner.EmailAddress);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumberMgmt, owner.PhoneNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtExtensionNumber, owner.ExtensionNumber);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtOfficeLocation, owner.OfficeLocation);

            return this;
        }

        [AllureStep("EnterMandatoryDataMgmt")]
        public CreateANewOwnerMdlWndw EnterMandatoryDataMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, owner.FullName);

            return this;
        }
    }
}
