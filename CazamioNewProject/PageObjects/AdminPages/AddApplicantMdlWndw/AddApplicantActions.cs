using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.AddApplicantMdlWndw
{
    public partial class AddApplicantMdlWndw
    {
        TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();
        TenantGuarantorMySpace tenantGuarantorMySpace = TenantGuarantorMySpace.Generate();

        [AllureStep("ClickBtnAdd")]
        public AddApplicantMdlWndw ClickBtnAdd()
        {
            WaitUntil.WaitSomeInterval(1000);
            WaitUntil.CustomElementIsClickable(BtnAdd);
            Button.Click(BtnAdd);
            Pages.ToasterMessagesLandlord
               .VerifMessageAddedApplicantsToApplication();

            return this;
        }

        [AllureStep("CopyEmailBeforeDogFromFirstFieldInputEmailAddress")]
        public string CopyEmailBeforeDogFromFirstFieldInputEmailAddress()
        {
            WaitUntil.WaitSomeInterval(100);
            string copyPartEmail = FirstFieldInputEmailAddress.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("CopyEmailBeforeDogFromSecondFieldInputEmailAddress")]
        public string CopyEmailBeforeDogFromSecondFieldInputEmailAddress()
        {
            WaitUntil.WaitSomeInterval(100);
            string copyPartEmail = SecondFieldInputEmailAddress.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
    }
}
