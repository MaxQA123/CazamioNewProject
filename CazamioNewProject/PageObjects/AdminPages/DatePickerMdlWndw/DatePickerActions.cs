using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.DatePickerMdlWndw
{
    public partial class DatePicker
    {
        #region Selecting a day

        private static IWebElement _element;

        [AllureStep("SelectCurrentDayPlusOneDay")]
        public void SelectCurrentDayPlusOneDay()
        {
            WaitUntil.WaitSomeInterval(1000);
            var element = Browser._Driver.FindElement(By.XPath($"//table//tbody[@class = 'mat-calendar-body']//button/span[contains(text(), '{DateTime.Now.AddDays(1).Day}')]"));
            element.Click();
        }

        [AllureStep("SelectCurrentDay")]
        public void SelectCurrentDay()
        {
            WaitUntil.WaitSomeInterval(1000);
            var element = Browser._Driver.FindElement(By.XPath($"//table//tbody[@class = 'mat-calendar-body']//button/span[contains(text(), '{DateTime.Now.Day}')]"));
            element.Click();
        }

        [AllureStep("SelectPreviousDay")]
        public void SelectPreviousDay()
        {
            WaitUntil.WaitSomeInterval(1000);
            var element = Browser._Driver.FindElement(By.XPath($"//table//tbody[@class = 'mat-calendar-body']//button/span[contains(text(), '{DateTime.Now.AddDays(-1).Day}')]"));
            element.Click();
        }

        #endregion

        [AllureStep("ClickButtonDropDownYearMonth")]
        public DatePicker ClickButtonDropDownYearMonth()
        {
            WaitUntil.CustomElementIsVisible(ButtonDropDownYearMonth);
            WaitUntil.CustomElementIsClickable(ButtonDropDownYearMonth);
            Button.Click(ButtonDropDownYearMonth);

            return this;
        }

        [AllureStep("ClickButtonArrowPreviousYear")]
        public DatePicker ClickButtonArrowPreviousYear()
        {
            WaitUntil.CustomElementIsVisible(ButtonArrowPreviousYear);
            WaitUntil.CustomElementIsClickable(ButtonArrowPreviousYear);
            Button.Click(ButtonArrowPreviousYear);

            return this;
        }

        [AllureStep("ClickButtonArrowNextYear")]
        public DatePicker ClickButtonArrowNextYear()
        {
            WaitUntil.CustomElementIsVisible(ButtonArrowNextYear);
            WaitUntil.CustomElementIsClickable(ButtonArrowNextYear);
            Button.Click(ButtonArrowNextYear);

            return this;
        }

        [AllureStep("ClickButtonArrowNextMonth")]
        public DatePicker ClickButtonArrowNextMonth()
        {
            WaitUntil.CustomElementIsVisible(ButtonArrowNextMonth);
            WaitUntil.CustomElementIsClickable(ButtonArrowNextMonth);
            Button.Click(ButtonArrowNextMonth);

            return this;
        }
    }
}
