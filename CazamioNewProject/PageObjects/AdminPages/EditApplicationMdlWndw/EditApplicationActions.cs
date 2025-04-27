using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.EditApplicationMdlWndw
{
    public partial class EditApplicationMdlWndw
    {
        Application application = Application.Generate();
        AgentBroker agentBroker = AgentBroker.Generate();
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();
        TenantOccupantMySpace tenantOccupantMySpace = TenantOccupantMySpace.Generate();
        TenantGuarantorMySpace tenantGuarantorMySpace = TenantGuarantorMySpace.Generate();

        [AllureStep("GetRandomEmailBeforeDogFromEmailAddressMainApplicant")]
        public string GetRandomEmailBeforeDogFromEmailAddressMainApplicant()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = EmailAddressMainApplicantFieldInput.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetFullEmailAddressMainApplicant")]
        public string GetFullEmailAddressMainApplicant()
        {
            WaitUntil.CustomElementIsVisible(EmailAddressMainApplicantFieldInput);
            string getEmail = EmailAddressMainApplicantFieldInput.GetAttribute("value");
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }

        [AllureStep("GetRandomEmailBeforeDogFromEmailAddressOccupant")]
        public string GetRandomEmailBeforeDogFromEmailAddressOccupant()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FirstFieldInputEmailAddress.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetFullEmailAddressOccupantFromFirstFieldInput")]
        public string GetFullEmailAddressOccupantFromFirstFieldInput()
        {
            WaitUntil.CustomElementIsVisible(FirstFieldInputEmailAddress);
            string getEmail = FirstFieldInputEmailAddress.GetAttribute("value");
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }

        [AllureStep("GetRandomEmailBeforeDogFromEmailAddressGuarantor")]
        public string GetRandomEmailBeforeDogFromEmailAddressGuarantor()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = SecondFieldInputEmailAddress.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("GetFullEmailAddressGuarantorFromSecondFieldInput")]
        public string GetFullEmailAddressGuarantorFromSecondFieldInput()
        {
            WaitUntil.CustomElementIsVisible(SecondFieldInputEmailAddress);
            string getEmail = SecondFieldInputEmailAddress.GetAttribute("value");
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }
    }
}
