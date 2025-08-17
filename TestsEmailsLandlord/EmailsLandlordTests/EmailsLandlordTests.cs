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

namespace TestsEmailsLandlord
{
    [TestFixture]
    [AllureNUnit]

    public class EmailsLandlordTests : EmailsLandlordBase
    {
        //Amount order 1 next must be 2
        [Test]
        [Order(1)]
        [AllureTag("Regression")]
        [AllureOwner("Maksim Perevalov")]
        [AllureSeverity(SeverityLevel.critical)]
        [Retry(1)]
        [Author("Maksim", "maxqatesting390@gmail.com")]
        [AllureSuite("EmailsNotificationsLandlordsMySpace")]
        [AllureSubSuite("VerifyEmailWhenCreatingMarketplaceAdmin")]

        public void VerifyEmailWhenCreatingMarketplaceAdmin()
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
            var emailMarketplaceAdmin = createMarketplaceAdminRequestBody.Email;
            var partEmailPutsBox = emailMarketplaceAdmin.Split('@')[0];

            #endregion

            #region Preconditions GUI

            Pages.JScriptExecutor
                .OpenNewTab();
            Pages.EmailHelper
                .OpenPutsBox(Pages.EmailPutsBox.SubjectNotificationCommon, partEmailPutsBox);

            string fullEmailPutsBox = Pages.EmailPutsBox.GetFullEmailFromYourPutsBoxEmailFieldInput();

            #endregion

            #region Test

            Pages.EmailPutsBox
                .VerifyComparisonSubjectNotificationCreateMarketplaceAdmin()
                .ClickButtonHtml()
                .VerifyComparisonBodyNotificationCreateMarketplaceAdmin(fullEmailPutsBox);

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
