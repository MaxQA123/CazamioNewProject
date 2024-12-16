using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.BuildingApartmentsTbls
{
    public partial class BuildingApartmentsTbl
    {
        [FindsBy(How = How.XPath, Using = ("//app-building-apartments//table//tbody//tr"))]
        public IWebElement FirstRow;

        [FindsBy(How = How.XPath, Using = ("//app-building-apartments//table//tbody//tr//td"))]
        public IWebElement VlOfClmnUnitFrstRw;
    }
}
