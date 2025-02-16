using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateAgentApi;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.CreateOwnerApi;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.BrokersAgentsTable;
using CazamioNewProject.DbHelpers.OwnerCommissionsStructureTable;
using CazamioNewProject.DbHelpers.OwnerManagementsTable;
using CazamioNewProject.DbHelpers.OwnerPhoneNumbersTable;
using CazamioNewProject.DbHelpers.OwnersDbTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;

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
            //#region Test Data

            //Broker broker = new Broker().Generate();

            //var email = broker.EmailAddressBroker;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = broker.DeviceFingerprint;

            //#endregion

            //#region Test

            //var responseBroker = LogInApiBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("CreateAgent")]

        public void CreateAgent()
        {
            //#region Test Data

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //Broker broker = new Broker().Generate();

            //var email = broker.EmailAddressBroker;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = broker.DeviceFingerprint;

            //Agent agent = new Agent().Generate();

            //var firstNameAgent = agent.FirstName;
            //var lastNameAgent = agent.LastName;
            //var emailAgent = agent.EmailAddress;
            //var phoneNumberAgent = agent.PhoneNumber;
            //var brokerCommissionAgent = agent.BrokerCommissionApi;
            //var agentCommissionAgent = agent.AgentCommissionApi;
            //var cellAgent = agent.Cell;

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion

            //#region Tests

            //AgentCreation.CreateAgent(responseBroker.AuthData.Token, firstNameAgent, lastNameAgent, emailAgent, phoneNumberAgent, brokerCommissionAgent, agentCommissionAgent, cellAgent);

            //#endregion

            //#region Postconditions

            //WaitUntil.WaitSomeInterval(100);
            //AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(emailAgent, marketplaceId);
            //Console.WriteLine($"{emailAgent}");
            //WaitUntil.WaitSomeInterval(100);
            //BrokersAgentsDbRequests.BrokersAgents.DeleteNewlyCreatedAgent(emailAgent, marketplaceId);
            //WaitUntil.WaitSomeInterval(100);
            //AspNetUsersDbRequests.AspNetUsers.DeleteCreatedUser(emailAgent, marketplaceId);

            //#endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("CreateOwnerWithTenantPays")]

        public void CreateOwnerWithTenantPays()
        {
            //#region Test Data

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //Broker broker = new Broker().Generate();

            //var email = broker.EmailAddressBroker;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = broker.DeviceFingerprint;

            //var ownerBody = OwnerCreation.RequestCreateOwnerWithTenantPays();

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion

            //#region Tests

            //OwnerCreation.CreateOwnerWithTenantPays(responseBroker.AuthData.Token, ownerBody);

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
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("CreateOwnerWithoutPays")]

        public void CreateOwnerWithoutPays()
        {
            //#region Test Data

            //Broker broker = new Broker().Generate();

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //var email = broker.EmailAddressBroker;
            //var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            //var rememberMe = ApiRequestData.TRUE;
            //var deviceFingerprint = broker.DeviceFingerprint;

            //var ownerBody = OwnerCreation.RequestBodyRequiredFieldsManagements();

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion

            //#region Tests

            //OwnerCreation.CreateOwnerRequiredFieldsManagements(responseBroker.AuthData.Token, ownerBody);

            //#endregion

            //#region Postconditions

            //OwnerCommissionsStructureDbRequests.OwnerCommissionsStructure.DeleteRecordAboutOwnerCommissionsStructure(ownerBody.OwnerEmail, marketplaceId);
            //Console.WriteLine($"{ownerBody.OwnerEmail}");
            //OwnerPhoneNumbersDbRequests.OwnerPhoneNumbers.DeleteRecordAboutOwnerPhoneNumber(ownerBody.OwnerEmail, marketplaceId);
            //OwnerManagementsDbRequsts.OwnerManagements.DeleteRecordAboutOwnerManagements(ownerBody.OwnerEmail, marketplaceId);
            //OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(ownerBody.OwnerEmail, marketplaceId);

            //#endregion
        }
    }
}
