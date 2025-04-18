﻿using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfAgentsPage
{
    public partial class ListOfAgents
    {
        [AllureStep("VerifyTitleAgentsPg")]
        public ListOfAgents VerifyTitleAgentsPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleAgentsPage));

            return this;
        }
    }
}
