using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.AgentApiCollections.LogInApiAgent;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class AgentApiTests
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Agent Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            //#region Test Data

            //Agent agent = new Agent().Generate();

            //var email = agent.EmailAddressAgent;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = agent.DeviceFingerprint;

            //#endregion

            //#region Test

            //var responseAgent = LogInApiAgent.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiAgent.VerifyUserData(responseAgent, agent);

            //#endregion
        }
    }
}
