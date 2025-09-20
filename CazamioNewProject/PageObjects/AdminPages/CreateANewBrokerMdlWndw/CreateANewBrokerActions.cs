using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        Broker broker = Broker.Generate();

        [AllureStep("Enter First Name")]
        public CreateANewBrokerMdlWndw EnterFirstName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, broker.BrokerName.FirstNameRandom);

            return this;
        }

        [AllureStep("Enter Last Name")]
        public CreateANewBrokerMdlWndw EnterLastName()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, broker.BrokerName.LastNameRandom);

            return this;
        }

        [AllureStep("Enter Email")]
        public CreateANewBrokerMdlWndw EnterEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, broker.BrokerEmail.FullEmailRandom);

            return this;
        }

        [AllureStep("Click Button Create in Create a new Broker mdl wndw")]
        public CreateANewBrokerMdlWndw ClickButtonCreate()
        {
            WaitUntil.CustomElementIsVisible(ButtonCreate);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("Copy Email from field email")]
        public string CopyEmailFromFieldEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            string fullEmail = FieldInputEmail.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("Get symbols before dog from field Email")]
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
    }
}
