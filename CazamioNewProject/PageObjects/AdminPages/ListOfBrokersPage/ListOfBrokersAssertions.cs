using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("Verify Title List of brokers page")]
        public ListOfBrokers VerifyTitleListOfBrokersPg()
        {
            WaitUntil.CustomElementIsVisible(TitleListOfBrokers);
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfBrokers));

            return this;
        }

        [AllureStep("VerifyEmailInListOfBrokers")]
        public ListOfBrokers VerifyEmailInListOfBrokers(string getFullEmail, string getEmailFromListOfBrokers)
        {
            WaitUntil.WaitSomeInterval(500);
            Assert.AreEqual(getFullEmail, getEmailFromListOfBrokers);

            return this;
        }
    }
}
