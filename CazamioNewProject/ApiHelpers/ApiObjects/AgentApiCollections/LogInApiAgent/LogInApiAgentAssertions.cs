using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.AgentApiCollections.LogInApiAgent
{
    public partial class LogInApiAgent
    {
        [AllureStep("VerifyUserData")]
        public static void VerifyUserData(ResponseLogInAgent responseBroker, Agent agent)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(agent.FullNameAgent, responseBroker.AuthData.User.UserName, $"Name not equal");
                Assert.AreEqual(agent.EmailAddressAgent, responseBroker.AuthData.User.UserEmail, $"Email not equal");
                Assert.AreEqual(GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE, responseBroker.MarketplaceId, $"MarketplaceId not equal");
            });
        }
    }
}
