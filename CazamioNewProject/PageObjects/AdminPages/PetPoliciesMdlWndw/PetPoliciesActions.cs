using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.PetPoliciesMdlWndw
{
    public partial class PetPoliciesMdlWndw
    {
        private static IWebElement _elementPetPolicies;

        [AllureStep("SelectorPetPolicies")]
        public static IList<IWebElement> SelectorPetPolicies()
        {
            WaitUntil.WaitSomeInterval(1000);
            return _elementPetPolicies.FindElements(By.XPath($".//div//mat-checkbox]"));
        }

        [AllureStep("SelectItemPetPolocies")]
        public PetPoliciesMdlWndw SelectItemPetPolocies(int numberItem)
        {
            Button.Click(PetPoliciesList[numberItem]);

            return this;
        }

        [AllureStep("ClickButtonSave")]
        public PetPoliciesMdlWndw ClickButtonSave()
        {
            Button.Click(ButtonSave);

            return this;
        }
    }
}
