﻿using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;

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

    public class Errors
    {
        public static Boolean IsInvisible(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(1000);
            try
            {
                if (element.Enabled == true)
                {
                    Console.WriteLine(element.Text);

                    return false;
                }

                return true;


            }
            catch (NoSuchElementException) { return true; }

            catch (StaleElementReferenceException) { return true; }
        }
    }

    public class Successfully
    {
        public static Boolean IsVisible(IWebElement element)
        {
            WaitUntil.WaitSomeInterval(100);
            try
            {
                if (element.Enabled == true)
                {
                    Console.WriteLine(element.Text);

                    return true;
                }

                return false;
            }
            catch (NoSuchElementException) { return false; }

            catch (StaleElementReferenceException) { return false; }
        }
    }


    //public class SuccessfullyTwo
    //{
    //    public static Boolean IsVisible(IWebElement element)
    //    {
    //        WaitUntil.WaitSomeInterval(1000);
    //        try
    //        {
    //            if (element.Enabled == true)
    //            {
    //                Console.WriteLine(element.GetAttribute("value"));

    //                return true;
    //            }

    //            return false;


    //        }
    //        catch (NoSuchElementException) { return false; }

    //        catch (StaleElementReferenceException) { return false; }
    //    }
    //}
}
