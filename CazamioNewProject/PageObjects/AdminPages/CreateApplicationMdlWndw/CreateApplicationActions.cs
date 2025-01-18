using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CazamioNewProject.PageObjects.AdminPages.CreateApplicationMdlWndw
{
    public partial class CreateApplicationMdlWndw
    {
        TenantCreatorMySpace tenantCreatorMySpace = TenantCreatorMySpace.Generate();

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
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = VlFromStringLeadEmail.Text;
            Regex regexPartEmail = new Regex(@"^.........................");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }
    }
}
