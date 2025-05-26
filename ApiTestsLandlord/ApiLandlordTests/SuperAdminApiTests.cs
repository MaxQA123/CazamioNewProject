using Allure.Commons;
using CazamioNewProject.ApiHelpers;
using CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.LogInApiSuperAdmin;
using CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.MarketplaceAdminsTable;

namespace ApiTestsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class SuperAdminApiTests
    {
        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin Api test")]
        [AllureSubSuite("LogIn")]

        public void LogIn()
        {
            #region Test Data

            SuperAdmin superAdmin = SuperAdmin.Generate();

            #endregion

            #region Test

            var superAdminRequest = LogInApiSuperAdmin.RequestBodyLogInSuperAdmin();
            var response = LogInApiSuperAdmin.LogInSuperAdmin(superAdminRequest);
            var responseData = response.Data;


            #endregion
        }

        [Test]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("SuperAdmin Api test")]
        [AllureSubSuite("CreateMarketplaceAdmin")]

        public void CreateMarketplaceAdmin()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            SuperAdmin superAdmin = SuperAdmin.Generate();

            #endregion

            #region Preconditions

            var superAdminRequest = LogInApiSuperAdmin.RequestBodyLogInSuperAdmin();
            var responseSuperAdmin = LogInApiSuperAdmin.LogInSuperAdmin(superAdminRequest);
            var responseData = responseSuperAdmin.Data.AuthData.Token;

            #endregion

            #region Test

            var createMarketplaceAdminRequestBody = MarketplaceAdminCreation.RequestBodyCreateMarketplaceAdmin();
            MarketplaceAdminCreation.CreateMarketplaceAdmin(responseSuperAdmin.Data.AuthData.Token, createMarketplaceAdminRequestBody);

            #endregion

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(createMarketplaceAdminRequestBody.Email, marketplaceId);
            Console.WriteLine($"{createMarketplaceAdminRequestBody.Email}");
            WaitUntil.WaitSomeInterval(100);
            MarketplaceAdminsDbRequests.MarketplaceAdmins.DeleteNewlyCreatedMarketplaceAdmin(createMarketplaceAdminRequestBody.Email, marketplaceId);

            #endregion
        }
    }
}
