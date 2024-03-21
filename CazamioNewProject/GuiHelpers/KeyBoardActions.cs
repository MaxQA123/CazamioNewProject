using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CazamioNewProject.GuiHelpers
{
    public class KeyBoardActions
    {
        [AllureStep("ClickArrowUp")]
        public static void ClickArrowUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowUp)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowDown")]
        public static void ClickArrowDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowDown)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowLeft")]
        public static void ClickArrowLeft()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowLeft)
                .Build()
                .Perform();
        }

        [AllureStep("ClickArrowRight")]
        public static void ClickArrowRight()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowRight)
                .Build()
                .Perform();
        }

        [AllureStep("ClickEnterButton")]
        public static void ClickEnterButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
        }

        [AllureStep("ClickEscapeButton")]
        public static void ClickEscapeButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Escape)
                .Build()
                .Perform();
        }

        [AllureStep("ClickSpaceButton")]
        public static void ClickSpaceButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Space)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToElement")]
        public static void ScrollToElement(IWebElement element)
        {
            new Actions(Browser._Driver)
                .ScrollToElement(element)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToDown")]
        public static void ScrollToDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.End)
                .Build()
                .Perform();
        }

        [AllureStep("ScrollToUp")]
        public static void ScrollToUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Home)
                .Build()
                .Perform();
        }

        [AllureStep("ClickTab")]
        public static void ClickTab()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Tab)
                .Build()
                .Perform();
        }

        [AllureStep("ClickBackspace")]
        public static void ClickBackspace()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Backspace)
                .Build()
                .Perform();
        }

        [AllureStep("ClickInsert")]
        public static void ClickInsert()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Insert)
                .Build()
                .Perform();
        }

        [AllureStep("ClearValue")]
        public static void ClearValue()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Delete)
                .Build()
                .Perform();
        }
    }
}
