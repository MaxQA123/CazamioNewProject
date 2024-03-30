﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ReportsPage
{
    public partial class Reports
    {
        [FindsBy(How = How.XPath, Using = "//div[text() = 'Reports']")]
        public IWebElement TitleReportsPage;
    }
}
