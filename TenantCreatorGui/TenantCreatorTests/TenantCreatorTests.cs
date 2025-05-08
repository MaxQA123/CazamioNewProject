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
        //Amount order 2 next must be 3
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
        [Order(2)]
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