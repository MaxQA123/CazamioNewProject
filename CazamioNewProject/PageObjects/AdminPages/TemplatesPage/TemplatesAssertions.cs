using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("Verify Title Templates page")]
        public Templates VerifyTitleTemplatesPage()
        {
            WaitUntil.CustomElementIsVisible(TitleTemplatesPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleTemplatesPage));

            return this;
        }

        [AllureStep("VerifyTitleCreateTemplatePage")]
        public Templates VerifyTitleCreateTemplatePage()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleCreateTemplatePage));

            return this;
        }

        [AllureStep("VerifyDeletingItemFirstNameForMySpaceTemplate")]
        public Templates VerifyDeletingItemFirstNameForMySpaceTemplate()
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(5));
            wait.Until(driver =>
                driver.FindElements(By.XPath($"//app-template-list//table//tbody//td[text() = '{leaseSignDocument.TemplatesNameByMarketplaces.FirstNameForMySpace}']")).Count == 0
            );

            return this;
        }

        [AllureStep("VerifyDeletingItemSecondNameForMySpaceTemplate")]
        public Templates VerifyDeletingItemSecondNameForMySpaceTemplate()
        {
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(5));
            wait.Until(driver =>
                driver.FindElements(By.XPath($"//app-template-list//table//tbody//td[text() = '{leaseSignDocument.TemplatesNameByMarketplaces.SecondNameForMySpace}']")).Count == 0
            );

            return this;
        }
    }
}
