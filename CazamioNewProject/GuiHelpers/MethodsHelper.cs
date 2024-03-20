using NUnit.Allure.Attributes;
using OpenQA.Selenium;

namespace CazamioNewProject.GuiHelpers
{
    public class InputGeneral
    {
        [AllureStep("InputFunctionWithClear")]
        public static void InputFunctionWithClear(IWebElement element, string text)
        {
            WaitUntil.WaitSomeInterval(250);
            WaitUntil.ElementIsClickable(element);
            element.Clear();
            element.SendKeys(text);
        }

        [AllureStep("InputFunctionWithoutClear")]
        public static void InputFunctionWithoutClear(IWebElement element, string text)
        {
            WaitUntil.ElementIsClickable(element);
            element.SendKeys(text);
        }
    }

    public class Button
    {
        [AllureStep("Click")]
        public static void Click(IWebElement element)
        {
            //WaitUntil.CustomElementIsVisible(element);
            WaitUntil.WaitSomeInterval(500);
            element.Click();
        }
    }
}
