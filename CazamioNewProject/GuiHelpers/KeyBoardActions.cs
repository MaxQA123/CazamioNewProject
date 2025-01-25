using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CazamioNewProject.GuiHelpers
{
    public class KeyBoardActions
    {
        public static void ClickArrowUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowUp)
                .Build()
                .Perform();
        }

        public static void ClickArrowDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowDown)
                .Build()
                .Perform();
        }

        public static void ClickArrowLeft()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowLeft)
                .Build()
                .Perform();
        }

        public static void ClickArrowRight()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.ArrowRight)
                .Build()
                .Perform();
        }

        public static void ClickEnterButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Enter)
                .Build()
                .Perform();
        }

        public static void ClickEscapeButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Escape)
                .Build()
                .Perform();
        }

        public static void ClickSpaceButton()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Space)
                .Build()
                .Perform();
        }

        public static void ScrollToElement(IWebElement element)
        {
            new Actions(Browser._Driver)
                .ScrollToElement(element)
                .Build()
                .Perform();
        }

        public static void ScrollToDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.End)
                .Build()
                .Perform();
        }

        public static void ScrollToUp()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Home)
                .Build()
                .Perform();
        }

        public static void ClickTab()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Tab)
                .Build()
                .Perform();
        }

        public static void ClickBackspace()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Backspace)
                .Build()
                .Perform();
        }

        public static void ClickInsert()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Insert)
                .Build()
                .Perform();
        }

        public static void ClearValue()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Delete)
                .Build()
                .Perform();
        }
    }
}
