using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        EmailNotificationsForMarketplaceAdmin emailNotificationsForMarketplaceAdmin = EmailNotificationsForMarketplaceAdmin.Generate();
        
        #region List of notifications page

        [AllureStep("ClickButtonHtml")]
        public EmailPutsBox ClickButtonHtml()
        {
            WaitUntil.WaitSomeInterval(500);
            WaitUntil.CustomElementIsVisible(ButtonBodyHtml);
            WaitUntil.CustomElementIsClickable(ButtonBodyHtml);
            Button.Click(ButtonBodyHtml);

            return this;
        }

        #endregion

        [AllureStep("GetSubjectNotification")]
        public string GetSubjectNotificationCommon()
        {
            WaitUntil.CustomElementIsVisible(SubjectNotificationCommon);
            string fullSubject = SubjectNotificationCommon.Text;

            return fullSubject;
        }

        [AllureStep("GetTextWithDearVlCommon")]
        public string GetTextWithDearVlCommon()
        {
            string fullText = DearRowCommon.Text;

            return fullText;
        }

        [AllureStep("GetTextWithWelcomeVlCommon")]
        public string GetTextWithWelcomeVlCommon()
        {
            string fullText = WelcomeRowCommon.Text;

            return fullText;
        }

        [AllureStep("GetTexWeAreDelightedCreateMarketplaceaAdmin")]
        public string GetTexWeAreDelightedCreateMarketplaceaAdmin()
        {
            string fullText = ThrdRwBodyWeAreDelightedCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetTexToGetStartedCommon")]
        public string GetTexToGetStartedCommon()
        {
            string fullText = ToGetStartedCommon.Text;

            return fullText;
        }

        [AllureStep("GetOnlyTexCopyThePassword")]
        public string GetOnlyTexCopyThePassword()
        {
            string fullText = FfthRwBodyCopyThePasswordCreateMarketplaceaAdmin.Text;

            return fullText;
        }

        [AllureStep("GetTexClickTheButtonGetStarted")]
        public string GetTexClickTheButtonGetStarted()
        {
            string fullText = SxthRwBodyClickTheButtonGetStartedCreateMarketplaceaAdmin.Text;

            return fullText;
        }
    }
}
