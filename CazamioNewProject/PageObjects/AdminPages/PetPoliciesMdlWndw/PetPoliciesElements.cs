using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace CazamioNewProject.PageObjects.AdminPages.PetPoliciesMdlWndw
{
    public partial class PetPoliciesMdlWndw
    {
        [FindsBy(How = How.XPath, Using = "//h2[text() = 'Pet policies']")]
        public IWebElement TitlePetPolicies;

        [FindsBy(How = How.CssSelector, Using = "div mat-checkbox")]
        public IList<IWebElement> PetPoliciesList;

        [FindsBy(How = How.XPath, Using = "//button//span[(text() = 'Save')]")]
        public IWebElement ButtonSave;
    }
}
