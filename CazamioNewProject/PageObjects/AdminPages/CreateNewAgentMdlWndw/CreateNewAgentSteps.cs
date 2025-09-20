using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [AllureStep("Enter full data")]
        public CreateNewAgentMdlWndw EnterFullData()
        {
            VerifyTitleCreateNewAgentMdlWndw();
            EnterFirstNameAgentRandom();
            EnterLastNameAgentRandom();
            EnterFullEmailRandom();
            EnterPhoneNumberBasicFirst();
            EnterBrokerCommissionRandom();
            EnterAgentCommissionRandom();

            return this;
        }

        [AllureStep("Enter full data without phone")]
        public CreateNewAgentMdlWndw EnterFullDataWithoutPhone()
        {
            VerifyTitleCreateNewAgentMdlWndw();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, agent.AgentName.FirstNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, agent.AgentName.LastNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agent.AgentEmail.FullEmailRandom);
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommission, agent.CommissionPercentage.ForBrokeStaticDecimalNumber);
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommission, agent.CommissionPercentage.ForAgentStaticDecimalNumber);

            return this;
        }

        [AllureStep("EnterBrokerAgentCommission")]
        public CreateNewAgentMdlWndw EnterBrokerAgentCommission()
        {
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommission, agent.CommissionPercentage.ForBrokerRandom);
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommission, agent.CommissionPercentage.ForAgentRandom);

            return this;
        }
    }
}
