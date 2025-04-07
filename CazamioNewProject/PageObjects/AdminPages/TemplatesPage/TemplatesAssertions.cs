using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.TemplatesPage
{
    public partial class Templates
    {
        [AllureStep("VerifyTitleTemplatesPage")]
        public Templates VerifyTitleTemplatesPage()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleTemplatesPage));

            return this;
        }

        [AllureStep("VerifyTitleCreateTemplatePage")]
        public Templates VerifyTitleCreateTemplatePage()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleCreateTemplatePage));

            return this;
        }
    }
}
