using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("CreateNewTemplateFullData")]
        public Templates CreateNewTemplateFullData()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            Button.Click(CreateNewTemplateBtn);
            VerifyTitleCreateTemplatePage();
            Button.Click(SelectBrokerBtn);
            WaitUntil.CustomElementIsVisible(SelectFullNameBrokerItem());
            Button.Click(SelectFullNameBrokerItem());
            WaitUntil.CustomElementIsVisible(TemplateNameOfFieldInput);
            InputGeneral.InputFunctionWithClear(TemplateNameFieldInput, leaseSignDocument.TemplatesNameByMarketplaces.FirstNameForMySpace);

            return this;
        }
    }
}
