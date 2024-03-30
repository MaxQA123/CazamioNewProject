using Allure.Commons;
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
            Pages.HeaderCazamioTenant
                .ClickButtonLogInHdrCzmTnnt();
            Pages.LogInCazamioTenant
                .EnterEmailPasswordOnLgInAsTenantApplicant()
                .ClickIconShowLgInCazmTnnt()
                .SetCheckBoxRememberMeLgInCazmTnnt()
                .ClickButtonLogInLgInCazmTnnt();
            Pages.HeaderCazamioTenant
                .ClickButtonMyApplicationsHdrCzmTnnt();
            Pages.MyAccountCazamioTenant
                .ClickTabAccountOnMyAccntPg()
                .ClickButtonEditMyAccntPgTabAccnt();

            string getFirstNameForCompare = Pages.MyAccountCazamioTenant.GetFirstNameFromMyAccount();
            string getLastNameForCompare = Pages.MyAccountCazamioTenant.GetLastNameFromMyAccount();

            Pages.MyAccountCazamioTenant
                .VerifyTenatFirstLastName(getFirstNameForCompare, getLastNameForCompare);
            Pages.HeaderCazamioTenant
                .LogOutFromAccountViaHeader();

            WaitUntil.WaitSomeInterval(2000);
        }
    }
}