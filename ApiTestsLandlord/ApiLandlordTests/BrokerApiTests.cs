using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.BrokerApiCollections.LogInApiBroker;
using CazamioNewProject.CreateApartmentMandatoryDataApi;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class BrokerApiTests
    {
        //Amount order 4 next must be 5
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test Data

            Broker broker = Broker.Generate();


            #endregion

            #region Test

            var responseBroker = LogInApiBroker.ExecuteLogIn();

            LogInApiBroker.VerifyUserData(responseBroker, broker);

            #endregion
        }

        [Test]
        [Order(2)]
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

            //Broker broker = Broker.Generate();

            //Agent agent = Agent.Generate();

            //var firstNameAgent = agent.FirstName;
            //var lastNameAgent = agent.LastName;
            //var emailAgent = agent.EmailAddress;
            //var phoneNumberAgent = agent.PhoneNumber;
            //var brokerCommissionAgent = agent.BrokerCommissionApi;
            //var agentCommissionAgent = agent.AgentCommissionApi;
            //var cellAgent = agent.Cell;

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn();

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
        [Order(4)]
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

            //Broker broker = Broker.Generate();

            //var ownerBody = OwnerCreation.RequestCreateOwnerWithTenantPays();

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn();

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion

            //#region Tests

            //OwnerCreation.CreateOwnerWithTenantPays(responseBroker.AuthData.Token, ownerBody);

            //#endregion

            //#region Postconditions

            //OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(ownerBody.OwnerEmail, marketplaceId);

            //#endregion
        }

        [Test]
        [Order(3)]
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

            //int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;

            //Broker broker = Broker.Generate();

            //var ownerBody = OwnerCreation.RequestBodyRequiredFieldsManagements();

            //#endregion

            //#region Preconditions

            //var responseBroker = LogInApiBroker.ExecuteLogIn();

            //LogInApiBroker.VerifyUserData(responseBroker, broker);

            //#endregion

            //#region Tests

            //OwnerCreation.CreateOwnerRequiredFieldsManagements(responseBroker.AuthData.Token, ownerBody);

            //#endregion

            //#region Postconditions

            //OwnersDbRequests.DBOwners.DeleteNewlyCreatedOwner(ownerBody.OwnerEmail, marketplaceId);

            //#endregion
        }

        [Test]
        [Order(5)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("Broker Api test")]
        [AllureSubSuite("CreateApartmentApplicationSubmitted")]

        public void CreateApartmentApplicationSubmitted()
        {
            #region Test Data

            Broker broker = Broker.Generate();

            var requestBodyApartment = ApartmentCreation.RequestBodyCreateApartmentApplicationSubmitted();

            #endregion

            #region Preconditions

            var responseBroker = LogInApiBroker.ExecuteLogIn();

            LogInApiBroker.VerifyUserData(responseBroker, broker);

            #endregion

            #region Tests

            ApartmentCreation.CreateApartmentApplicationSubmitted(responseBroker.AuthData.Token, requestBodyApartment);

            #endregion
        }
    }
}
