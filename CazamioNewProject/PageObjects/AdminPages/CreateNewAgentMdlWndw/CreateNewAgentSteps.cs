using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [AllureStep("EnterFirstLastNameEmailPhnNmbrCell")]
        public CreateNewAgentMdlWndw EnterFirstLastNameEmailPhnNmbrCell()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, agent.AgentName.FirstNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, agent.AgentName.LastNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agent.AgentEmail.FullEmailRandom);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, agent.PhoneNumber.BasicFirst);
            InputGeneral.InputFunctionWithClear(FieldInputCell, agent.PhoneNumber.CellFirst);

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
