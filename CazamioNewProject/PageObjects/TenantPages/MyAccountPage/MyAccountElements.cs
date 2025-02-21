using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        #region Applications tab

        [FindsBy(How = How.XPath, Using = "//my-info//applications//div[@class = 'application-apartments-collection']//div[@class = 'apartment-info']//div[@class = 'application-id']")]
        public IWebElement ApplicationIdStringAndValueFromFrstRw;

        #endregion
    }
}
