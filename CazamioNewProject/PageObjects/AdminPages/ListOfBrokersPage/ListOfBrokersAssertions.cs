using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("VerifyTitleListOfBrokersPg")]
        public ListOfBrokers VerifyTitleListOfBrokersPg()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfBrokers);
            Assert.IsTrue(Successfully.IsVisible(TitleListOfBrokers));

            return this;
        }
    }
}
