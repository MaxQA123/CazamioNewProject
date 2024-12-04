using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentViewPage
{
    public partial class ApartmentView
    {
        [AllureStep("EnterNewEmailFirstLastNames")]
        public ApartmentView EnterNewEmailFirstLastNames()
        {
            WaitUntil.CustomElementIsVisible(FieldInputGetApplicationLink);
            InputGeneral.InputFunctionWithClear(FieldInputGetApplicationLink, application.TenantsData.EmailNewTenantMainApplicant);
            WaitUntil.CustomElementIsVisible(FieldInputFirstName);
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, application.TenantsData.FirstNameNewTenantMainApplicant);
            WaitUntil.CustomElementIsVisible(FieldInputLastName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, application.TenantsData.LastNameNewTenantMainApplicant);

            return this;
        }
    }
}
