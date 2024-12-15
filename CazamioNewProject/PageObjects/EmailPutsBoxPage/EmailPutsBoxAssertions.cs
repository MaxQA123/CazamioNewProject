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

        [AllureStep("VerifySubjectLetterCreateAgentMySpace")]
        public EmailPutsBox VerifySubjectLetterCreateAgentMySpace()
        {
            WaitUntil.CustomElementIsVisible(SubjectLetterCreateAgentMySpace);
            Assert.IsTrue(SubjectLetterCreateAgentMySpace.Displayed);
            Console.WriteLine(SubjectLetterCreateAgentMySpace.Text);

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLink")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaGetLink(string getSubjectExpected, string getSubjectFromEmail)
        {
            WaitUntil.CustomElementIsVisible(SubjectLetterCreateTenantViaGetLink);
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }
    }
}
