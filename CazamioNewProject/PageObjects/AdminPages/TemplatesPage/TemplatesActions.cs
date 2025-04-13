using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        LeaseSignDocument leaseSignDocument = LeaseSignDocument.Generate();

        [AllureStep("DragAndDropApartmentAddressToDocumentArea")]
        public Templates DragAndDropApartmentAddressToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => ApartmentAddressItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                ApartmentAddressItem);

            int xOffset = 200;
            int yOffset = 50;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(ApartmentAddressItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropApartmentNameToDocumentArea")]
        public Templates DragAndDropApartmentNameToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => ApartmentNameItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                ApartmentNameItem);

            int xOffset = 200;
            int yOffset = 55;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(ApartmentNameItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(2000);

            return this;
        }

        [AllureStep("DragAndDropUtilitiesIncludedToDocumentArea")]
        public Templates DragAndDropUtilitiesIncludedToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => UtilitiesIncludedItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                UtilitiesIncludedItem);

            int xOffset = 200;
            int yOffset = 60;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(UtilitiesIncludedItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }
        [AllureStep("DragAndDropLeaseTermToDocumentArea")]
        public Templates DragAndDropLeaseTermToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => LeaseTermItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                LeaseTermItem);

            int xOffset = 200;
            int yOffset = 65;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(LeaseTermItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropMoveInDateToDocumentArea")]
        public Templates DragAndDropMoveInDateToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => MoveInDateItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                MoveInDateItem);

            int xOffset = 200;
            int yOffset = 70;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(MoveInDateItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropLeaseEndDateToDocumentArea")]
        public Templates DragAndDropLeaseEndDateToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => LeaseEndDateItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                LeaseEndDateItem);

            int xOffset = 200;
            int yOffset = 75;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(LeaseEndDateItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropTotalRentToDocumentArea")]
        public Templates DragAndDropTotalRentToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => TotalRentItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                TotalRentItem);

            int xOffset = 200;
            int yOffset = 80;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(TotalRentItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropMonthlyRentToDocumentArea")]
        public Templates DragAndDropMonthlyRentToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => MonthlyRentItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                MonthlyRentItem);

            int xOffset = 200;
            int yOffset = 85;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(MonthlyRentItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropDepositToDocumentArea")]
        public Templates DragAndDropDepositToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => DepositItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                DepositItem);

            int xOffset = 200;
            int yOffset = 88;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(DepositItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropCurrentDateToDocumentArea")]
        public Templates DragAndDropCurrentDateToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => CurrentDateItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                CurrentDateItem);

            int xOffset = 200;
            int yOffset = 90;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(CurrentDateItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropApartmentNameToDocumentArea")]
        public Templates DragAndDropTotalMoveInCostToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => TotalMoveInCostItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                TotalMoveInCostItem);

            int xOffset = 200;
            int yOffset = 95;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(TotalMoveInCostItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropBrokerSignToDocumentArea")]
        public Templates DragAndDropBrokerSignToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => BrokerSignItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                BrokerSignItem);

            int xOffset = 200;
            int yOffset = 100;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(BrokerSignItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropBrokerFirstNameToDocumentArea")]
        public Templates DragAndDropBrokerFirstNameToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => BrokerFirstNameItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                BrokerFirstNameItem);

            int xOffset = 200;
            int yOffset = 5;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(BrokerFirstNameItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropBrokerLastNameToDocumentArea")]
        public Templates DragAndDropBrokerLastNameToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => BrokerLastNameItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                BrokerLastNameItem);

            int xOffset = 200;
            int yOffset = 20;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(BrokerLastNameItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }

        [AllureStep("DragAndDropLLCNameToDocumentArea")]
        public Templates DragAndDropLLCNameToDocumentArea()
        {
            var driver = Browser._Driver;

            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => LLCNameItem.Displayed);

            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                LLCNameItem);

            int xOffset = 200;
            int yOffset = 10;

            var actions = new Actions(driver);
            actions
                .ClickAndHold(LLCNameItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset)
                .Release()
                .Build()
                .Perform();

            WaitUntil.WaitSomeInterval(100);

            return this;
        }
    }
}
