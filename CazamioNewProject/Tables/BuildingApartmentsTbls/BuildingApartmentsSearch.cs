using CazamioNewProject.GuiHelpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.Tables.BuildingApartmentsTbls
{
    public partial class BuildingApartments
    {
        [FindsBy(How = How.XPath, Using = ("//table//tbody//tr"))]
        public IWebElement FirstRow;

        //public IWebElement ItemFullNameAgent;

        //public IWebElement SetItemAgent()
        //{
        //    // Создание экземпляра класса Owner
        //    Agent agent = new Agent().Generate();

        //    // Использование переменной экземпляра owner для построения XPath
        //    var xpath = "//ng-dropdown-panel//span[text() = '" + agent.FullNameCreatedAgentMySpace.FirstAgent + "']";

        //    // Присвоение значения ItemForAutotestForBroker
        //    return Browser._Driver.FindElement(By.XPath(xpath));
        //}
    }
}
