using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        [AllureStep("GetApplicationIdVl")]
        public string GetApplicationIdVl()
        {
            WaitUntil.CustomElementIsVisible(ApplicationIdVl);
            string getValue = ApplicationIdVl.Text;
            string getValueActual = getValue.ToString();

            return getValueActual;
        }
    }
}
