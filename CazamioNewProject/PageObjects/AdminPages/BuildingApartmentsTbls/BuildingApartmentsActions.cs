﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartmentsTbl
    {
        //BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

        [AllureStep("ClickFirstRow")]
        public BuildingApartmentsTbl ClickFirstRow()
        {
            WaitUntil.CustomElementIsVisible(FirstRow);
            WaitUntil.CustomElementIsClickable(FirstRow);
            Button.Click(FirstRow);

            return this;
        }

        [AllureStep("ClickRowByDepositReceived")]
        public void ClickRowByDepositReceived()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.DepositReceived + "']";

            // Создаём объект WebDriverWait с таймаутом
            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            // Ждём, пока элемент станет доступным, и выполняем клик
            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        [AllureStep("ClickRowByOffMarket")]
        public void ClickRowByOffMarket()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.OffMarket + "']";

            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        [AllureStep("ClickRowByVacant")]
        public void ClickRowByVacant()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.Vacant + "']";

            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        [AllureStep("ClickRowByOccupied")]
        public void ClickRowByOccupied()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.Occupied + "']";

            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        [AllureStep("ClickRowByApplicationSubmitted")]
        public void ClickRowByApplicationSubmitted()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.ApplicationSubmitted + "']";

            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        public void ClickRowBySignedLease()
        {
            WaitUntil.WaitSomeInterval(500);
            BuildingApartmentsTable buildingApartmentsTable = BuildingApartmentsTable.Generate();

            var xpath = "//table//tbody//tr//td[text() = '" + buildingApartmentsTable.StatusColumn.SignedLease + "']";

            WebDriverWait wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            var element = wait.Until(driver => driver.FindElement(By.XPath(xpath)));
            element.Click();
        }

        [AllureStep("GetVlOfClmnUnitFrstRw")]
        public string GetVlOfClmnUnitFrstRw()
        {
            WaitUntil.CustomElementIsVisible(VlOfClmnUnitFrstRw);
            string unitNumber = VlOfClmnUnitFrstRw.Text;

            return unitNumber;
        }
    }
}
