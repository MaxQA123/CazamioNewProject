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
        //Amount order 3 next must be 4
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TenantCreator")]
        [AllureSubSuite("Demo")]

        public void Demo()
        {
            Pages.LogInTenant
                .LogInAsCreatorWithCreditReportMySpace();
            Pages.HeaderTenants
                .ClickButtonMyApplications();
            Pages.MyAccount
                .ClickCompleteOrEditThisApplicationBtn();

            string applicationIdFromAppTenant = Pages.SubmittingApplication.GetApplicationIdVl();

            WaitUntil.WaitSomeInterval(1000);
        }

        [Test]
        [Order(2)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TenantCreator")]
        [AllureSubSuite("LogInAsCreatorWithCreditReportMySpace")]

        public void LogInAsCreatorWithCreditReportMySpace()
        {
            Pages.LogInTenant
                .LogInAsCreatorWithCreditReportMySpace();

            WaitUntil.WaitSomeInterval(1000);
        }

        [Test]
        [Order(3)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("TenantCreator")]
        [AllureSubSuite("LogInAsCreatorWithoutCreditReportMySpace")]

        public void LogInAsCreatorWithoutCreditReportMySpace()
        {
            Pages.LogInTenant
                .LogInAsCreatorWithoutCreditReportMySpace();

            WaitUntil.WaitSomeInterval(1000);
        }
    }
}