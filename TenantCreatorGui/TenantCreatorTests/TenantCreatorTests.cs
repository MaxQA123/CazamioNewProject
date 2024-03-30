using Allure.Commons;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace TenantCreatorGui
{
    [TestFixture]
    [AllureNUnit]

    public class TestsBaseGui : TenantCreatorBase
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TenantCreator")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            Pages.Header
                .ClickButtonLogIn();
            Pages.LogInTenant
                .EnterEmailPasswordAsTenantCreator()
                .ClickIconShow()
                .SetCheckBoxRememberMe()
                .ClickButtonLogIn();
            Pages.Header
                .ClickButtonMyApplications();
            //Pages.MyAccountCazamioTenant
            //    .ClickTabAccountOnMyAccntPg()
            //    .ClickButtonEditMyAccntPgTabAccnt();

            //string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            //string getLastNameForCompare = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            //Pages.MyAccountCazamioTenant
            //    .VerifyTenatFirstLastName(getFirstNameForCompare, getLastNameForCompare);
            //Pages.Header
            //    .LogOutFromAccountViaHeader();

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}