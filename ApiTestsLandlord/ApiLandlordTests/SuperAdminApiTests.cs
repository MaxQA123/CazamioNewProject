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

            SuperAdmin superAdmin = new SuperAdmin().Generate();

            var email = superAdmin.EmailAddressSuperAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = superAdmin.DeviceFingerprint;

            #endregion

            #region Test

            var responseSuperAdmin = LogInApiSuperAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiSuperAdmin.VerifyUserData(responseSuperAdmin, superAdmin);

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

            SuperAdmin superAdmin = new SuperAdmin().Generate();

            var email = superAdmin.EmailAddressSuperAdmin;
            var password = GeneralTestDataForAllUsers.PASSWORD_GENERAL;
            var rememberMe = ApiRequestData.TRUE;
            var deviceFingerprint = superAdmin.DeviceFingerprint;

            MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

            var firstNameMarkAdm = marketplaceAdmin.MarkAdmName.FirstNameRandom;
            var lastNameMarkAdm = marketplaceAdmin.MarkAdmName.LastNameRandom;
            var emailMarkAdm = marketplaceAdmin.MarkAdmEmail.FullEmail;
            var passwordMarkAdm = "";
            var subdomainMarkAdm = marketplaceAdmin.SubdomainMarketplace.MySpace;

            #endregion

            #region Preconditions

            var responseSuperAdmin = LogInApiSuperAdmin.ExecuteLogIn(email, password, deviceFingerprint, rememberMe);

            LogInApiSuperAdmin.VerifyUserData(responseSuperAdmin, superAdmin);

            #endregion

            #region Test

            MarketplaceAdminCreation.CreateMarketplaceAdmin(responseSuperAdmin.AuthData.Token, firstNameMarkAdm, lastNameMarkAdm, emailMarkAdm, passwordMarkAdm, subdomainMarkAdm);

            #endregion

            #region Postconditions

            AspNetUsersDbRequests.AspNetUsers.GetEmailByEmailAndMarketplaceId(emailMarkAdm, marketplaceId);
            Console.WriteLine($"{emailMarkAdm}");
            WaitUntil.WaitSomeInterval(100);
            MarketplaceAdminsDbRequests.MarketplaceAdmins.DeleteNewlyCreatedMarketplaceAdmin(emailMarkAdm, marketplaceId);

            #endregion
        }
    }
}
