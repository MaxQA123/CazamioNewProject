using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewBrokerMdlWndw
{
    public partial class CreateANewBrokerMdlWndw
    {
        [AllureStep("Enter first, last names, email broker's")]
        public CreateANewBrokerMdlWndw EnterFirstLastNamesEmail()
        {
            EnterFirstName();
            EnterLastName();
            EnterEmail();

            return this;
        }
    }
}
