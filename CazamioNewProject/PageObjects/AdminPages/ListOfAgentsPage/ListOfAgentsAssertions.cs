using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [AllureStep("VerifyTitleAgentsPg")]
        public ListOfAgents VerifyTitleAgentsPg()
        {
            Assert.IsTrue(Successfully.IsVisible(TitleAgentsPage));

            return this;
        }
    }
}
