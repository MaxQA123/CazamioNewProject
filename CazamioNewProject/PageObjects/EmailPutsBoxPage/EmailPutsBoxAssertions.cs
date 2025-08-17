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

        [AllureStep("VerifyComparisonSubjectNotificationCreateMarketplaceAdmin")]
        public EmailPutsBox VerifyComparisonSubjectNotificationCreateMarketplaceAdmin()
        {
            string subjectNotificationFromEmail = Pages.EmailPutsBox.GetSubjectNotificationCommon();
            Assert.AreEqual(subjectNotificationFromEmail, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.Subject);

            return this;
        }

        [AllureStep("VerifyComparisonBodyNotificationCreateMarketplaceAdmin")]
        public EmailPutsBox VerifyComparisonBodyNotificationCreateMarketplaceAdmin(string fullEmailPutsBox)
        {
            WaitUntil.WaitSomeInterval(100);
            SwitchingBetweenBrowserTabs.ThirdTabSelect();
            WaitUntil.CustomElementIsVisible(DearRowCommon);
            string dearRowAc = Pages.EmailPutsBox.GetTextWithDearVlCommon();
            string welcomeRowAc = Pages.EmailPutsBox.GetTextWithWelcomeVlCommon();
            string weAreDelightedRowAc = Pages.EmailPutsBox.GetTexWeAreDelightedCreateMarketplaceaAdmin();
            string toGetStartedRowAc = Pages.EmailPutsBox.GetTexToGetStartedCommon();
            string onlyTexCopyThePasswordRowAc = Pages.EmailPutsBox.GetOnlyTexCopyThePassword();
            string passwordValueFromFfthRowTexCopyThePasswordAc = Pages.EmailPutsBox.GetPasswordValueFromFfthRowTexCopyThePassword();
            string clickTheButtonGetStartedRowAc = Pages.EmailPutsBox.GetTexClickTheButtonGetStarted();
            string onlyTextPasteThePasswordRowAc = Pages.EmailPutsBox.GetOnlyTexPasteThePassword();
            string onlyPasswordFromSvnRowAc = Pages.EmailPutsBox.GetOnlyPasswordFromSvnRow();
            string onlyTexInThePasswordFieldForLoginAc = Pages.EmailPutsBox.GetOnlyTexInThePasswordFieldForLogin();
            string onlyTexPasteTheEmailAc = Pages.EmailPutsBox.GetOnlyTexPasteTheEmail();
            string onlyEmailAddressFromPasteTheEmailAc = Pages.EmailPutsBox.GetOnlyEmailAddressFromPasteTheEmail();
            string onlyTextInTheEmailFieldForLoginAc = Pages.EmailPutsBox.GetOnlyTextInTheEmailFieldForLogin();
            string textClickTheLetsGoAc = Pages.EmailPutsBox.GetTextClickTheLetsGo();
            string btnNameGetStartedAc = Pages.EmailPutsBox.GetBtnNameGetStarted();
            string textPleaseContactOurSupportTeamAc = Pages.EmailPutsBox.GetTextPleaseContactOurSupportTeam();
            string textYourAccountWasCreatedAc = Pages.EmailPutsBox.GetTextYourAccountWasCreated();
            Assert.AreEqual(dearRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.FrstRwBodyDear);
            Assert.AreEqual(welcomeRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ScndRwBodyWelcome);
            Assert.AreEqual(weAreDelightedRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.ThrdRwBodyWeAreDelighted);
            Assert.AreEqual(toGetStartedRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.FrthRwBodyToGetStarted);
            Assert.AreEqual(onlyTexCopyThePasswordRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.FfthRwBodyOnlyTextCopyThePassword);
            Assert.AreEqual(clickTheButtonGetStartedRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.SxthRwBodyClickTheButtonGetStarted);
            Assert.AreEqual(onlyTextPasteThePasswordRowAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.SvnthRwBodyOnlyTextPasteThePassword);
            Assert.AreEqual(passwordValueFromFfthRowTexCopyThePasswordAc, onlyPasswordFromSvnRowAc);
            Assert.AreEqual(onlyTexInThePasswordFieldForLoginAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.SvnthhRwBodyOnlyTextInThePasswordFieldForLogin);
            Assert.AreEqual(onlyTexPasteTheEmailAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.EighthRwBodyOnlyTextPasteTheEmail);
            Assert.AreEqual(onlyEmailAddressFromPasteTheEmailAc, fullEmailPutsBox);
            Assert.AreEqual(onlyTextInTheEmailFieldForLoginAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.EighthRwBodyOnlyTextInTheEmailFieldForLogin);
            Assert.AreEqual(textClickTheLetsGoAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.NineRwBodyClickTheLetsGoButtonToLogIn);
            Assert.AreEqual(btnNameGetStartedAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.GetStartedBtnName);
            Assert.AreEqual(textPleaseContactOurSupportTeamAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.TenthRwBodyPleaseContactOurSupportTeam);
            Assert.AreEqual(textYourAccountWasCreatedAc, emailNotificationsForMarketplaceAdmin.SubjectAndBodyCreatingMarketplaceAdmin.EleventhRwBodyYourAccountWasCreated);

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
