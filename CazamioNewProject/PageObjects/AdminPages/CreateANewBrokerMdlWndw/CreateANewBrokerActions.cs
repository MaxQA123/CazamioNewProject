using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        Broker broker = Broker.Generate();

        [AllureStep("ClickButtonCreate")]
        public CreateANewBrokerMdlWndw ClickButtonCreate()
        {
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("CopyEmailFromFieldEmail")]
        public string CopyEmailFromFieldEmail()
        {
            WaitUntil.CustomElementIsVisible(FieldInputEmail);
            string fullEmail = FieldInputEmail.GetAttribute("value");

            return fullEmail;
        }

        [AllureStep("CopyEmailBeforeDogFromModalWindowCreateNewBroker")]
        public string CopyEmailBeforeDogFromModalWindowCreateNewBroker()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmail.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
    }
}
