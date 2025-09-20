using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [AllureStep("Verify Title Agents page")]
        public ListOfAgents VerifyTitleAgentsPg()
        {
            WaitUntil.CustomElementIsVisible(TitleAgentsPage);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAgentsPage));

            return this;
        }

        [AllureStep("VerifyMessageNewAgentCreatedSuccessfully")]
        public ListOfAgents VerifyMessageNewAgentCreatedSuccessfully()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageNewAgentCreatedSuccessfully));

            return this;
        }
    }
}
