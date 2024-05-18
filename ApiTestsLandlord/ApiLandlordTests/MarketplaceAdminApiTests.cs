using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using NUnit.Allure.Core;
using CazamioNewProject.Objects;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBrokerApi;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateAgentApi;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerWithBrokerApi;

namespace ApiTestsLandlord
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
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("LogIn")]

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

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateBroker")]

        public void CreateBroker()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            Broker broker = new Broker().Generate();

            var firstNameBroker = broker.FirstName;
            var lastNameBroker = broker.LastName;
            var emailBroker = broker.EmailAddress;
            var passwordBroker = "";

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            BrokerCreation.CreateBroker(responseMarketplaceAdmin.AuthData.Token, firstNameBroker, lastNameBroker, emailBroker, passwordBroker);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            Agent agent = new Agent().Generate();

            var firstNameAgent = agent.FirstName;
            var lastNameAgent = agent.LastName;
            var emailAgent = agent.EmailAddress;
            var phoneNumberAgent = agent.PhoneNumber;
            var brokerCommissionAgent = agent.BrokerCommissionApi;
            var agentCommissionAgent = agent.AgentCommissionApi;
            var cellAgent = agent.Cell;

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            AgentCreation.CreateAgent(responseMarketplaceAdmin.AuthData.Token, firstNameAgent, lastNameAgent, emailAgent, phoneNumberAgent, brokerCommissionAgent, agentCommissionAgent, cellAgent);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateOwnerWithBroker")]

        public void CreateOwnerWithBroker()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            OwnerCreation.CreateOwnerWithBrokerFullData(responseMarketplaceAdmin.AuthData.Token);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateOwnerWithAgent")]

        public void CreateOwnerWithAgent()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            OwnerCreation.CreateOwnerWithAgentRequiredData(responseMarketplaceAdmin.AuthData.Token);

            #endregion
        }
    }
}
