using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        //[AllureStep("CopyEmailBeforeDogFromModalWindowCreateNewAgent")]
        //public string CopyEmailBeforeDogFromModalWindowCreateNewAgent()
        //{
        //    WaitUntil.WaitSomeInterval(500);
        //    string copyPartEmail = FieldInputEmail.GetAttribute("value");
        //    Regex regexPartEmail = new Regex(@"^..........");
        //    string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

        //    return partEmail;
        //}

        [AllureStep("ClickButtonSave")]
        public CreateNewAgentMdlWndw ClickButtonSave()
        {
            Button.Click(ButtonSave);

            return this;
        }
    }
}
