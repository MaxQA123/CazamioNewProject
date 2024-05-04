using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin
{
    public partial class LogInApiMarketplaceAdmin
    {
        [AllureStep("VerifyingUserNameEmailTenant")]
        public static void VerifyUserData(ResponseLogInApiMarketplaceAdmin responseMarketplaceAdmin, MarketplaceAdmin marketplaceAdmin)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(marketplaceAdmin.FullNameMarketplaceAdmin, responseMarketplaceAdmin.AuthData.User.UserName, $"Name not equal");
                Assert.AreEqual(marketplaceAdmin.EmailAddressMarketplaceAdmin, responseMarketplaceAdmin.AuthData.User.UserEmail, $"Email not equal");
                Assert.AreEqual(GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE, responseMarketplaceAdmin.MarketplaceId, $"MarketplaceId not equal");
            });
        }
    }
}
