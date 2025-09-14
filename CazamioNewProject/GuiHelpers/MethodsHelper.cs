using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CazamioNewProject.GuiHelpers
{
    public class InputGeneral
    {
        public static void InputFunctionWithClear(IWebElement element, string text)
        {
            WaitUntil.WaitSomeInterval(250);
            WaitUntil.ElementIsClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        public static void InputFunctionWithoutClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(text);
        }
    }

    public class Button
    {
        public static void Click(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(500);
            WaitUntil.CustomElementIsVisible(element);
            element.Click();
        }
    }

    public class SwitchingBetweenBrowserTabs
    {
        public static void SecondTabCloseFirstTabSelect()
        {
            WaitUntil.WaitSomeInterval(100);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);

            if (tabsList.Count >= 2) // Проверяем, что есть хотя бы 2 вкладки
            {
                // Закрываем вторую вкладку (индекс 1)
                Browser._Driver.SwitchTo().Window(tabsList[1]).Close();

                // Возвращаем фокус на первую вкладку (индекс 0)
                Browser._Driver.SwitchTo().Window(tabsList[0]);
            }
            else
            {
                throw new InvalidOperationException("Not enough tabs to close (requires at least 2).");
            }
        }

        public static void SecondTabClose()
        {
            WaitUntil.WaitSomeInterval(100);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);

            if (tabsList.Count >= 2) 
            {
                Browser._Driver.SwitchTo().Window(tabsList[1]).Close();
            }
            else
            {
                throw new InvalidOperationException("Not enough tabs to close (requires at least 2).");
            }
        }

        public static void CloseSecondTabAndSelectFirstTab()
        {
            WaitUntil.WaitSomeInterval(100);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);

            if (tabsList.Count >= 2)
            {
                // Закрываем вторую вкладку
                Browser._Driver.SwitchTo().Window(tabsList[1]).Close();

                // Переключаемся на первую вкладку
                Browser._Driver.SwitchTo().Window(tabsList[0]);
            }
            else
            {
                throw new InvalidOperationException("Not enough tabs to close (requires at least 2).");
            }
        }

        public static void CloseSecondThirdFourthTabs()
        {
            WaitUntil.WaitSomeInterval(100);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);

            if (tabsList.Count >= 4)
            {
                // Закрываем три последние вкладки (начиная с последней)
                for (int i = 3; i >= 1; i--)
                {
                    Browser._Driver.SwitchTo().Window(tabsList[i]).Close();
                    WaitUntil.WaitSomeInterval(100); // небольшая пауза между закрытием
                }

                // Переключаемся на оставшуюся первую вкладку
                Browser._Driver.SwitchTo().Window(tabsList[0]);
            }
            else
            {
                throw new InvalidOperationException("Not enough tabs to close (requires at least 4).");
            }
        }

        public static void SecondTabSelect()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[1]);
            WaitUntil.WaitSomeInterval(1000);

        }

        public static void ThirdTabSelect()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);

        }

        public static void FouthTabSelect()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }
}
