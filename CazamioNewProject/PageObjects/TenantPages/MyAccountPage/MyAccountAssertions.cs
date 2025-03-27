using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        [AllureStep("VerifyApplicationIdNumberTenantCreator")]
        public MyAccount VerifyApplicationIdNumberTenantCreator(string applicationIdFromAppLandlord, string appIdFromAppTenantCreator)
        {
            Assert.AreEqual(applicationIdFromAppLandlord, appIdFromAppTenantCreator);
            Console.WriteLine($"AR:{applicationIdFromAppLandlord} ER: {appIdFromAppTenantCreator} applicationId number");

            return this;
        }

        [AllureStep("VerifyApplicationIdNumberTenantOccupant")]
        public MyAccount VerifyApplicationIdNumberTenantOccupant(string applicationIdFromAppLandlord, string appIdFromAppTenantOccupant)
        {
            Assert.AreEqual(applicationIdFromAppLandlord, appIdFromAppTenantOccupant);
            Console.WriteLine($"AR:{applicationIdFromAppLandlord} ER: {appIdFromAppTenantOccupant} applicationId number");

            return this;
        }
    }
}
