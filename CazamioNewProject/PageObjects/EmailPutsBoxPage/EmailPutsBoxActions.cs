using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
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
    }
}
