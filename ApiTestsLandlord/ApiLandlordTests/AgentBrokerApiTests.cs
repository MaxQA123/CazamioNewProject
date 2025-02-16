using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.AgentBrokerApiCollections.LogInApiAgentBroker;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class AgentBrokerApiTests
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("AgentBroker Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            //#region Test Data

            //AgentBroker agentBroker = new AgentBroker().Generate();

            //var email = agentBroker.EmailAddressAgentBroker;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = agentBroker.DeviceFingerprint;

            //#endregion

            //#region Test

            //var responseAgentBroker = LogInApiAgentBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiAgentBroker.VerifyUserData(responseAgentBroker, agentBroker);

            //#endregion
        }
    }
}
