using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System.Collections.Generic;

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
            Assert.AreEqual(subjectNotificationFromEmail, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.Subject);

            return this;
        }

        [AllureStep("VerifyComparisonBodyNotificationCreateMarketplaceAdmin")]
        public EmailPutsBox VerifyComparisonBodyNotificationCreateMarketplaceAdmin()
        {
            WaitUntil.WaitSomeInterval(100);
            SwitchingBetweenBrowserTabs.ThirdTabSelect();
            WaitUntil.CustomElementIsVisible(DearRowCommon);
            string dearRow = Pages.EmailPutsBox.GetTextWithDearVlCommon();
            string welcomeRow = Pages.EmailPutsBox.GetTextWithWelcomeVlCommon();
            string weAreDelightedRow = Pages.EmailPutsBox.GetTexWeAreDelightedCreateMarketplaceaAdmin();
            string toGetStartedRow = Pages.EmailPutsBox.GetTexToGetStartedCommon();
            string onlyTexCopyThePasswordRow = Pages.EmailPutsBox.GetOnlyTexCopyThePassword(); //apply REGEX
            string clickTheButtonGetStartedRow = Pages.EmailPutsBox.GetTexClickTheButtonGetStarted();
            Assert.AreEqual(dearRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.FrstRwBodyDear);
            Assert.AreEqual(welcomeRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ScndRwBodyWelcome);
            Assert.AreEqual(weAreDelightedRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ThrdRwBodyWeAreDelighted);
            Assert.AreEqual(toGetStartedRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.FrthRwBodyToGetStarted);
            //Assert.AreEqual(welcomeRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ScndRwBodyWelcome);
            //Assert.AreEqual(welcomeRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ScndRwBodyWelcome);
            //Assert.AreEqual(welcomeRow, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ScndRwBodyWelcome);

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
