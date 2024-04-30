using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using NUnit.Allure.Core;
using CazamioNewProject.Objects;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;

namespace ApiTestsLandlord.ApiBaseLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class MarketplaceAdminApiTests : ApiBaseLandlord
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("ApiPenant")]
        [AllureSubSuite("LogInAsTenant")]

        public void LogIn()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            #endregion

            #region Test

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInTenant.VerifyingUserNameEmailTenant(responseLogInTenant);

            #endregion
        }
    }
}
