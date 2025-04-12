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

        [AllureStep("DragAndDropBrokerSignToDocumentArea")]
        public Templates DragAndDropBrokerSignToDocumentArea()
        {
            WaitUntil.WaitSomeInterval(15000);

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

            WaitUntil.WaitSomeInterval(2000);

            return this;
        }
    }
}
