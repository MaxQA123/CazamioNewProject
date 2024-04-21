using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [AllureStep("EnterFirstLastNameEmailPhnNmbrCell")]
        public CreateNewAgentMdlWndw EnterFirstLastNameEmailPhnNmbrCell()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, agent.FirstName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, agent.LastName);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agent.EmailAddress);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, agent.PhoneNumber);
            InputGeneral.InputFunctionWithClear(FieldInputCell, agent.Cell);

            return this;
        }

        [AllureStep("EnterBrokerAgentCommission")]
        public CreateNewAgentMdlWndw EnterBrokerAgentCommission()
        {
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommission, agent.AgentCommission);
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommission, agent.BrokerCommission);

            return this;
        }
    }
}
