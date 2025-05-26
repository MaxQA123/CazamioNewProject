using Allure.Commons;
using CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.CreateMarketplaceAdmin;
using CazamioNewProject.ApiHelpers.ApiObjects.SuperAdminApiCollections.LogInApiSuperAdmin;
using CazamioNewProject.DbHelpers.AspNetUsersTable;
using CazamioNewProject.DbHelpers.MarketplaceAdminsTable;
using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using CazamioNewProject.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsEmailsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class EmailsLandlordTests : EmailsLandlordBase
    {
        //Amount order 8 next must be 9
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(2)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("EmailsNotificationsLandlordsMySpace")]
        [AllureSubSuite("EmailWhenCreatingMarketplaceadmin")]

        public void EmailWhenCreatingMarketplaceadmin()
        {
            #region Test Data

            int marketplaceId = GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE;
            EmailNotificationsForMarketplaceAdmin emailNotificationsForMarketplaceAdmin = EmailNotificationsForMarketplaceAdmin.Generate();

            #endregion

            #region Preconditions API Login as Super Admin

            var superAdminRequest = LogInApiSuperAdmin.RequestBodyLogInSuperAdmin();
            var responseSuperAdmin = LogInApiSuperAdmin.LogInSuperAdmin(superAdminRequest);

            #endregion

            #region Preconditions API create Marketplace Admin

            var createMarketplaceAdminRequestBody = MarketplaceAdminCreation.RequestBodyCreateMarketplaceAdmin();
            MarketplaceAdminCreation.CreateMarketplaceAdmin(responseSuperAdmin.Data.AuthData.Token, createMarketplaceAdminRequestBody);
            var dataMarketplaceAdmin = createMarketplaceAdminRequestBody.Email;
            var partEmailPutsBox = dataMarketplaceAdmin.Split('@')[0];

            #endregion

            #region Preconditions GUI

            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);

            //string subjectNotificationFromEmail = 

            Pages.EmailPutsBox
                .VerifySubjectNotificationCreateAdmin()
                .ClickButtonHtml();

            #endregion


            #region Test



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
