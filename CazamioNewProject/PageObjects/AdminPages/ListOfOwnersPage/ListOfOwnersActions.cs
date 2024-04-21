using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfOwnersPage
{
    public partial class ListOfOwners
    {
        [AllureStep("ClickButtonCreateOwner")]
        public ListOfOwners ClickButtonCreateOwner()
        {
            Pages.JScriptExecutor
                .WaitLoader();
            WaitUntil.CustomElementIsVisible(ButtonCreateOwner);
            WaitUntil.CustomElementIsClickable(ButtonCreateOwner);
            Button.Click(ButtonCreateOwner);

            return this;
        }

        [AllureStep("GetFirstEmailFromTable")]
        public string GetFirstEmailFromTable()
        {
            WaitUntil.CustomElementIsVisible(FirstOwnerEmailOnPage);
            string getEmail = FirstOwnerEmailOnPage.Text;
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }
    }
}
