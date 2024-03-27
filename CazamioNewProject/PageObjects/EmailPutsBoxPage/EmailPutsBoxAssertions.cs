using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        [AllureStep("VerifyTitleLetterCreateAdmin")]
        public EmailPutsBox VerifyTitleLetterCreateAdmin()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateAdminMySpace);
            Assert.IsTrue(TitleLetterCreateAdminMySpace.Displayed);
            Console.WriteLine(TitleLetterCreateAdminMySpace.Text);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateBroker")]
        public EmailPutsBox VerifyTitleLetterCreateBroker()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateBrokerMySpace);
            Assert.IsTrue(TitleLetterCreateBrokerMySpace.Displayed);
            Console.WriteLine(TitleLetterCreateBrokerMySpace.Text);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateAgent")]
        public EmailPutsBox VerifyTitleLetterCreateAgent()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateAgentMySpace);
            Assert.IsTrue(TitleLetterCreateAgentMySpace.Displayed);
            Console.WriteLine(TitleLetterCreateAgentMySpace.Text);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateTenant")]
        public EmailPutsBox VerifyTitleLetterCreateTenant()
        {
            WaitUntil.CustomElementIsVisible(TitleLetterCreateTenant);
            Assert.IsTrue(TitleLetterCreateTenant.Displayed);
            Console.WriteLine(TitleLetterCreateTenant.Text);

            return this;
        }
    }
}
