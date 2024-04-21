using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [AllureStep("ClickButtonCreateAgent")]
        public ListOfAgents ClickButtonCreateAgent()
        {
            Pages.JScriptExecutor
                .WaitLoader();
            WaitUntil.CustomElementIsVisible(ButtonCreateAgent);
            WaitUntil.CustomElementIsClickable(ButtonCreateAgent);
            Button.Click(ButtonCreateAgent);

            return this;
        }
    }
}
