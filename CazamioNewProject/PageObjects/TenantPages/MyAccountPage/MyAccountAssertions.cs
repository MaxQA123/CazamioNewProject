using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        [AllureStep("VerifyApplicationIdNumber")]
        public MyAccount VerifyApplicationIdNumber(string applicationIdFromAppLandlord, string applicationIdFromAppTenant)
        {
            Assert.AreEqual(applicationIdFromAppLandlord, applicationIdFromAppTenant);
            Console.WriteLine($"AR:{applicationIdFromAppLandlord} ER: {applicationIdFromAppTenant} applicationId number");

            return this;
        }
    }
}
