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
        public static void SecondTabClose()
        {
            WaitUntil.WaitSomeInterval(1000);
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
                throw new InvalidOperationException("Недостаточно вкладок для закрытия (требуется минимум 2).");
            }

            WaitUntil.WaitSomeInterval(1000);
        }

        public static void SecondTabSelect()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[1]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }

    public class SelectThirdTabBrowser
    {
        public static void Open()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[2]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }

    public class SelectFourthTabBrowser
    {
        public static void Open()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[3]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }

    public class SelectFifthTabBrowser
    {
        public static void Open()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[4]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }

    public class SelectSixthTabBrowser
    {
        public static void Open()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);
            Browser._Driver.SwitchTo().Window(tabsList[5]);
            WaitUntil.WaitSomeInterval(1000);

        }
    }

    public class SecondTabBrowser
    {
        public static void Close()
        {
            WaitUntil.WaitSomeInterval(1000);
            List<string> tabsList = new List<string>(Browser._Driver.WindowHandles);

            if (tabsList.Count >= 3)
            {
                // Закрываем вторую вкладку (индекс 1)
                Browser._Driver.SwitchTo().Window(tabsList[1]).Close();

                // Переключаемся на третью вкладку (индекс 2)
                Browser._Driver.SwitchTo().Window(tabsList[2]);
            }
            else
            {
                throw new InvalidOperationException("Недостаточно вкладок для переключения (требуется минимум 3).");
            }

            WaitUntil.WaitSomeInterval(1000);
        }
    }
}
