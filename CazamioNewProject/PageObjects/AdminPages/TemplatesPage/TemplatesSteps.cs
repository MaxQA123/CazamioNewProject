using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("CreateNewTemplateFullDataUserMarketplaceAdmin")]
        public Templates CreateNewTemplateFullDataUserMarketplaceAdmin()
        {
            WaitUntil.CustomElementIsVisible(LoaderHidden, 10);
            Button.Click(CreateNewTemplateBtn);
            VerifyTitleCreateTemplatePage();
            Button.Click(SelectBrokerBtn);
            WaitUntil.CustomElementIsVisible(SelectFullNameBrokerItem());
            Button.Click(SelectFullNameBrokerItem());
            WaitUntil.CustomElementIsVisible(TemplateNameOfFieldInput);
            InputGeneral.InputFunctionWithClear(TemplateNameFieldInput, leaseSignDocument.TemplatesNameByMarketplaces.FirstNameForMySpace);
            UploadDocumentBtn.SendKeys(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\") + UploadTemplatesLandlord.FIRST_NAME_FOR_MYSPACE));
            DragAndDropBrokerSignToDocumentArea();
            Button.Click(SaveTemplateBtn);

            return this;
        }
    }
}
