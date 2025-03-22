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
using CazamioNewProject.CreateApartmentMandatoryDataApi;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class MarketplaceAdminApiTests : ApiBaseLandlord
    {
        //Amount order 8 next must be 9
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("DemoLogIn")]

        public void DemoLogIn()
        {
            #region Test Data

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Test

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion
        }

        [Test]
        [Order(1)]
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

            #endregion

            #region Test

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion
        }

        [Test]
        [Order(2)]
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
            
            var requestBodyCreateBroker = BrokerCreation.RequestBodyCreateBroker();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            var responceBroker = BrokerCreation.CreateBroker(responseMarketplaceAdmin.AuthData.Token, requestBodyCreateBroker);

            #endregion

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(requestBodyCreateBroker.Email, marketplaceId);
            WaitUntil.WaitSomeInterval(100);
            LandlordsBrokersDbRequests.LandlordsBrokers.DeleteNewlyCreatedBroker(requestBodyCreateBroker.Email, marketplaceId);

            #endregion
        }

        [Test]
        [Order(3)]
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

            var bodyRequestCreateAgent = AgentCreation.RequestBodyCreateAgent();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            var responseAgent = AgentCreation.CreateAgent(responseMarketplaceAdmin.AuthData.Token, bodyRequestCreateAgent);

            #endregion

            #region Postconditions test

            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(bodyRequestCreateAgent.Email, marketplaceId);
            Console.WriteLine($"{bodyRequestCreateAgent.Email}");
            WaitUntil.WaitSomeInterval(100);
            BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(bodyRequestCreateAgent.Email, marketplaceId);

            #endregion
        }

        [Test]
        [Order(4)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateOwnerOwnerAndTenantPaysWithBroker")]

        public void CreateOwnerOwnerAndTenantPaysWithBroker()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var requestBodyOwner = OwnerCreation.RequestBodyCreateOwnerOwnerAndTenantPaysBr();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            OwnerCreation.CreateOwnerOwnerAndTenantPaysBr(responseMarketplaceAdmin.AuthData.Token, requestBodyOwner);

            #endregion

            #region Postconditions

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(requestBodyOwner.OwnerEmail, marketplaceId);

            #endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateOwnerNoCommissionWithAgent")]

        public void CreateOwnerNoCommissionWithAgent()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var requestBodyOwner = OwnerCreation.RequestBodyOwnerNoCommissionAg();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            OwnerCreation.CreateOwnerNoCommissionAg(responseMarketplaceAdmin.AuthData.Token, requestBodyOwner);

            #endregion

            #region Postconditions

            OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(requestBodyOwner.OwnerEmail, marketplaceId);

            #endregion
        }

        [Test]
        [Order(6)]
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

            //MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            //var buildingBody = BuildingCreation.RequestBodyCreateBuildingFullDataBroker();

            //#endregion

            //#region Preconditions

            //var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            //LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            //#endregion

            //#region Tests

            //BuildingCreation.CreateBuildingWithBrokerFullData(responseMarketplaceAdmin.AuthData.Token, buildingBody);

            //#endregion
        }

        [Test]
        [Order(7)]
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

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            #endregion

            #region Preconditions

            var buildingRequestBody = BuildingCreationMandatoryData.RequestBodyCreateBuildingMandatoryDataWithAgent();

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            var responseBuilding = BuildingCreationMandatoryData.CreateBuildingMandatoryDataWithAgent(responseMarketplaceAdmin.AuthData.Token, buildingRequestBody);

            #endregion
        }

        [Test]
        [Order(8)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("MarketplaceAdmin Api test")]
        [AllureSubSuite("CreateApartmentMandatoryData")]

        public void CreateApartmentMandatoryData()
        {
            #region SettingsForBuilding

            //9998 Saint Johnson Place

            #endregion

            #region Test Data

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var requestBodyApartment = ApartmentCreation.RequestBodyCreateApartmentMandatoryData();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

            LogInApiMarketplaceAdmin.VerifyUserData(responseMarketplaceAdmin, marketplaceAdmin);

            #endregion

            #region Tests

            ApartmentCreation.CreateApartmentMandatoryData(responseMarketplaceAdmin.AuthData.Token, requestBodyApartment);

            #endregion
        }
    }
}
