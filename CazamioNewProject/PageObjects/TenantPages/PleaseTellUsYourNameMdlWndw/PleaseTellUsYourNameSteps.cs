using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.PleaseTellUsYourNameMdlWndw
{
    public partial class PleaseTellUsYourNameMdlWndw
    {
        [AllureStep("QuicklyPassForMainApplicant")]
        public PleaseTellUsYourNameMdlWndw QuicklyPassForMainApplicant()
        {
            VerifyTitle();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName,tenantCreatorMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantCreatorMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSecondSuccessfullyUpdatedName();

            return this;
        }

        [AllureStep("QuicklyPassForOccupant")]
        public PleaseTellUsYourNameMdlWndw QuicklyPassForOccupant()
        {
            VerifyTitle();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantOccupantMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantOccupantMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSecondSuccessfullyUpdatedName();

            return this;
        }

        [AllureStep("QuicklyPassForGuarantor")]
        public PleaseTellUsYourNameMdlWndw QuicklyPassForGuarantor()
        {
            VerifyTitle();
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, tenantGuarantorMySpace.FirstLastNameGeneralData.RandomFirstName);
            WaitUntil.WaitSomeInterval(100);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, tenantGuarantorMySpace.FirstLastNameGeneralData.RandomLastName);
            WaitUntil.CustomElementIsClickable(BtnSave);
            Button.Click(BtnSave);
            Pages.ToasterMessagesTenants
                .VerifyMessageSecondSuccessfullyUpdatedName();

            return this;
        }
    }
}
