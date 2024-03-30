using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
