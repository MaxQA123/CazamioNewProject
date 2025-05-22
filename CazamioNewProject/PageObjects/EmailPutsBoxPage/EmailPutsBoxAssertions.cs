using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        [AllureStep("VerifyTitleLetterCreateAdmin")]
        public EmailPutsBox VerifyTitleLetterCreateAdmin()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(TitleLetterCreateAdminMySpace));

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateBroker")]
        public EmailPutsBox VerifyTitleLetterCreateBroker()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(TitleLetterCreateBrokerMySpace));

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateAgentMySpace")]
        public EmailPutsBox VerifySubjectLetterCreateAgentMySpace()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(SubjectLetterCreateAgentMySpace));

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            WaitUntil.CustomElementIsVisible(SubjectLetterCreateTenantViaGetLink);
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLinkWithBrokerAsAgent")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaGetLinkWithBrokerAsAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            WaitUntil.CustomElementIsVisible(SubjectLetterCreateTenantViaGetLink);
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLink")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaPlusAppWithAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            WaitUntil.CustomElementIsVisible(SubjectLetterCreateTenantViaGetLink);
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }
    }
}
