using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfMarketplaceAdminsPage
{
    public partial class ListOfMarketplaceAdmins
    {
        [AllureStep("ClickButtonCreateMarketplaceAdmin")]
        public ListOfMarketplaceAdmins ClickButtonCreateMarketplaceAdmin()
        {
            Button.Click(ButtonCreateMarketplaceAdmin);

            return this;
        }

        [AllureStep("GetLastEmailFromTable")]
        public string GetLastEmailFromTable()
        {
            WaitUntil.CustomElementIsVisible(LastMarketplaceAdminEmailOnPage);
            string getEmail = LastMarketplaceAdminEmailOnPage.Text;
            string getEmailActual = getEmail.ToString();

            return getEmailActual;
        }
    }
}
