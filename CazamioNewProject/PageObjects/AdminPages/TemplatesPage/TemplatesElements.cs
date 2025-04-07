using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'Templates']")]
        public IWebElement TitleTemplatesPage;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'Create template']")]
        public IWebElement TitleCreateTemplatePage;

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Create new template']//button")]
        public IWebElement CreateNewTemplateBtn;

        [FindsBy(How = How.XPath, Using = "//app-lease-sign-document//ng-select[@id = 'broker']")]
        public IWebElement SelectBrokerBtn;

        public IWebElement SelectFullNameBrokerItem()
        {
            Broker broker = Broker.Generate();
            string xpath = $"//app-lease-sign-document//ng-dropdown-panel//span[text()='{broker.CreatedBrokerMySpace.FullName}']";

            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100), // Проверка каждые 100 мс
            };

            // Ожидаем, пока элемент не станет видимым
            return wait.Until(drv =>
            {
                try
                {
                    var element = drv.FindElement(By.XPath(xpath));
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
        }

        [FindsBy(How = How.XPath, Using = "//app-lease-sign-document//label[text()='Template Name']")]
        public IWebElement TemplateNameOfFieldInput;

        [FindsBy(How = How.XPath, Using = "//app-lease-sign-document//label[text()='Template Name']/following-sibling::*[1]")]
        public IWebElement TemplateNameFieldInput;
    }
}
