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

        [AllureStep("GetFullEmailFromYourPutsBoxEmailFieldInput")]
        public string GetFullEmailFromYourPutsBoxEmailFieldInput()
        {
            WaitUntil.CustomElementIsVisible(YourPutsBoxEmailFieldInput);
            string fullText = YourPutsBoxEmailFieldInput.GetAttribute("value");

            return fullText;
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

        [AllureStep("GetBtnNameGetStarted")]
        public string GetBtnNameGetStarted()
        {
            string fullText = GetStartedBtn.Text;

            return fullText;
        }
    }
}
