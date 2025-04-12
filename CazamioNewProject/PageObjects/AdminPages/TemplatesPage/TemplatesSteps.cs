using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.IO;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("CreateNewTemplateWithBrokerSignUserMarketplaceAdmin")]
        public Templates CreateNewTemplateWithBrokerSignUserMarketplaceAdmin()
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
            Pages.ToasterMessagesLandlord
                .VerifMessageTemplateWasSaved();

            return this;
        }

        [AllureStep("DeleteItemFirstNameForMySpace")]
        public Templates DeleteItemFirstNameForMySpace()
        {
            Button.Click(ItemDeleteBtnForFirstNameForMySpace());
            Pages.AreYouSureDeleteTemplteMdlWndw
                .ConfirmDeleteTemplate();
            VerifyDeletingItemFirstNameForMySpaceTemplate();

            return this;
        }
    }
}
