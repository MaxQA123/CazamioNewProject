using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.Create_ANewOwnerMdlWndw
{
    public partial class CreateANewOwnerMdlWndw
    {
        [AllureStep("VerifyTitleCreateANewOwnerg")]
        public CreateANewOwnerMdlWndw VerifyTitleCreateANewOwner()
        {
            WaitUntil.CustomElementIsVisible(TitleCreateANewOwner);
            Assert.IsTrue(Successfully.IsVisible(TitleCreateANewOwner));

            return this;
        }

        [AllureStep("GetEmailFromFieldOwnerEmail")]
        public string GetEmailFromFieldOwnerEmail()
        {
            WaitUntil.WaitSomeInterval(100);
            string getUserName = FieldInputOwnerEmail.GetAttribute("value");
            string getUserNameActual = getUserName.ToString();

            return getUserNameActual;
        }
    }
}
