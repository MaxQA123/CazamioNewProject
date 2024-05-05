using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.LogInApiSuperAdmin;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class SuperAdminApiTests
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test Data

            SuperAdmin superAdmin = new SuperAdmin().Generate();

            var email = superAdmin.EmailAddressSuperAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = superAdmin.DeviceFingerprint;

            #endregion

            #region Test

            var responseSuperAdmin = LogInApiSuperAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiSuperAdmin.VerifyUserData(responseSuperAdmin, superAdmin);

            #endregion
        }
    }
}
