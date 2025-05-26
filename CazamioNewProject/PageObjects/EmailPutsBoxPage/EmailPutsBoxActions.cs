using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.EmailPutsBoxPage
{
    public partial class EmailPutsBox
    {
        #region PageListOfLetters

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

        #region SubjectLetterOfTenant

        [AllureStep("GetSubjectNotification")]
        public string GetSubjectNotificationCommon()
        {
            WaitUntil.CustomElementIsVisible(SubjectNotificationCommon);
            string fullSubject = SubjectNotificationCommon.Text;

            return fullSubject;
        }

        #endregion

        //#region SubjectLetterOfTenant

        //[AllureStep("GetSubjectLetterCreateTenantViaGetLink")]
        //public string GetSubjectLetterCreateTenantViaGetLink()
        //{
        //    WaitUntil.CustomElementIsVisible(SubjectNotificationCommon);
        //    string fullSubject = SubjectNotificationCommon.Text;

        //    return fullSubject;
        //}

        //#endregion

        //public class VerifyPutsBox
        //{
        //    public static void VerifyVisibilityOfToaster(string email)
        //    {
        //        string s = EmailPutsBox.GetLinkFromEmailWithValue(email, "Confirm Email");
        //        Browser._Driver.Navigate().GoToUrl(s);
        //        //WaitUntil.CustomElementIsVisible(toasterSuccessMessage);

        //    }
        //}
    }
}
