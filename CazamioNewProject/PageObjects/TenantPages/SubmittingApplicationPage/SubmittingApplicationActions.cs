using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.TenantPages.SubmittingApplicationPage
{
    public partial class SubmittingApplication
    {
        [AllureStep("GetApplicationIdVl")]
        public string GetApplicationIdVl()
        {
            WaitUntil.CustomElementIsVisible(ApplicationIdVl);
            string getValue = ApplicationIdVl.Text;

            Match match = Regex.Match(getValue, @"#(\d+)");

            if (match.Success)
            {
                return match.Groups[1].Value; 
            }

            return string.Empty;
        }
    }
}
