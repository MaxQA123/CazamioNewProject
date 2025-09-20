using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [FindsBy(How = How.XPath, Using = ("//div[text()= 'Agents']"))]
        public IWebElement TitleAgentsPage;

        [FindsBy(How = How.XPath, Using = ("//cazamio-button[@text= 'Create Agent']"))]
        public IWebElement ButtonCreateAgent;

        //Appeared if created a new agent
        [FindsBy(How = How.XPath, Using = "//p[text() = 'New agent created successfully!']")]
        public IWebElement MessageNewAgentCreatedSuccessfully;
    }
}
