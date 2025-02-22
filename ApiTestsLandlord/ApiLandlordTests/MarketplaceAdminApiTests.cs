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
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateOwnerApi;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using System;
using CazamioNewProject.DbHelpers.LandlordsBrokersTable;
using CazamioNewProject.DbHelpers.BrokersAgentsTable;
using CazamioNewProject.DbHelpers.OwnerCommissionsStructureTable;
using CazamioNewProject.DbHelpers.OwnerPhoneNumbersTable;
using CazamioNewProject.DbHelpers.OwnerManagementsTable;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApi;
using CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.CreateBuildingApiMandatoryData;

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

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

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

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

            Broker broker = Broker.Generate();

            var firstNameBroker = broker.BrokerName.FirstNameRandom;
            var lastNameBroker = broker.BrokerName.LastNameRandom;
            var emailBroker = broker.BrokerEmail.FullEmail;
            var passwordBroker = "";

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            BrokerCreation.CreateBroker(responseMarketplaceAdmin.AuthData.Token, firstNameBroker, lastNameBroker, emailBroker, passwordBroker);

            #endregion

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(emailBroker, marketplaceId);
            Console.WriteLine($"{emailBroker}");
            WaitUntil.WaitSomeInterval(100);
            LandlordsBrokersDbRequests.LandlordsBrokers.DeleteNewlyCreatedBroker(emailBroker, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(emailBroker, marketplaceId);

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

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

            Agent agent = Agent.Generate();

            var firstNameAgent = agent.AgentName.FirstNameRandom;
            var lastNameAgent = agent.AgentName.LastNameRandom;
            var emailAgent = agent.AgentEmail.FullEmail;
            var phoneNumberAgent = agent.PhoneNumber.BasicFirst;
            var brokerCommissionAgent = agent.CommissionPercentage.BrokerCommissionApi;
            var agentCommissionAgent = agent.CommissionPercentage.AgentCommissionApi;
            var cellAgent = agent.PhoneNumber.CellFirst;

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            AgentCreation.CreateAgent(responseMarketplaceAdmin.AuthData.Token, firstNameAgent, lastNameAgent, emailAgent, phoneNumberAgent, brokerCommissionAgent, agentCommissionAgent, cellAgent);

            #endregion

            #region Postconditions

            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(emailAgent, marketplaceId);
            Console.WriteLine($"{emailAgent}");
            WaitUntil.WaitSomeInterval(100);
            BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(emailAgent, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(emailAgent, marketplaceId);

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
            //#region Test Data

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            //var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

            //var ownerBody = OwnerCreation.RequestBodyBrokerFullData();

            //#endregion

            //#region Preconditions

            //var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            //#endregion

            //#region Tests

            //OwnerCreation.CreateOwnerWithBrokerFullData(responseMarketplaceAdmin.AuthData.Token, ownerBody);

            //#endregion

            //#region Postconditions

            //OwnerCommissionsStructureDbRequests.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(ownerBody.OwnerEmail, marketplaceId);
            //Console.WriteLine($"{ownerBody.OwnerEmail}");
            //OwnerPhoneNumbersDbRequests.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(ownerBody.OwnerEmail, marketplaceId);
            //OwnerManagementsDbRequsts.OwnerManagements.DeleteRecordAboutOwnerManagements(ownerBody.OwnerEmail, marketplaceId);
            //OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(ownerBody.OwnerEmail, marketplaceId);

            //#endregion
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

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

            var ownerBody = OwnerCreation.RequestBodyAgentRequiredData();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            OwnerCreation.CreateOwnerWithAgentRequiredData(responseMarketplaceAdmin.AuthData.Token, ownerBody);

            #endregion

            #region Postconditions

            OwnerCommissionsStructureDbRequests.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(ownerBody.OwnerEmail, marketplaceId);
            Console.WriteLine($"{ownerBody.OwnerEmail}");
            OwnerPhoneNumbersDbRequests.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(ownerBody.OwnerEmail, marketplaceId);
            OwnerManagementsDbRequsts.OwnerManagements.DeleteRecordAboutOwnerManagements(ownerBody.OwnerEmail, marketplaceId);
            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(ownerBody.OwnerEmail, marketplaceId);

            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateBuildingFullDataWithBroker")]

        public void CreateBuildingFullDataWithBroker()
        {
            //#region Test Data

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //MarketplaceAdmin marketplaceAdmin = new MarketplaceAdmin().Generate();

            //var email = marketplaceAdmin.EmailAddressMarketplaceAdmin;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = marketplaceAdmin.DeviceFingerprint;

            //var buildingBody = BuildingCreation.RequestBodyCreateBuildingFullDataBroker();

            //#endregion

            //#region Preconditions

            //var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            //#endregion

            //#region Tests

            //BuildingCreation.CreateBuildingWithBrokerFullData(responseMarketplaceAdmin.AuthData.Token, buildingBody);

            //#endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateBuildingFullDataWithBroker")]

        public void CreateBuildingMandatoryDataWithAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            #endregion

            #region Preconditions

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var email = marketplaceAdmin.CreatedMarkAdmMySpace.Email;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = marketplaceAdmin.BasicDataApi.DeviceFingerprint;

            var buildingBody = BuildingCreationMandatoryData.RequestBodyCreateBuildingMandatoryDataWithAgent();

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            BuildingCreationMandatoryData.CreateBuildingMandatoryDataWithAgent(responseMarketplaceAdmin.AuthData.Token, buildingBody);

            #endregion
        }
    }
}
