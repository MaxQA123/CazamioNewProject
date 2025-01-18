using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
        Application application = Application.Generate();
        Apartment apartment = Apartment.Generate();

        [AllureStep("GetFullEmail")]
        public string GetFullEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string fullEmail = VlFromStringLeadEmail.Text;

            return fullEmail;
        }

        [AllureStep("CopyEmailBeforeDogFromFieldGetApplicationLink")]
        public string CopyEmailBeforeDogFromFieldGetApplicationLink()
        {
            WaitUntil.WaitSomeInterval(2000);
            string copyPartEmail = VlFromStringLeadEmail.Text;
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
    }
}
