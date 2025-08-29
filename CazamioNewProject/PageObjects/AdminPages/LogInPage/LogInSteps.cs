using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        #region MySpace

        [AllureStep("LogInAsSuperAdmin")]
        public LogInLandlord LogInAsSuperAdmin()
        {
            Pages.LogInLandlord.VerifyTitleLogInPg();
            InputGeneral.InputFunctionWithClear(FieldInputEmail, superAdmin.CreatedSuperAdmin.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(ButtonLetsGo);

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifySuperAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            return this;
        }

        [AllureStep("LogIn as Marketplace Admin MySpace")]
        public LogInLandlord LogInAsMarketplaceAdminMySpace()
        {
            Pages.LogInLandlord.VerifyTitleLogInPg();
            EnterEmailMarketplaceAdmin();
            EnterPasswordMarketplaceAdmin();
            ClickIconShow();
            ClickButtonLetsGo();

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyMarketplaceAdminUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            return this;
        }

        [AllureStep("LogInAsBrokerMySpace")]
        public LogInLandlord LogInAsBrokerMySpace()
        {
            Pages.LogInLandlord.VerifyTitleLogInPg();
            InputGeneral.InputFunctionWithClear(FieldInputEmail, broker.CreatedBrokerMySpace.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(ButtonLetsGo);

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            return this;
        }

        [AllureStep("LogInAsAgentMySpace")]
        public LogInLandlord LogInAsAgentMySpace()
        {
            Pages.LogInLandlord.VerifyTitleLogInPg();
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agent.CreatedAgentLulaMySpace.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(ButtonLetsGo);

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            return this;
        }

        [AllureStep("LogInAsAgentBrokerMySpace")]
        public LogInLandlord LogInAsAgentBrokerMySpace()
        {
            Pages.LogInLandlord.VerifyTitleLogInPg();
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agentBroker.CreatedAgentMySpace.Email);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);
            Button.Click(IconShow);
            Button.Click(ButtonLetsGo);

            string getUserNameCompare = Pages.SidebarLandlord.GetUserNameFromSideBar();
            string getUserNameRoleCompare = Pages.SidebarLandlord.GetUserNameRoleFromSideBar();

            Pages.SidebarLandlord
                .VerifyAgentBrokerUserNameAndRole(getUserNameCompare, getUserNameRoleCompare);

            return this;
        }

        #endregion

        [AllureStep("CopyValueFromEmail")]
        public LogInLandlord CopiedForEnterEmailLogInPg(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(3000);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, _email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateBroker(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPassword.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateBroker")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateBroker(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmail.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAdmin(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmail.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAdmin")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAdmin(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPassword.SendKeys(code);

            return this;
        }

        [AllureStep("PasteForEnterEmailFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterEmailFromEmailCreateAgent(string _email)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputEmail.SendKeys(_email);

            return this;
        }

        [AllureStep("PasteForEnterPsswrdFromEmailCreateAgent")]
        public LogInLandlord PasteForEnterPsswrdFromEmailCreateAgent(string code)
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);
            FieldInputPassword.SendKeys(code);

            return this;
        }
    }
}
