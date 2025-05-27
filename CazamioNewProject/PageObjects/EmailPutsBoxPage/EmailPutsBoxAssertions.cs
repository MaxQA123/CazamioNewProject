using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        [AllureStep("VerifySubjectNotificationCreateAdmin")]
        public EmailPutsBox VerifySubjectNotificationCreateAdmin()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(SubjectNotificationCreateAdminMySpace));

            return this;
        }

        [AllureStep("VerifyComparisonSubjectNotificationCreateAdmin")]
        public EmailPutsBox VerifyComparisonSubjectNotificationCreateAdmin()
        {
            string subjectNotificationFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();
            Assert.AreEqual(subjectNotificationFromEmail, emailNotificationsForMarketplaceAdmin.SubjectsAndBodiesBasic.SubjectCreatingNewMarketplaceAdminMySpace);

            return this;
        }

        [AllureStep("VerifyComparisonBodyNotificationCreateAdmin")]
        public EmailPutsBox VerifyComparisonBodyNotificationCreateAdmin()
        {
            string subjectNotificationFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();
            Assert.AreEqual(subjectNotificationFromEmail, emailNotificationsForMarketplaceAdmin.SubjectsAndBodiesBasic.SubjectCreatingNewMarketplaceAdminMySpace);

            return this;
        }

        [AllureStep("VerifyTitleLetterCreateBroker")]
        public EmailPutsBox VerifyTitleLetterCreateBroker()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(SubjectNotificationCreateBrokerMySpace));

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateAgentMySpace")]
        public EmailPutsBox VerifySubjectLetterCreateAgentMySpace()
        {
            Assert.IsTrue(SubjectEmail.IsVisible(SubjectNotificationCreateAgentMySpace));

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaGetLinkWithoutAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLinkWithBrokerAsAgent")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaGetLinkWithBrokerAsAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }

        [AllureStep("VerifySubjectLetterCreateTenantViaGetLink")]
        public EmailPutsBox VerifySubjectLetterCreateTenantViaPlusAppWithAgent(string getSubjectExpected, string getSubjectFromEmail)
        {
            Assert.AreEqual(getSubjectExpected, getSubjectFromEmail);

            return this;
        }
    }
}
