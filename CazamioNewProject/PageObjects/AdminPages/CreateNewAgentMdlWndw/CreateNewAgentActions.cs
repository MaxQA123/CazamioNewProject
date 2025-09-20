using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        Agent agent = Agent.Generate();

        [AllureStep("CopyEmailFromFieldEmail")]
        public string CopyEmailFromFieldEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            string fullEmail = FieldInputEmail.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("GetSymbolsBeforeDogFromFieldInputEmail")]
        public string GetSymbolsBeforeDogFromFieldInputEmail()
        {
            try
            {
                WaitUntil.WaitSomeInterval(500);
                string fullEmail = FieldInputEmail.GetAttribute("value");

                if (string.IsNullOrEmpty(fullEmail))
                {
                    throw new Exception("Email поле пустое");
                }

                Match match = Regex.Match(fullEmail, @"^([^@]+)");

                if (match.Success)
                {
                    return match.Groups[1].Value;
                }

                throw new Exception("Не удалось извлечь часть email до символа @");
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при получении части email: {ex.Message}");
            }
        }

        [AllureStep("Enter first name agent")]
        public CreateNewAgentMdlWndw EnterFirstNameAgentRandom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, agent.AgentName.FirstNameRandom);

            return this;
        }

        [AllureStep("Enter last name agent")]
        public CreateNewAgentMdlWndw EnterLastNameAgentRandom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, agent.AgentName.LastNameRandom);

            return this;
        }

        [AllureStep("Enter full email random agent")]
        public CreateNewAgentMdlWndw EnterFullEmailRandom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, agent.AgentEmail.FullEmailRandom);

            return this;
        }

        [AllureStep("Enter phone number agent")]
        public CreateNewAgentMdlWndw EnterPhoneNumberBasicFirst()
        {
            WaitUntil.CustomElementIsVisible(FieldInputPhoneNumber);
            InputGeneral.InputFunctionWithClear(FieldInputPhoneNumber, agent.PhoneNumber.BasicFirst);

            return this;
        }

        [AllureStep("Enter broker commission for agent")]
        public CreateNewAgentMdlWndw EnterBrokerCommissionRandom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputBrokerCommission);
            InputGeneral.InputFunctionWithClear(FieldInputBrokerCommission, agent.CommissionPercentage.ForBrokerRandom);

            return this;
        }

        [AllureStep("Enter agent commission for agent")]
        public CreateNewAgentMdlWndw EnterAgentCommissionRandom()
        {
            WaitUntil.CustomElementIsVisible(FieldInputAgentCommission);
            InputGeneral.InputFunctionWithClear(FieldInputAgentCommission, agent.CommissionPercentage.ForAgentRandom);

            return this;
        }

        [AllureStep("Click button Save for creating an agent")]
        public CreateNewAgentMdlWndw ClickButtonSave()
        {
            Button.Click(ButtonSave);
            Pages.ListOfAgents
                .VerifyMessageNewAgentCreatedSuccessfully();

            return this;
        }
    }
}
