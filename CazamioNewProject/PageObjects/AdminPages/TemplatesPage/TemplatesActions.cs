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

        //[AllureStep("DragAndDropBrokerSignToDocumentArea")]
        //public Templates DragAndDropBrokerSignToDocumentArea()
        //{
        //    WaitUntil.WaitSomeInterval(15000);

        //    var driver = Browser._Driver;

        //    // 1. Ожидание и прокрутка
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(5))
        //        .Until(d => BrokerSignItem.Displayed);
        //    ((IJavaScriptExecutor)driver).ExecuteScript(
        //        "arguments[0].scrollIntoView({block: 'center'});",
        //        BrokerSignItem);

        //    // 2. Действие с точными координатами
        //    new Actions(driver)
        //        .MoveToElement(BrokerSignItem, 10, 10)
        //        .Pause(TimeSpan.FromMilliseconds(300))
        //        .ClickAndHold()
        //        .Pause(TimeSpan.FromMilliseconds(500))
        //        .MoveToElement(DocumentArea, 100, 50)
        //        .Pause(TimeSpan.FromMilliseconds(500))
        //        .Release()
        //        .Build()
        //        .Perform();

        //    // 3. Ожидание применения изменений
        //    WaitUntil.WaitSomeInterval(2000);

        //    return this;
        //}

        [AllureStep("DragAndDropBrokerSignToDocumentArea")]
        public Templates DragAndDropBrokerSignToDocumentArea()
        {
            WaitUntil.WaitSomeInterval(15000);

            var driver = Browser._Driver;

            // Убедиться, что элемент виден
            new WebDriverWait(driver, TimeSpan.FromSeconds(5))
                .Until(d => BrokerSignItem.Displayed);

            // Прокрутка к элементу
            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView({block: 'center'});",
                BrokerSignItem);

            // Смещение при перетаскивании
            int xOffset = 100;
            int yOffset = 50;

            // Перетаскивание с применением логики из MoveSticker
            var actions = new Actions(driver);
            actions
                .ClickAndHold(BrokerSignItem)
                .MoveByOffset(xOffset, yOffset)
                .MoveByOffset(xOffset, yOffset) // дополнительный шаг — иногда нужен для стабильности
                .Release()
                .Build()
                .Perform();

            // Ожидание после дропа
            WaitUntil.WaitSomeInterval(2000);

            return this;
        }
    }
}
