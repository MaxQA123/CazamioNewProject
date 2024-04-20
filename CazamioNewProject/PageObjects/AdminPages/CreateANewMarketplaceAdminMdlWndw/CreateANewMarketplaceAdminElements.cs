﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw
{
    public partial class CreateANewMarketplaceAdminMdlWindow
    {
        [FindsBy(How = How.XPath, Using = ("//h2[text() = 'Create a new Marketplace admin']"))]
        public IWebElement TitleCreateANewMarketplaceadmin;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'first-name']")]
        public IWebElement FieldInputFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'last-name']")]
        public IWebElement FieldInputLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'email']")]
        public IWebElement FieldInputEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'subDomain']")]
        public IWebElement FieldInputMarketplaceSubdomain;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = 'Create']")]
        public IWebElement ButtonCreate;

        [FindsBy(How = How.XPath, Using = ("//label[text() = 'Host : https://testlandlord15-demo.casamio-test.lol/']"))]
        public IWebElement NameHostMarketplaceSubdomain;
    }
}
