using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [AllureStep("Enter first, last names, email broker's")]
        public CreateANewBrokerMdlWndw EnterFirstLastNamesEmail()
        {
            InputGeneral.InputFunctionWithClear(FieldInputFirstName, broker.BrokerName.FirstNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputLastName, broker.BrokerName.LastNameRandom);
            InputGeneral.InputFunctionWithClear(FieldInputEmail, broker.BrokerEmail.FullEmailRandom);

            return this;
        }
    }
}
