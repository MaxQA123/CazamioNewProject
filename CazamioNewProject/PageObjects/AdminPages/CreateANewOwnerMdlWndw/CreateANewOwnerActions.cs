using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.Create_ANewOwnerMdlWndw
{
    public partial class CreateANewOwnerMdlWndw
    {
        Owner owner = Owner.Generate();

        [AllureStep("EnterCompanyNameForAgentRole")]
        public CreateANewOwnerMdlWndw EnterCompanyNameForAgentRole()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyNameWithAgent);

            return this;
        }

        [AllureStep("EnterCompanyNameForBrokerRole")]
        public CreateANewOwnerMdlWndw EnterCompanyNameForBrokerRole()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputCompanyName, owner.CompanyNameWithBroker);

            return this;
        }

        [AllureStep("EnterOwnerName")]
        public CreateANewOwnerMdlWndw EnterOwnerName()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerName, owner.FullName);

            return this;
        }

        [AllureStep("EnterOwnerEmaiL")]
        public CreateANewOwnerMdlWndw EnterOwnerEmaiL()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOwnerEmail, owner.EmailAddress);

            return this;
        }

        [AllureStep("EnterOfficeLocation")]
        public CreateANewOwnerMdlWndw EnterOfficeLocation()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputOfficeLocation, owner.OfficeLocation);

            return this;
        }

        [AllureStep("EnterInternalNotes")]
        public CreateANewOwnerMdlWndw EnterInternalNotes()
        {
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputInternalNotes, owner.InternalNotes);

            return this;
        }

        [AllureStep("ClickButtonAddPhoneNumber")]
        public CreateANewOwnerMdlWndw ClickButtonAddPhoneNumber()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonAddPhoneNumber);

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
