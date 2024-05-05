using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker
{
    public partial class LogInApiBroker
    {
        [AllureStep("VerifyUserData")]
        public static void VerifyUserData(ResponseLogInApiBroker responseBroker, Broker broker)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(broker.FullUserNameBroker, responseBroker.AuthData.User.UserName, $"Name not equal");
                Assert.AreEqual(broker.EmailAddressBroker, responseBroker.AuthData.User.UserEmail, $"Email not equal");
                Assert.AreEqual(GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE, responseBroker.MarketplaceId, $"MarketplaceId not equal");
            });
        }
    }
}
