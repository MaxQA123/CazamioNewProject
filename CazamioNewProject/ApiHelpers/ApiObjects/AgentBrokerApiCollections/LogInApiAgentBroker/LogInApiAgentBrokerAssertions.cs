using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.ApiHelpers.ApiObjects.AgentBrokerApiCollections.LogInApiAgentBroker
{
    public partial class LogInApiAgentBroker
    {
        [AllureStep("VerifyUserData")]
        public static void VerifyUserData(ResponseLogInAgentBroker responseBroker, AgentBroker agentBroker)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(agentBroker.CreatedAgentMySpace.FullName, responseBroker.AuthData.User.UserName, $"Name not equal");
                Assert.AreEqual(agentBroker.CreatedAgentMySpace.Email, responseBroker.AuthData.User.UserEmail, $"Email not equal");
                Assert.AreEqual(GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE, responseBroker.MarketplaceId, $"MarketplaceId not equal");
            });
        }
    }
}
