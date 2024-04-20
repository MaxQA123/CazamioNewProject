using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [AllureStep("Enter first, last names, email broker's")]
        public CreateANewBrokerMdlWndw EnterFirstLastNamesEmail()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, broker.FirstName);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, broker.LastName);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, broker.EmailAddress);

            return this;
        }
    }
}
