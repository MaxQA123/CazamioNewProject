using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.LogInPage
{
    public partial class LogInLandlord
    {
        [AllureStep("EnterEmailPasswordAsSuperAdmin")]
        public LogInLandlord EnterEmailPasswordAsSuperAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, superAdmin.EmailAddressSuperAdmin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsMarketplaceAdmin")]
        public LogInLandlord EnterEmailPasswordAsMarketplaceAdmin()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, marketplaceAdmin.EmailAddressMarketplaceAdmin);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }

        [AllureStep("EnterEmailPasswordAsBroker")]
        public LogInLandlord EnterEmailPasswordAsBroker()
        {
            InputGeneral.InputFunctionWithClear(FieldInputEmailLogInPg, broker.EmailAddressBroker);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputPasswordLogInPg, GeneralTestDataForAllUsers.PASSWORD_GENERAL);

            return this;
        }
    }
}
