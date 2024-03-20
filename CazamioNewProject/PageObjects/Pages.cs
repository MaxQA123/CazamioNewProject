using CazamioNewProject.GuiHelpers;
using CazamioNewProject.PageObjects.AdminPages.LogInPage;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects
{
    public class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(driver, page);

            return page;
        }

        public static LogInLandlord LogInLandlord => GetPage<LogInLandlord>();
    }
}
