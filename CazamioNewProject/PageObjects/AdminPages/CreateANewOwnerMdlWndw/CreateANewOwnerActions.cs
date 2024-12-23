using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.Create_ANewOwnerMdlWndw
{
    public partial class CreateANewOwnerMdlWndw
    {
        Owner owner = Owner.Generate();

        [AllureStep("EnterCompanyNameOneLetter")]
        public CreateANewOwnerMdlWndw EnterCompanyNameOneLetter()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyName.OneLetter);

            return this;
        }

        [AllureStep("EnterCompanyNameAgentMaxSymbols")]
        public CreateANewOwnerMdlWndw EnterCompanyNameAgentMaxSymbols()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyName.AssignedAgentMaxSymbols);

            return this;
        }

        [AllureStep("EnterCompanyNameBrokerMaxSymbols")]
        public CreateANewOwnerMdlWndw EnterCompanyNameBrokerMaxSymbols()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyName.AssignedBrokerMaxSymbols);

            return this;
        }

        [AllureStep("EnterOwnerFirstName")]
        public CreateANewOwnerMdlWndw EnterOwnerFirstName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, owner.OwnerName.FirstNameRandom);

            return this;
        }

        [AllureStep("EnterOwnerFirstLastName")]
        public CreateANewOwnerMdlWndw EnterOwnerFirstLastName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, owner.OwnerName.FirstLastNameRandom);

            return this;
        }

        [AllureStep("EnterOwnerEmaiLGmail")]
        public CreateANewOwnerMdlWndw EnterOwnerEmaiLGmail()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, owner.OwnerEmail.gmail);

            return this;
        }

        [AllureStep("EnterOwnerEmaiLYahoo")]
        public CreateANewOwnerMdlWndw EnterOwnerEmaiLYahoo()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, owner.OwnerEmail.yahoo);

            return this;
        }

        [AllureStep("EnterOwnerEmaiLXitroo")]
        public CreateANewOwnerMdlWndw EnterOwnerEmaiLXitroo()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, owner.OwnerEmail.xitroo);

            return this;
        }

        [AllureStep("EnterOfficeLocationWashington")]
        public CreateANewOwnerMdlWndw EnterOfficeLocationWashington()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, owner.OfficeLocation.Washington);

            return this;
        }

        [AllureStep("EnterOfficeLocationNewYork")]
        public CreateANewOwnerMdlWndw EnterOfficeLocationNewYork()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, owner.OfficeLocation.NewYork);

            return this;
        }

        [AllureStep("EnterOfficeLocationDallas")]
        public CreateANewOwnerMdlWndw EnterOfficeLocationDallas()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, owner.OfficeLocation.Dallas);

            return this;
        }

        [AllureStep("EnterInternalNotesShort")]
        public CreateANewOwnerMdlWndw EnterInternalNotesShort()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, owner.InternalNotes.Short);

            return this;
        }

        [AllureStep("EnterInternalNotesLong")]
        public CreateANewOwnerMdlWndw EnterInternalNotesLong()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, owner.InternalNotes.Long);

            return this;
        }

        [AllureStep("ClickButtonAddPhoneNumber")]
        public CreateANewOwnerMdlWndw ClickButtonAddPhoneNumber()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddPhoneNumber);

            return this;
        }

        [AllureStep("EnterPhoneNumber")]
        public CreateANewOwnerMdlWndw EnterPhoneNumber()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, owner.PhoneNumber.BasicSecond);

            return this;
        }

        [AllureStep("ClickButtonAddCommissionStructure")]
        public CreateANewOwnerMdlWndw ClickButtonAddCommissionStructure()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddCommissionStructure);

            return this;
        }

        [AllureStep("ClickButtonPayType")]
        public CreateANewOwnerMdlWndw ClickButtonPayType()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonPayType);

            return this;
        }

        [AllureStep("SelectItemOwnerAndTenantPays")]
        public CreateANewOwnerMdlWndw SelectItemOwnerAndTenantPays()
        {
            WaitUntil.CustomElementIsVisible(ItemOwnerAndTenantPays);
            WaitUntil.CustomElementIsClickable(ItemOwnerAndTenantPays);
            Button.Click(ItemOwnerAndTenantPays);

            return this;
        }

        //[AllureStep("SelectItemTenantPays")]
        //public CreateANewOwnerMdlWndw SelectItemTenantPays()
        //{
        //    WaitUntil.CustomElementIsVisible(ItemTenantPays);
        //    WaitUntil.CustomElementIsClickable(ItemTenantPays);
        //    Button.Click(ItemTenantPays);

        //    return this;
        //}

        [AllureStep("SelectItemOwnerPays")]
        public CreateANewOwnerMdlWndw SelectItemOwnerPays()
        {
            WaitUntil.CustomElementIsVisible(ItemOwnerPays);
            WaitUntil.CustomElementIsClickable(ItemOwnerPays);
            Button.Click(ItemOwnerPays);

            return this;
        }

        [AllureStep("ClickButtonAddMgmt")]
        public CreateANewOwnerMdlWndw ClickButtonAddMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddMgmt);

            return this;
        }

        [AllureStep("EnterMandatoryDataMgmt")]
        public CreateANewOwnerMdlWndw EnterMandatoryDataMgmt()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMgmtName, owner.OwnerName.FirstLastNameRandom);

            return this;
        }

        [AllureStep("ScrollDown")]
        public CreateANewOwnerMdlWndw ScrollDown()
        {
            WaitUntil.WaitSomeInterval(100);
            JScriptExecutor.ScrollToElement(ButtonAddMgmt);

            return this;
        }

        [AllureStep("ClickButtonCreate")]
        public CreateANewOwnerMdlWndw ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCreate);

            return this;
        }
    }
}
