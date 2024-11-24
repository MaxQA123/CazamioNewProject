using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr"))]
        public IWebElement FirstRow;
    }
}
