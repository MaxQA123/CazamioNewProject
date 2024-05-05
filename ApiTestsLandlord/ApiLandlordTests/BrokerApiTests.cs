using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class BrokerApiTests
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test Data

            Broker broker = new Broker().Generate();

            var email = broker.EmailAddressBroker;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = broker.DeviceFingerprint;

            #endregion

            #region Test

            var responseBroker = LogInApiBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiBroker.VerifyUserData(responseBroker, broker);

            #endregion
        }
    }
}
