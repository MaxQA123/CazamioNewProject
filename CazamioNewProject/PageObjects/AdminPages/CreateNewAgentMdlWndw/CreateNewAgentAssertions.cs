using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.CreateNewAgentMdlWndw
{
    public partial class CreateNewAgentMdlWndw
    {
        [AllureStep("Verify Title Create New Agent mdl wndw")]
        public CreateNewAgentMdlWndw VerifyTitleCreateNewAgentMdlWndw()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleCreateNewAgent));

            return this;
        }

        //[AllureStep("VerifyMessageNewAgentCreatedSuccessfully")]
        //public CreateNewAgentMdlWndw VerifyMessageNewAgentCreatedSuccessfully()
        //{
        //    Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageNewAgentCreatedSuccessfully));


        //    return this;
        //}
    }
}
