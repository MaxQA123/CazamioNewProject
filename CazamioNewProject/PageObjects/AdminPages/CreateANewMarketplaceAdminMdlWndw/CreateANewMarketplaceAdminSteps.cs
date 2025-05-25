using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw
{
    public partial class CreateANewMarketplaceAdminMdlWindow
    {
        [AllureStep("FillInMandatoryFields")]
        public CreateANewMarketplaceAdminMdlWindow FillInMandatoryFields()
        {
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, marketplaceAdmin.MarkAdmName.FirstNameRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, marketplaceAdmin.MarkAdmName.LastNameRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, marketplaceAdmin.MarkAdmEmail.FullEmailRandom);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputMarketplaceSubdomain, basicDataForProject.SubdomainMarketplace.MySpace);

            return this;
        }
    }
}
