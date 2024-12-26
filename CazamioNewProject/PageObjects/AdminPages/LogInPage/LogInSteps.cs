using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("EnterEmailPasswordAsSuperAdmin")]
        public LogInLandlord EnterEmailPasswordAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, superAdmin.EmailAddressSuperAdmin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsMarketplaceAdmin")]
        public LogInLandlord EnterEmailPasswordAsMarketplaceAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, marketplaceAdmin.EmailAddressMarketplaceAdmin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsBroker")]
        public LogInLandlord EnterEmailPasswordAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, broker.EmailAddressBroker);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsAgent")]
        public LogInLandlord EnterEmailPasswordAsAgent()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, agent.CreatedAgentMySpace.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsAgentBroker")]
        public LogInLandlord EnterEmailPasswordAsAgentBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, agentBroker.CreatedAgentMySpace.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("CopiedForEnterEmailLogInPg")]
        public LogInLandlord CopiedForEnterEmailLogInPg(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, _email);

            return this;
        }

        [AllureStep("EnterPasswordLogInPgAsBroker")]
        public LogInLandlord EnterPasswordLogInPgAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("ClickLinkForgotPassword")]
        public LogInLandlord ClickLinkForgotPassword()
        {
            Button.Click(LinkForgotPassword);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateBroker(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateBroker(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAdmin(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAdmin(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAgent(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmailLogInPg.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAgent(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPasswordLogInPg.SendKeys(code);

            return this;
        }
    }
}
