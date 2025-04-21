using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ApplicationDetailPage
{
    public partial class ApplicationDetail
    {
        [AllureStep("ClickEditApplicationBtn")]
        public ApplicationDetail ClickEditApplicationBtn()
        {
            WaitUntil.CustomElementIsVisible(EditApplicationBtn);
            Button.Click(EditApplicationBtn);

            return this;
        }
    }
}
