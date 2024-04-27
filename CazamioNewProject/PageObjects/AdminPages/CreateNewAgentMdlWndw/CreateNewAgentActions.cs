﻿using CazamioNewProject.GuiHelpers;
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
        Agent agent = new Agent().Generate();

        [AllureStep("CopyEmailFromMdlWndwCreateAgent")]
        public string CopyEmailFromMdlWndwCreateAgent()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyEmail = Browser._Driver.FindElement(By.XPath("//input[@id = 'email']")).GetAttribute("value");
            string copyEmailActual = copyEmail.ToString();

            return copyEmailActual;
        }

        [AllureStep("CopyEmailBeforeDogFromModalWindowCreateNewAgent")]
        public string CopyEmailBeforeDogFromModalWindowCreateNewAgent()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmail.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("ClickButtonSave")]
        public CreateNewAgentMdlWndw ClickButtonSave()
        {
            Button.Click(ButtonSave);

            return this;
        }
    }
}