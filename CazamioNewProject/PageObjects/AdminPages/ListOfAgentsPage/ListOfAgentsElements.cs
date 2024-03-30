using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Agents']"))]
        public IWebElement TitleAgentsPage;

        [FindsBy(How = How.XPath, Using = ("//cazamio-button[@text= 'Create Agent']"))]
        public IWebElement ButtonCreateAgentAgntsPage;
    }
}
