using CazamioNewProject.GuiHelpers;
using CazamioNewProject.Objects;
using NUnit.Allure.Attributes;
using System.Text.RegularExpressions;

namespace CazamioNewProject.PageObjects.AdminPages.CreateANewMarketplaceAdminMdlWndw
{
    public partial class CreateANewMarketplaceAdminMdlWindow
    {
        MarketplaceAdmin marketplaceAdmin = MarketplaceAdmin.Generate();

        [AllureStep("ClickButtonCreate")]
        public CreateANewMarketplaceAdminMdlWindow ClickButtonCreate()
        {
            WaitUntil.WaitSomeInterval(100);
            Button.Click(ButtonCreate);

            return this;
        }

        [AllureStep("CopyEmailBeforeDogFromFieldInputEmail")]
        public string CopyEmailBeforeDogFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyPartEmail = FieldInputEmail.GetAttribute("value");
            Regex regexPartEmail = new Regex(@"^..........");
            string partEmail = regexPartEmail.Match(copyPartEmail).ToString();

            return partEmail;
        }

        [AllureStep("CopyFullEmailFromFieldInputEmail")]
        public string CopyFullEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(500);
            string copyFullEmail = FieldInputEmail.GetAttribute("value");

            return copyFullEmail;
        }

        [AllureStep("GetEmailFromFieldInputEmail")]
        public string GetEmailFromFieldInputEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserName = FieldInputEmail.GetAttribute("value");
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }
    }
}
