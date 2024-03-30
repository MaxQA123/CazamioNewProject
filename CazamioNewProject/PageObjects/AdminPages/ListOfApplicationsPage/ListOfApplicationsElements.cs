using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfApplicationsPage
{
    public partial class ListOfApplications
    {
        [FindsBy(How = How.XPath, Using = "//div[text()= 'List of applications']")]
        public IWebElement TitleListOfApplications;

        [FindsBy(How = How.XPath, Using = "//button//span[text() = '+Application']")]
        public IWebElement ButtonPlusApplication;

        [FindsBy(How = How.XPath, Using = "//application-list//tbody//tr//td[text() = '2 Washington Square #2']")]
        public IWebElement ItemTwoWashingtonSquareUnitTwo;

        [FindsBy(How = How.XPath, Using = "//application-list//input[@id = 'field-search']")]
        public IWebElement FieldInputSearchListOfApplications;

        [FindsBy(How = How.XPath, Using = "//application-list//div[@class = 'custom-table-wrapper']//tbody//tr")]
        public IWebElement FirstItemInLitsOFApplications;
    }
}
