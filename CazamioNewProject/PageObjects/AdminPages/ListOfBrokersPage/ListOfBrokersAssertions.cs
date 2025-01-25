using CazamioNewProject.GuiHelpers;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;

namespace CazamioNewProject.PageObjects.AdminPages.ListOfBrokersPage
{
    public partial class ListOfBrokers
    {
        [AllureStep("VerifyTitleListOfBrokersPg")]
        public ListOfBrokers VerifyTitleListOfBrokersPg()
        {
            Assert.IsTrue(TitlesCheck.IsVisible(TitleListOfBrokers));

            return this;
        }

        [AllureStep("VerifyMessageBrokerHasBeenSuccessfullyCreated")]
        public ListOfBrokers VerifyMessageBrokerHasBeenSuccessfullyCreated()
        {
            Assert.IsTrue(ToasterSuccessfully.IsVisible(MessageBrokerHasBeenSuccessfullyCreated));

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
