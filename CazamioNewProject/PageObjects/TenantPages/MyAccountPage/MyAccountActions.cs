using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.TenantPages.MyAccountPage
{
    public partial class MyAccount
    {
        [AllureStep("GetApplicationId")]
        public string GetApplicationId()
        {
            WaitUntil.CustomElementIsVisible(ApplicationIdStringAndValueFromFrstRw);
            string applicationIdText = ApplicationIdStringAndValueFromFrstRw.Text;
            Regex regexOnlyApplicationIdNumber = new Regex(@"(\d+)");
            string onlyApplicationIdNumber = regexOnlyApplicationIdNumber.Match(applicationIdText).ToString();

            return onlyApplicationIdNumber;
        }

        [AllureStep("ClickCompleteOrEditThisApplicationBtn")]
        public MyAccount ClickCompleteOrEditThisApplicationBtn()
        {
            WaitUntil.CustomElementIsVisible(CompleteOrEditThisApplicationBtn);
            Button.Click(CompleteOrEditThisApplicationBtn);

            return this;
        }
    }
}
