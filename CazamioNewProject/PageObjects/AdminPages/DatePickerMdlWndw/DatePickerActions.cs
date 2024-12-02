using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.DatePickerMdlWndw
{
    public partial class DatePicker
    {
        #region Selecting a days

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

        [AllureStep("SelectFisrtDayInLastMonth")]
        public void SelectFisrtDayInLastMonth()
        {
            WaitUntil.WaitSomeInterval(1000);
            var element = Browser._Driver.FindElement(By.XPath($"//table//tbody[@class = 'mat-calendar-body']//button/span[contains(text(), '{1}')]"));
            element.Click();
        }

        [AllureStep("SelectFisrtDayInNextMonth")]
        public void SelectFisrtDayInNextMonth()
        {
            WaitUntil.WaitSomeInterval(1000);
            var element = Browser._Driver.FindElement(By.XPath($"//table//tbody[@class = 'mat-calendar-body']//button/span[contains(text(), '{1}')]"));
            element.Click();
        }

        #endregion

        #region Selecting a months

        [AllureStep("SelectLastMonth")]
        public void SelectLastMonth()
        {
            WaitUntil.WaitSomeInterval(1000);

            // Вычисляем прошлый месяц
            string lastMonthName = DateTime.Now.AddMonths(-1).ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture); // Получаем полное название месяца
            string lastMonthShortName = lastMonthName.Substring(0, 3).ToUpper(); // Получаем первые три буквы названия месяца

            // Используем WebDriverWait для ожидания элемента
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(drv => drv.FindElement(By.XPath($"//mat-year-view//table//tbody//button//span[contains(text(), '{lastMonthShortName}')]")));
            element.Click();
        }

        [AllureStep("SelectNextMonth")]
        public void SelectNextMonth()
        {
            WaitUntil.WaitSomeInterval(1000);

            // Вычисляем прошлый месяц
            string lastMonthName = DateTime.Now.AddMonths(+1).ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture); // Получаем полное название месяца
            string lastMonthShortName = lastMonthName.Substring(0, 3).ToUpper(); // Получаем первые три буквы названия месяца

            // Используем WebDriverWait для ожидания элемента
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(drv => drv.FindElement(By.XPath($"//mat-year-view//table//tbody//button//span[contains(text(), '{lastMonthShortName}')]")));
            element.Click();
        }

        #endregion

        #region Selecting a years

        [AllureStep("SelectCurrentYear")]
        public void SelectCurrentYear()
        {
            WaitUntil.WaitSomeInterval(1000);
            int currentYear = DateTime.Now.Year; // Получаем текущий год
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(drv => drv.FindElement(By.XPath($"//mat-multi-year-view//table//tbody//button//span[contains(text(), '{currentYear}')]")));
            element.Click();
        }

        [AllureStep("SelectNextYear")]
        public void SelectNextYear()
        {
            WaitUntil.WaitSomeInterval(1000);
            int nextYear = DateTime.Now.Year + 1; // Получаем следующий год
            var wait = new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(10));

            // Ожидаем, пока элемент с текстом следующего года станет видимым, и кликаем
            var element = wait.Until(drv => drv.FindElement(By.XPath($"//mat-multi-year-view//table//tbody//button//span[contains(text(), '{nextYear}')]")));
            element.Click();
        }

        #endregion

        [AllureStep("ClickButtonDropDownYearMonth")]
        public DatePicker ClickButtonDropDownYearMonth()
        {
            WaitUntil.CustomElementIsVisible(ButtonForOpenDropDownYearMonth);
            WaitUntil.CustomElementIsClickable(ButtonForOpenDropDownYearMonth);
            Button.Click(ButtonForOpenDropDownYearMonth);

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
