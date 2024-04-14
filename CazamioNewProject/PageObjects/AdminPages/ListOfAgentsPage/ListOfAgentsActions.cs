using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [AllureStep("ClickButtonCreateAgent")]
        public ListOfAgents ClickButtonCreateAgent()
        {
            WaitUntil.WaitSomeInterval(500);
            Button.Click(ButtonCreateAgentAgntsPage);

            return this;
        }
    }
}
