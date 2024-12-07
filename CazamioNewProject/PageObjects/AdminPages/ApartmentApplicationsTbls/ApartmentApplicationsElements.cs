using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ApartmentApplicationsTbls
{
    public partial class ApartmentApplicationsTbl
    {
        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr"))]
        public IWebElement FirstRow;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[2]"))]
        public IWebElement ValueFromColumnApartmentFirstRow;

        [FindsBy(How = How.XPath, Using = ("//app-applications//table//tbody//tr//td[3]//div"))]
        public IWebElement VlMainApplicantFrmClmnApplicantsFrstRw;
    }
}
