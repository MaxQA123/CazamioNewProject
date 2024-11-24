using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        //BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

        [AllureStep("ClickFirstRow")]
        public BuildingApartments ClickFirstRow()
        {
            WaitUntil.CustomElementIsVisible(FirstRow);
            WaitUntil.CustomElementIsClickable(FirstRow);
            Button.Click(FirstRow);

            return this;
        }

        [AllureStep("ClickRowByDepositReceived")]
        public void ClickRowByDepositReceived()
        {
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.DepositReceived + "']";

            // Создаём объект WebDriverWait с таймаутом
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            // Ждём, пока элемент станет доступным, и выполняем клик
            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }
    }
}
