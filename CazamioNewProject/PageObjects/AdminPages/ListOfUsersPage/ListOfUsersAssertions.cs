using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.UsersPage
{
    public partial class ListOfUsers
    {
        [AllureStep("VerifyTitleListOfUsersPg")]
        public ListOfUsers VerifyTitleListOfUsersPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfUsersPg));

            return this;
        }
    }
}
