using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        SuperAdmin superAdmin = SuperAdmin.Generate();
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();
        Broker broker = Broker.Generate();
        Agent agent = Agent.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();
        BasicDataForProject basicDataForProject = BasicDataForProject.Generate();

        [AllureStep("Enter Email Marketplace Admin")]
        public LogInLandlord EnterEmailMarketplaceAdmin()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, marketplaceAdmin.CreatedMarkAdmMySpace.Email);

            return this;
        }

        [AllureStep("Enter Password Marketplace Admin")]
        public LogInLandlord EnterPasswordMarketplaceAdmin()
        {
            WaitUntil.CustomElementIsVisible(FieldInputPassword);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("Enter email not added to system")]
        public LogInLandlord EnterEmailNotAddedToSystem()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, basicDataForProject.Emails.EmailNotAddedToSystem);

            return this;
        }

        [AllureStep("Enter password not added to system")]
        public LogInLandlord EnterPasswordNotAddedToSystem()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputPassword, basicDataForProject.Passwords.PasswordInvalid);

            return this;
        }

        [AllureStep("Click Icon Show")]
        public LogInLandlord ClickIconShow()
        {
            WaitUntil.CustomElementIsVisible(FieldInputPassword);
            Button.Click(IconShow);

            return this;
        }

        [AllureStep("Click Button Lets Go")]
        public LogInLandlord ClickButtonLetsGo()
        {
            WaitUntil.CustomElementIsVisible(ButtonLetsGo);
            Button.Click(ButtonLetsGo);

            return this;
        }

        [AllureStep("Click Link Forgot Password")]
        public LogInLandlord ClickLinkForgotPassword()
        {
            WaitUntil.CustomElementIsVisible(LinkForgotPassword);
            Button.Click(LinkForgotPassword);

            return this;
        }
    }
}
