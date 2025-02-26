﻿using Allure.Commons;
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
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(requestBodyCreateBroker.Email, marketplaceId);

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
            WaitUntil.WaitSomeInterval(100);
            AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(bodyRequestCreateAgent.Email, marketplaceId);

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

            //var ownerBody = OwnerCreation.RequestBodyBrokerFullData();

            //#endregion

            //#region Preconditions

            //var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

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

            var ownerBody = OwnerCreation.RequestBodyAgentRequiredData();

            #endregion

            #region Preconditions

            var responseMarketplaceAdmin = LogInApiMarketplaceAdmin.ExecuteLogIn();

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
    }
}
