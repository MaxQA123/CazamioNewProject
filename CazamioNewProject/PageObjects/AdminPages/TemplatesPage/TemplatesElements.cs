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
        #region Templates page

        [FindsBy(How = How.XPath, Using = ("//app-loader//div[@class = 'hidden']"))]
        public IWebElement LoaderHidden;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'Templates']")]
        public IWebElement TitleTemplatesPage;

        [FindsBy(How = How.XPath, Using = "//cazamio-button[@text = 'Create new template']//button")]
        public IWebElement CreateNewTemplateBtn;

        public IWebElement ItemDeleteBtnForFirstNameForMySpace()
        {
            var xpath = "//app-template-list//table//tbody//tr[td[text() = '" + leaseSignDocument.TemplatesNameByMarketplaces.FirstNameForMySpace + "']]//button[@title='Delete']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement ItemFirstNameForMySpaceTemplate()
        {
            var xpath = "//app-template-list//table//tbody//td[text() = '" + leaseSignDocument.TemplatesNameByMarketplaces.FirstNameForMySpace + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement ItemDeleteBtnForSecondNameForMySpace()
        {
            var xpath = "//app-template-list//table//tbody//tr[td[text() = '" + leaseSignDocument.TemplatesNameByMarketplaces.SecondNameForMySpace + "']]//button[@title='Delete']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        public IWebElement ItemSecondNameForMySpace()
        {
            var xpath = "//app-template-list//table//tbody//td[text() = '" + leaseSignDocument.TemplatesNameByMarketplaces.SecondNameForMySpace + "']";

            return Browser._Driver.FindElement(By.XPath(xpath));
        }

        #endregion

        #region Create template page

        [FindsBy(How = How.XPath, Using = "//div[text()= 'Create template']")]
        public IWebElement TitleCreateTemplatePage;

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

        [FindsBy(How = How.XPath, Using = "//app-lease-sign-document//input[@type='file' and @id='file-upload']")]
        public IWebElement UploadDocumentBtn;

        [FindsBy(How = How.XPath, Using = "//app-lease-sign-document//button[@title = 'Save Template']")]
        public IWebElement SaveTemplateBtn;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'document-area']")]
        public IWebElement DocumentArea;

        #endregion

        #region list of tags on Create template page

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Apartment Address ']")]
        public IWebElement ApartmentAddressItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Apartment Name ']")]
        public IWebElement ApartmentNameItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Utilities included ']")]
        public IWebElement UtilitiesIncludedItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Lease Term ']")]
        public IWebElement LeaseTermItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Move in Date ']")]
        public IWebElement MoveInDateItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Lease End Date ']")]
        public IWebElement LeaseEndDateItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Total Rent ']")]
        public IWebElement TotalRentItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Monthly Rent ']")]
        public IWebElement MonthlyRentItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Deposit ']")]
        public IWebElement DepositItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Current Date ']")]
        public IWebElement CurrentDateItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Total Move In Cost ']")]
        public IWebElement TotalMoveInCostItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Broker Sign ']")]
        public IWebElement BrokerSignItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Broker First Name ']")]
        public IWebElement BrokerFirstNameItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' Broker Last Name ']")]
        public IWebElement BrokerLastNameItem;

        [FindsBy(How = How.XPath, Using = "//app-template-constructor//div[@class = 'sticky-list']//span[text() = ' LLC Name ']")]
        public IWebElement LLCNameItem;

        #endregion
    }
}
