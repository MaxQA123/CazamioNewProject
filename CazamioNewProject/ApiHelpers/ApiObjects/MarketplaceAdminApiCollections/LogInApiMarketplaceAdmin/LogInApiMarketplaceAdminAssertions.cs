using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.ApiHelpers.ApiObjects.MarketplaceAdminApiCollections.LogInApiMarketplaceAdmin
{
    public partial class LogInApiMarketplaceAdmin
    {
        [AllureStep("VerifyUserData")]
        public static void VerifyUserData(ResponseLogInApiMarketplaceAdmin responseMarketplaceAdmin, MarketplaceAdmin marketplaceAdmin)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(marketplaceAdmin.CreatedMarkAdmMySpace.FullName, responseMarketplaceAdmin.AuthData.User.UserName, $"Name not equal");
                Assert.AreEqual(marketplaceAdmin.CreatedMarkAdmMySpace.Email, responseMarketplaceAdmin.AuthData.User.UserEmail, $"Email not equal");
                Assert.AreEqual(GeneralTestDataForAllUsers.MARKETPLACE_ID_MY_SPACE, responseMarketplaceAdmin.MarketplaceId, $"MarketplaceId not equal");
            });
        }
    }
}
